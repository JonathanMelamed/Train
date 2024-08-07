using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
namespace train
{
    public partial class UserApp
    {
        public static void CreateNewUser()
        {
            User newUser = User.CreateNewUser();
            UsersDB.CreateNewUserToDB(newUser);
        }
        public static void Login()
        {
            string userName = ComunicateUser.GetUserName();
            User loginUser = UsersDB.GetUserByName(userName);
        }

        public static void SetUserDetails(User newUser)
        {
            foreach (var property in typeof(User).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var fieldValue = ComunicateUser.GetUserDetails(property.Name);

                if (property.PropertyType == typeof(int) && int.TryParse(fieldValue, out int intValue))
                {
                    property.SetValue(newUser, intValue);
                }
                else if (property.PropertyType.IsEnum)
                {
                    while(!Generics.HandleEnum<Genderes>(fieldValue))
                    {
                        fieldValue = ComunicateUser.InValidEnumValue<Genderes>();
                    }
                    Genderes chosenGender = (Genderes)Enum.Parse(typeof(Genderes), fieldValue);
                    property.SetValue(newUser,chosenGender);
                }
                else
                {
                    property.SetValue(newUser, fieldValue);
                }
            }
        }



    }
}
