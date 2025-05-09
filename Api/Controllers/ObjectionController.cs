using Application.Abstractions;
using Application.DTOs;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ObjectionController : ControllerBase
    {
        private readonly IObjectionService _objectionService;
        private readonly ILogger<ObjectionController> _logger;

        public ObjectionController(
            IObjectionService objectionService,
            ILogger<ObjectionController> logger)
        {
            _objectionService = objectionService;
            _logger = logger;
        }

        [HttpPost("GetResultObjections")]
        public async Task<ActionResult<List<ViewObjection>>> GetResultObjections([FromBody] SearchObjectionDTO search)
        {
            try
            {
                var results = await _objectionService.GetResultObjectionsAsync(search);
                return Ok(results);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex, "Error in GetResultObjections");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }
    }
} 