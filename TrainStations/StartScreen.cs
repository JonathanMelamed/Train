namespace train
{

    public class StartScreen : UserApp
    {
        public static void StartOptionsScreen()
        {
            string userStartOption = ComunicateUser.UserStartOption();
            Generics.CallMethodByName(userStartOption);
        }

    }
}
