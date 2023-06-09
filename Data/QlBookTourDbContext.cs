using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Webdemo.Data
{
    public class QlBookTourDbContext : IdentityDbContext
    {
        public QlBookTourDbContext(DbContextOptions<QlBookTourDbContext> x)
            : base(x)
        {
        }
    }
}
