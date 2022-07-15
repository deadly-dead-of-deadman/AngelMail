using Core.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AngelMail.Core.Data;

public class CoreDbContext : DbContext
{
    public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
    {
        
    }
    public DbSet<Message> Messages { get; set; }
    public DbSet<User> Users { get; set; }
}