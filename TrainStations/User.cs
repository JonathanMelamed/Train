namespace train
{
    public class User
    {
        public int ID {get;set;}
        public string  Name  {get;set;}
        public int Wallet {get;set;}
        public Genderes genderes { get;set;}
        public static User CreateNewUser()
        {
            User newUser = new User();
            UserApp.SetUserDetails(newUser);
            return  newUser;
        }
    }
}