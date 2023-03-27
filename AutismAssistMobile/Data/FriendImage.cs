namespace AutismAssistMobile.Data;

public class FriendImage
{
    public int Id { get; set; }
    public string ImageUrl { get; set; }
    public string ImageExtension { get; set; }
    public int FriendId { get; set; }
    public Friend Friend { get; set; }
}