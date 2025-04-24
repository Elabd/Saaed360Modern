using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Services
{
    public interface IReportsService
    {
        Task<IEnumerable<ReportsSearchResult>> GetReportsSearchAsync(ReportsSearch search);
    }
} 