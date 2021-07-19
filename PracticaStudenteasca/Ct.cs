using PracticaStudenteasca.Entities;

namespace PracticaStudenteasca
{
    internal class Ct
    {
        internal static int userId;

        public static string UserListLocation = @"userList.json";
        public static string DefaultCSVExportFile = @"userList.csv";

        internal static User loggedUser;
    }
}