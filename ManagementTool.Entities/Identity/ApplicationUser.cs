using Microsoft.AspNetCore.Identity;

namespace ManagementTool.Entities.Identity;

public  class ApplicationUser : IdentityUser
{
    public string Name { get; set; }
    public string Avatar { get; set; }
}
