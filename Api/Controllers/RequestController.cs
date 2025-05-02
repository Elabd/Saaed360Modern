using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Saaed360Modern.Contracts.Wcf;

namespace Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class RequestController : ControllerBase
    {
        private readonly IRequestService _requestService;
        private readonly ICurrentUserService _currentUserService;

        public RequestController(IRequestService requestService, ICurrentUserService currentUserService)
        {
            _requestService = requestService;
            _currentUserService = currentUserService;
        }

        [HttpGet("{requestId}")]
        [ProducesResponseType(typeof(ReportRequestDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<ReportRequestDto>> GetRequestById(long requestId, CancellationToken cancellationToken)
        {
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            Guid[] roleIds = currentUser.Roles?.ToArray() ?? Array.Empty<Guid>();
            var result = await _requestService.GetRequestByIdAsync(requestId, roleIds);
            
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpGet("transferred/{requestId}")]
        [ProducesResponseType(typeof(ReportRequestDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<ReportRequestDto>> GetTransferredRequestById(long requestId, CancellationToken cancellationToken)
        {
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            var result = await _requestService.GetTransferredRequestByIdAsync(requestId, cancellationToken);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost("transfer")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<bool>> TransferRequest([FromBody] ReportRequestDto request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            var result = await _requestService.TransferRequestAsync(request, cancellationToken);
            return Ok(result);
        }

        [HttpGet("can-transfer/{requestId}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<bool>> CanTransferRequest(long requestId, CancellationToken cancellationToken)
        {
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            var result = await _requestService.CanTransferRequestAsync(requestId, cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<bool>> SaveRequest([FromBody] ReportRequestDto request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            var result = await _requestService.SaveRequestAsync(request, cancellationToken);
            return Ok(result);
        }

        [HttpPost("differents")]
        [ProducesResponseType(typeof(IEnumerable<DifferentValues>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<DifferentValues>>> GetDifferents([FromBody] ReportDTO modifiedReport, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            var result = await _requestService.GetDifferentsAsync(modifiedReport, cancellationToken);
            return Ok(result);
        }

        [HttpGet("sources-of-modification")]
        [ProducesResponseType(typeof(IEnumerable<LookupDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<LookupDto>>> GetSourceOfModification(CancellationToken cancellationToken)
        {
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            var result = await _requestService.GetSourceOfModificationAsync(cancellationToken);
            return Ok(result);
        }

        [HttpGet("request-types")]
        [ProducesResponseType(typeof(IEnumerable<LookupDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<LookupDto>>> GetRequestTypeList(CancellationToken cancellationToken)
        {
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            var result = await _requestService.GetRequestTypeListAsync(cancellationToken);
            return Ok(result);
        }

        [HttpPost("search")]
        [ProducesResponseType(typeof(IEnumerable<RequestListDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<ActionResult<IEnumerable<RequestListDTO>>> GetRequestList(
            [FromBody] ReportRequestSearchCriteriaDTO searchCriteria,
            [FromQuery] bool isExternal = false,
            [FromQuery] bool myTask = false,
            CancellationToken cancellationToken = default)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();
            Guid[] roleIds = currentUser.Roles?.ToArray() ?? Array.Empty<Guid>();
            var presonId = currentUser.PersonId;

            var result = await _requestService.GetRequestListAsync(
                searchCriteria,
                permittedAreas ,
                roleIds,
                presonId,
                isExternal,
                myTask,
                cancellationToken);

            return Ok(result);
        }

        //[HttpPost("closed/search")]
        //[ProducesResponseType(typeof(IEnumerable<RequestListDTO>), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //public async Task<ActionResult<IEnumerable<RequestListDTO>>> GetClosedRequestsList(
        //    [FromBody] ReportRequestSearchCriteriaDTO searchCriteria,
        //    [FromQuery] bool isExternal = false,
        //    CancellationToken cancellationToken = default)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var currentUser = await _currentUserService.GetCurrentUserAsync();
        //    if (currentUser == null) return Unauthorized();

        //    long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();
        //    Guid[] roleIds = currentUser.Roles?.ToArray() ?? Array.Empty<Guid>();

        //    var result = await _requestService.GetClosedRequestsListAsync(
        //        searchCriteria,
        //        permittedAreas,
        //        roleIds,
        //        isExternal,
        //        cancellationToken);

        //    return Ok(result);
        //}

        //[HttpPost("transferred/search")]
        //[ProducesResponseType(typeof(IEnumerable<RequestListDTO>), StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status401Unauthorized)]
        //public async Task<ActionResult<IEnumerable<RequestListDTO>>> GetTransferredRequestsList(
        //    [FromBody] RequestSearchCriteriaDTO searchCriteria,
        //    CancellationToken cancellationToken = default)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var currentUser = await _currentUserService.GetCurrentUserAsync();
        //    if (currentUser == null) return Unauthorized();

        //    long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();
        //    Guid[] roleIds = currentUser.Roles?.ToArray() ?? Array.Empty<Guid>();
        //    long userId = currentUser.PersonId;

        //    var result = await _requestService.GetTransferredRequestsListAsync(
        //        searchCriteria,
        //        permittedAreas,
        //        roleIds,
        //        userId,
        //        cancellationToken);

        //    return Ok(result);
        //}
    }
} 