using Saaed360Modern.Contracts.Wcf;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IReportTemplateService
    {
        Task<string> GenerateAsync(ReportDTO report);
        Task<string> GenerateReformPermissionReportFromTemplate(ReportDTO report);
    }
}

