using ManagementTool.Entities.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ManagementTool.UI.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;

    public GreetingController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetGreeting()
    {
        var user = await _userManager.GetUserAsync(User);
        return Ok($"Hello .Net Devs! I'm {user.UserName}");
    }
}