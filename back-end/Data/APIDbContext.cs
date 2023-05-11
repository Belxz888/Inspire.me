using System;
using Microsoft.EntityFrameworkCore; 

namespace Main
{
    public class ApiDbContext : DbContext 
    { 
        public ApiDbContext(DbContextOptions<ApiDbContext> options):base(options) 
        { 

        } 
    }
}