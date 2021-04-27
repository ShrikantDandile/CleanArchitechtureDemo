using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Data.Context
{
   public class UniversityDBContext : DbContext
   {
      public UniversityDBContext(DbContextOptions options) : base(options) { }
      public DbSet<Course> Courses { get; set; }
   }
}
