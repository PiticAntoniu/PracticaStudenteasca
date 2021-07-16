using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaStudenteasca.Services
{
    class LoginServices
    {
        internal static bool Login(string mail, string password)
        {
            //int userId = Services.UserServices.GetUserIdByMail(mail);
            //return password == Services.UserServices.GetPasswordByUserId(userId);

            return password == Services.UserServices.GetPasswordByMail(mail);
        }

    }
}
