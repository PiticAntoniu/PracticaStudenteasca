using Newtonsoft.Json;
using PracticaStudenteasca.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace PracticaStudenteasca.Services
{
    internal class UserServices
    {
        static List<User> userList = null;

        internal List<User> UserList { get => userList; set => userList = value; }

        public static void GenerateMockUsers()
        {
            userList = new List<User>();
            userList.Add(new User { UserId = 1, Name = "Admin", Mail = "a", Password = "a", UserType = UserTypes.Admin });
            userList.Add(new User { UserId = 2, Name = "Toni", Mail = "xx", Password = "a", UserType = UserTypes.Profesor });
            userList.Add(new User { UserId = 3, Name = "Dorel", Mail = "yy", Password = "a", UserType = UserTypes.Student });
            userList.Add(new User { UserId = 4, Name = "Ana", Mail = "b", Password = "b", UserType = UserTypes.Student });

            string serialisedResults = JsonConvert.SerializeObject(userList);
            File.WriteAllText("userList.json", serialisedResults);

        }

        internal static User GetUserByMail(string mail)
        {
            if (userList == null)
            {
                userList = GetUsers(Ct.UserListLocation);
            }
            if (userList.Find(x => x.Mail == mail) != null)
                return userList.Find(x => x.Mail == mail);
            else
            {
                return null;
            }
        }

        internal static string GetPasswordByMail(string mail)
        {
            if (userList == null)
            {
                userList = GetUsers(Ct.UserListLocation);
            }

            if (userList.Find(x => x.Mail == mail) != null)
                return userList.Find(x => x.Mail == mail).Password;
            else
            {
                return "RCR@#$%^poj5678";
            }
        }

        private static List<User> GetUsers(string userListLocation)
        {
            string serialisedResults = File.ReadAllText(userListLocation);
            return JsonConvert.DeserializeObject<List<User>>(serialisedResults);

        }

        internal static int GetUserIdByMail(string mail)
        {
            return -1;
        }
    }
}