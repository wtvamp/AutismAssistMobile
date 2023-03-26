using Microsoft.EntityFrameworkCore;

namespace AutismAssistMobile.Data;

public class FriendContext : DbContext
{
    public FriendContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Friend> Friends { get; set; }
}    