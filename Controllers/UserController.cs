using bandaid.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace bandaid.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase
{

    private readonly IUserService1 _userService;
    public UserController(
        IUserService1 userService
    )
    {
        _userService = userService;
    }
    [HttpGet(Name = "GetUser")]
    public string Get()
    {
        var user = _userService.GetUserAsync();
        return user;
    }
}