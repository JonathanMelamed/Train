using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;

namespace train
{
    public class UsersDB
    {
        private static readonly string UsersDBJSon = "/Users/melamed/Documents/Code/TrainStations/usersdb.cs";
        public static void CreateNewUserToDB(User Newuser)
        {
            List<User> users = ReadUsersFromFile();
            users.Add(Newuser);
            string jsonString = JsonSerializer.Serialize(Newuser, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(UsersDBJSon, jsonString);
        }
        public static User GetUserByName(string name)
        {
            List<User> people = ReadUsersFromFile();

            User user = people.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            return user;
        }
                public static List<User> ReadUsersFromFile()
        {
            string jsonString = File.ReadAllText(UsersDBJSon);
            List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString);
            return users;
        }
    }
}


