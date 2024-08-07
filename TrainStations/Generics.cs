using System.Reflection;
namespace train
{
    public partial class UserApp
    {
        public static class Generics
        {
            public static void CallMethodByName(string methodName)
            {
                MethodInfo method = typeof(UserApp).GetMethod(methodName, BindingFlags.Public | BindingFlags.Static);
                if (method != null)
                {
                    method.Invoke(null, null);
                }
            }
            public static bool HandleEnum<TEnum>(string enumValue) where TEnum : Enum
            {
                return Enum.IsDefined(typeof(TEnum), enumValue);
            }
        }

    }
}
