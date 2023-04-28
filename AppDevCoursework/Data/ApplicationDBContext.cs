using AppDevCoursework.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AppDevCoursework.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
