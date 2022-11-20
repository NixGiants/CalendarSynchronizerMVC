using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CalenadrSynchronizerMVC.Data
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
    }
}
