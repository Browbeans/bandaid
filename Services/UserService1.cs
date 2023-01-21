using bandaid.interfaces;

namespace bandaid.Services;
public class UserService1
{
    public class UserService : IUserService1
    {
        public string GetUserAsync()
        {
            return "Petter@gmail.com";
        }
    };
}