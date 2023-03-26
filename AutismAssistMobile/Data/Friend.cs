namespace AutismAssistMobile.Data;

public class Friend
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public List<FriendImage> Images { get; set; } = new List<FriendImage>();

}

public class FriendImage
{
    public int Id { get; set; }
    public string ImageUrl { get; set; }
}