using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JHipsterNet.Core.Pagination;
using JHipsterNet.Core.Pagination.Extensions;
using Blockter.Domain.Entities;
using Blockter.Security;
using Blockter.Domain.Services.Interfaces;
using Blockter.Dto;
using Blockter.Web.Extensions;
using Blockter.Web.Filters;
using Blockter.Web.Rest.Problems;
using Blockter.Web.Rest.Utilities;
using Blockter.Crosscutting.Constants;
using Blockter.Crosscutting.Exceptions;
using Blockter.Infrastructure.Web.Rest.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Blockter.Controllers;


[Route("api/users")]
[ApiController]
public class PublicUsersController : ControllerBase
{
    private readonly ILogger<UsersController> _log;
    private readonly IMapper _mapper;
    private readonly IUserService _userService;

    public PublicUsersController(ILogger<UsersController> log, IUserService userService, IMapper mapper)
    {
        _log = log;
        _userService = userService;
        _mapper = mapper;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAllPublicUsers(IPageable pageable)
    {
        _log.LogDebug("REST request to get a page of Users");
        var page = await _userService.GetAllPublicUsers(pageable);
        var userDtos = page.Content.Select(user => _mapper.Map<UserDto>(user));
        var headers = page.GeneratePaginationHttpHeaders();
        return Ok(userDtos).WithHeaders(headers);
    }

}
