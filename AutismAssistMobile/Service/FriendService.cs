using AutismAssistMobile.Data;
using Microsoft.EntityFrameworkCore;

namespace AutismAssistMobile.Shared;

public class FriendService : IFriendService
{
    private readonly FriendContext db;

    public FriendService(FriendContext db)
    {
        this.db = db;
    }

    public async Task<List<Friend>> GetFriendsAsync()
    {
        return await db.Friends.ToListAsync();
    }
}
