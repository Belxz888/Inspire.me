using Microsoft.EntityFrameworkCore; 
 
namespace test {

        public class ApiDbContext : DbContext 
        { 
            public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options) {  } 
        }
}