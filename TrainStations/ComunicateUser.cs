namespace train
{
    public class ComunicateUser
    {
        public static string GetUserDetails(String userInfoToGet)
        {
            Messages.GetUserDetail(userInfoToGet);
            return Console.ReadLine();
        }
        public static string GetUserName()
        {
            Messages.GetUserName();
            return Console.ReadLine();
        }
        public static string InValidEnumValue<TEnum>() where TEnum : Enum
        {
            Messages.InvalidEnumValue<TEnum>();
            return Console.ReadLine();
        }
        public static string UserStartOption()
        {
            while(true)
            {
            Messages.AppStartOptions();
            string userOption = Console.ReadLine();
            switch (userOption)
                {
                    case "A":
                        return "Login";
                    case "B":
                        return "CreateNewUser";
                    default:
                        Messages.InvalidChoice();
                        break;
                }
            }
        }
    }
}
