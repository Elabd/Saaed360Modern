using Application.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Saaed360Modern.Infrastructure.ExternalServices.MDTReportServiceRef;
using System.ServiceModel;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MDTReportController : ControllerBase
    {
        private readonly IReportWcfService _reportWcfService;

        public MDTReportController(IReportWcfService reportWcfService )
        {
            _reportWcfService = reportWcfService;
        }

        [HttpGet("ping")]
        public async Task<IActionResult> PingService()
        {
            try
            {
                // Replace with your actual method call
                var result = await _reportWcfService.GetAllCitiesAsync(); // <- example, change this
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error calling WCF service: {ex.Message}");
            }
        }
        [HttpGet("get-cities")]
        public async Task<IActionResult> GetCities()
        {
            try
            {
                var binding = new BasicHttpBinding
                {
                    Security = new BasicHttpSecurity { Mode = BasicHttpSecurityMode.None },
                    MaxReceivedMessageSize = 65536
                };

                var endpoint = new EndpointAddress("http://saaed360.saaed.ae/Saaed360MDTWCF/ReportService.svc");
                using (var client = new ReportServiceClient(binding, endpoint))
                {
                    var result = await client.GetAllCitiesAsync();
                    if (result == null)
                    {
                        return StatusCode(500, "WCF service returned null response.");
                    }
                    return Ok(result);
                }
            }
            catch (CommunicationException ex)
            {
                // WCF-specific communication error
                return StatusCode(500, $"WCF communication error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Genera l error
                return StatusCode(500, $"WCF call failed: {ex.Message}");
            }
        }


        [HttpGet("test")]
        public async Task<IActionResult> TestReportService()
        {
            try
            {
                var binding = new BasicHttpBinding
                {
                    Security = new BasicHttpSecurity { Mode = BasicHttpSecurityMode.Transport },
                    MaxReceivedMessageSize = 65536
                };

                var endpoint = new EndpointAddress("https://saaed360.saaed.ae/Saaed360MDTWCF/ReportService.svc");
                var client = new ReportServiceClient(binding, endpoint);

                // Replace with actual method — check your generated proxy
                var response = await client.GetAllCitiesAsync(); // example only
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"WCF call failed: {ex.Message}");
            }
        }

    }
}
