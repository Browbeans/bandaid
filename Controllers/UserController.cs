using bandaid.Models;
using bandaid.Services;
using Microsoft.AspNetCore.Mvc;
namespace bandaid.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase
{

    private readonly UserService _userService;
    public UserController(
        UserService userService
    )
    {
        _userService = userService;
    }

    [HttpGet(Name = "GetUser")]
    public Task<ActionResult<List<Ad>>> Get()
    {
        var user = _userService.GetUserAsync();
        return user;
    }
}