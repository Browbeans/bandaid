using bandaid.Models;
using Microsoft.AspNetCore.Mvc;

namespace bandaid.interfaces;

public interface IUserService
{
    Task<ActionResult<List<Ad>>> GetUserAsync();
}