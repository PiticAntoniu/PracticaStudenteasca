using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaStudenteasca.Entities
{
    class User
    {
        int userId;
        string name;
        string mail;
        string password;
        UserTypes userType;

        public int UserId { get => userId; set => userId = value; }
        public string Name { get => name; set => name = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        internal UserTypes UserType { get => userType; set => userType = value; }
    }
}
