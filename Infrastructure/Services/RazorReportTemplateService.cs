// Infrastructure/RazorReportTemplateService.cs
using Application.Abstractions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RazorLight;
using Saaed360Modern.Contracts.Wcf;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    /// <summary>
    /// Service for generating reports using Razor templates
    /// </summary>
    public sealed class RazorReportTemplateService : IReportTemplateService
    {
        private readonly RazorLightEngine _engine;
        private readonly ILogger<RazorReportTemplateService> _logger;
        private readonly IServiceProvider _serviceProvider;
        private readonly string _templateRoot;
        private readonly Dictionary<string, string> _templatePaths;

        public RazorReportTemplateService(
            IConfiguration config,
            IWebHostEnvironment env,
            ILogger<RazorReportTemplateService> logger,
            IServiceProvider serviceProvider)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));

            // Get template root directory
            _templateRoot = Path.Combine(env.ContentRootPath, "Templates");

            if (!Directory.Exists(_templateRoot))
            {
                throw new DirectoryNotFoundException($"Template directory not found at: {_templateRoot}");
            }

            // Register known templates with validation
            _templatePaths = new Dictionary<string, string>
            {
                ["Property"] = GetTemplatePath(config, env, "Templates:PropertyTemplate"),
                ["ReformPermission"] = GetTemplatePath(config, env, "Templates:ReformPermissionReportTemplate")
            };

            // Build the Razor engine
            _engine = new RazorLightEngineBuilder()
                .UseFileSystemProject(_templateRoot)
                .UseMemoryCachingProvider()
                .Build();

            // Wire up DI for template pages
            //_engine.Options.TemplatePageActivator = (pageType) =>
            //    ActivatorUtilities.CreateInstance(_serviceProvider, pageType) as ITemplatePage;
        }

        /// <summary>
        /// Gets the full path to a template and validates its existence
        /// </summary>
        private string GetTemplatePath(IConfiguration config, IWebHostEnvironment env, string configKey)
        {
            var templateName = config[configKey];

            if (string.IsNullOrEmpty(templateName))
            {
                throw new InvalidOperationException($"Template name not configured for key: {configKey}");
            }

            var templatePath = Path.Combine(env.ContentRootPath, "Templates", templateName);

            if (!File.Exists(templatePath))
            {
                throw new FileNotFoundException($"Template file not found: {templatePath}");
            }

            return templatePath;
        }

        /// <inheritdoc />
        public async Task<string> GenerateAsync(ReportDTO report)
        {
            if (report == null)
            {
                throw new ArgumentNullException(nameof(report));
            }

            try
            {
                return await RenderTemplateAsync("Property", report);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to generate property report template.");
                throw new ReportGenerationException("Failed to generate property report", ex);
            }
        }

        /// <inheritdoc />
        public async Task<string> GenerateReformPermissionReportFromTemplate(ReportDTO reportData)
        {
            if (reportData == null)
            {
                throw new ArgumentNullException(nameof(reportData));
            }

            try
            {
                return await RenderTemplateAsync("ReformPermission", reportData);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to generate reform permission report template.");
                throw new ReportGenerationException("Failed to generate reform permission report", ex);
            }
        }

        /// <summary>
        /// Renders a template with the provided model data
        /// </summary>
        private async Task<string> RenderTemplateAsync(string templateKey, object model)
        {
            if (!_templatePaths.TryGetValue(templateKey, out var templatePath))
            {
                throw new ArgumentException($"Unknown template key: {templateKey}");
            }

            var template = await File.ReadAllTextAsync(templatePath);
            var templateFileName = Path.GetFileName(templatePath);

            return await _engine.CompileRenderStringAsync(templateFileName, template, model);
        }
    }

    /// <summary>
    /// Custom exception for report generation failures
    /// </summary>
    public class ReportGenerationException : Exception
    {
        public ReportGenerationException(string message) : base(message) { }
        public ReportGenerationException(string message, Exception innerException) : base(message, innerException) { }
    }


}