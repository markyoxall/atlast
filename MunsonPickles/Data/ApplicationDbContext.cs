using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MunsonPickles.Data;


public class PickleDbContext(DbContextOptions<PickleDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
}
