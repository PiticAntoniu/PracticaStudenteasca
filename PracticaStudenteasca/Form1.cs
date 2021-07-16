using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaStudenteasca
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            // Services.UserServices.GenerateMockUsers();
            if (Services.LoginServices.Login(mailTextBox.Text, passwordTextBox.Text) == true)
            {
                Ct.loggedUser = Services.UserServices.GetUserByMail(mailTextBox.Text);
                if (Ct.loggedUser.UserType == UserTypes.Admin)
                {
                    Form f = new Form();
                    f.Show();
                }

            }
            else
            {
                MessageBox.Show("Invalid mail or password");
            }
        }
    }
}
