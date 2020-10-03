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

namespace Assignment_2
{
    public partial class SignUp : Form
    {
        public static string GetUserAccount
        {
            get; set;
        }
        public static string GetUserType
        {
            get; set;
        }

        public SignUp()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            NewUserScreen newUserForm = new NewUserScreen();
            newUserForm.Show();
            this.Hide();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string password = pWord.Text;

            // Method to check credetianls is called here! 
            var isValid = ValidateUserAccountInfo();
            if (isValid)
            {
                MessageBox.Show("Valid Credentials...!", "Login Notification");
                string username = uName.Text;
                TextEditor textEditor = new TextEditor();
                textEditor.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invaild Credentials! Please try again!", "Account Information");
                SignUp signupAgain = new SignUp();
                this.Hide();
                signupAgain.Show();
            }

        }

        private bool ValidateUserAccountInfo()
        {
            FileStream DemoFile = new FileStream("login.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            GetUserAccount = uName.Text;//get username from the user input

            string[] accountArra = File.ReadAllLines("login.txt");
            for (int loop = 0; loop < accountArra.Length; loop++)
            {
                string[] userAccount = accountArra[loop].Split(',');
                if (uName.Text == userAccount[0] && pWord.Text == userAccount[1])
                {
                    string accesstype = userAccount[2];
                    GetUserType = accesstype;
                    DemoFile.Close();
                    return true;
                }
            }
            DemoFile.Close();
            return false;
        }

    }

}

