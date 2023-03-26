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

    public async Task<Friend> GetFriend(int id)
    {
        var friend = await db.Friends.FindAsync(id);

        if (friend == null)
        {
            throw new KeyNotFoundException("No friend found with id of " + id);
        }

        return friend;
    }

    public async Task<List<Friend>> GetFriendsAsync()
    {
        return await db.Friends.Include(d => d.Images).ToListAsync();
    }

    public async Task SaveImages(Friend friend)
    {
        await db.SaveChangesAsync();

        foreach (var image in friend.Images)
        {
            if (image.Id == 0)
            {
                db.FriendImages.Add(image);
            }
        }

        await db.SaveChangesAsync();
    }
}
