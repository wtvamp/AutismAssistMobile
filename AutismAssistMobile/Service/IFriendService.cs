using AutismAssistMobile.Data;

namespace AutismAssistMobile.Shared;
public interface IFriendService
{
    Task<List<Friend>> GetFriendsAsync();
}
