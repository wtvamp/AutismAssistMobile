namespace AutismAssistMobile.Data;

public static class SeedData
{
    public static void Initialize(FriendContext db)
    {
        var friends = new Friend[]
        {
            new Friend()
            {
                Id = 1,
                FirstName = "Bruce",
                LastName = "Wayne"
            },
            new Friend() {
                Id = 2,
                FirstName = "Clark",
                LastName = "Kent"
            },
            new Friend() {
                Id = 3,
                FirstName = "Arthur",
                LastName = "Curry"            
            }
        };
        db.Friends.AddRange(friends);
        db.SaveChanges();
    }
}