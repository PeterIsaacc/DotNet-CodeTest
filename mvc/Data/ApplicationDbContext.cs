namespace mvc.Data;
using Microsoft.EntityFrameworkCore;
using mvc.Models.Entities;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
    }
    public DbSet<Student> Students { get; set; }
}