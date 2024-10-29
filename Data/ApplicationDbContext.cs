using Microsoft.EntityFrameworkCore;
using StudentRegistration.Core.Models.Entites;

namespace StudentRegistration.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<StudentReg> StudentReg {  get; set; }
    }
}
