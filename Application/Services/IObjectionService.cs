using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Infrastructure.Persistence.Entities;

namespace Application.Services
{
    public interface IObjectionService
    {
        Task<List<ViewObjection>> GetResultObjectionsAsync(SearchObjectionDTO search);
    }
} 