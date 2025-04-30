// Infrastructure/RazorReportTemplateService.cs
using Application.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RazorLight;
using Saaed360Modern.Contracts.Wcf;
using System;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    /// <summary>
    /// Service for generating reports using Razor templates configured via DI.
    /// </summary>
    public sealed class RazorReportTemplateService : IReportTemplateService
    {
        private readonly IRazorLightEngine _engine;
        private readonly ILogger<RazorReportTemplateService> _logger;
        private readonly IConfiguration _configuration; // Keep configuration to read template *names*

        public RazorReportTemplateService(
            IRazorLightEngine engine, // Inject engine directly
            ILogger<RazorReportTemplateService> logger,
            IConfiguration configuration) // Keep for template names
        {
            _engine = engine ?? throw new ArgumentNullException(nameof(engine));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            // Removed: _serviceProvider, _templateRoot, _templatePaths, GetTemplatePath, env
        }

        // Removed GetTemplatePath method

        /// <inheritdoc />
        public async Task<string> GenerateAsync(ReportDTO report)
        {
            if (report == null)
            {
                throw new ArgumentNullException(nameof(report));
            }

            try
            {
                // Get template *name* from config
                string templateName = _configuration["Templates:PropertyTemplate"]
                                      ?? throw new InvalidOperationException("Template name not configured for key: Templates:PropertyTemplate");

                _logger.LogInformation("Rendering template 	'{TemplateName}	' for Report ID: {ReportId}", templateName, report.ReportId);
                // Use template name (relative path within project root) as the key
                return await _engine.CompileRenderAsync(templateName, report);
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
                // Get template *name* from config
                string templateName = _configuration["Templates:ReformPermissionReportTemplate"]
                                      ?? throw new InvalidOperationException("Template name not configured for key: Templates:ReformPermissionReportTemplate");

                _logger.LogInformation("Rendering template 	'{TemplateName}	' for Report ID: {ReportId}", templateName, reportData.ReportId);
                // Use template name (relative path within project root) as the key
                return await _engine.CompileRenderAsync(templateName, reportData);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to generate reform permission report template.");
                throw new ReportGenerationException("Failed to generate reform permission report", ex);
            }
        }

        // Removed RenderTemplateAsync helper as it's now simpler
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
