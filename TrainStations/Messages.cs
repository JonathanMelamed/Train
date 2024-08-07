namespace train
{
    public class Messages
    {
        public static void GetUserDetail(String userInfoToGet)
        {
            var property = typeof(User).GetProperty(userInfoToGet);
            Console.WriteLine($"pls enter your {userInfoToGet}");
        }

        public static void AppStartOptions()
        {
            Console.WriteLine("Hello User, \nplease choose one of the following options");
            Console.WriteLine("A - Login with existing user");
            Console.WriteLine("B - Create new User");
        }
        public static void GetUserName()
        {
            Console.WriteLine("Welcome Back! \npleas enter your name");
        }
        public static void InvalidChoice()
        {
            Console.WriteLine("Invalid choice. Please choose a Letter between the options");
        }
        public static void InvalidEnumValue<TEnum>() where TEnum : Enum
        {
            Console.WriteLine("Invalid option, please enter one of the following options:");
            foreach (var value in Enum.GetValues(typeof(TEnum)))
            {
                Console.WriteLine(value);
            }
        }
    }
}
