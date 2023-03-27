using AutismAssistMobile.Data;

namespace AutismAssistMobile.Shared;
public interface IFriendService
{
    Task<List<Friend>> GetFriendsAsync();
    Task<Friend> GetFriend(int id);
    Task AddFriendAsync(Friend friend);
    Task SaveImages(Friend friend);

}

