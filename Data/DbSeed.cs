using bandaid.Models;

namespace bandaid.Data;

public static class DbSeed
{
    public static void Initialize(DataContext context)
    {
        context.Database.EnsureCreated();
        if (context.Users.Any() || context.Ads.Any())
        {
            return;
        }

        var ads = new Ad[]
        {
            new Ad
            { 
                title = "Basist söker", 
                genre = "Punk", 
                category = "BANDMEMBER", 
                description = "Hej vi söker dig som spelar bas till vårt punkbank hehe", 
                instrument = "BASS", 
                location = "Gothenburg",
            }
        };
        foreach (var a in ads)
        {
            context.Ads.Add(a);
        }
        context.SaveChanges();
        var users = new User[]
        {
            new User
            {
                username = "Browbeans",
                password = "nanana123",
                location = "Gothenburg",
                email = "browbeans123@gmail.com",
                phoneNumber = "+461952197",
            }
        };
        foreach (var u in users)
        {
            context.Users.Add(u);
        }

        context.SaveChanges();
    }
}