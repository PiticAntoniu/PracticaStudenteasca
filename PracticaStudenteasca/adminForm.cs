using PracticaStudenteasca.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaStudenteasca
{
    public partial class adminForm : Form
    {
        List<User> userList;
        public adminForm()
        {
            InitializeComponent();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            userList = Services.UserServices.GetUserList();
            usersDataGridView.DataSource = userList;
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string userListForExport = "";
            foreach (var user in userList)
            {
                userListForExport += (user.Name + "," + user.Mail + Environment.NewLine);
            }
            File.WriteAllText(Ct.DefaultCSVExportFile, userListForExport);
        }
    }
}
