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
    public partial class NewUserScreen : Form
    {
        public NewUserScreen()
        {
            InitializeComponent();
        }

        private void ReEnPassword_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RCancel_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();

        }

        private void SubmissionBtn_Click(object sender, EventArgs e)
        {
            string username = RuName.Text;
            string password = RpWord.Text;
            string checkedPass = RconPassWord.Text;
            string firstName = RfName.Text;
            string lastName = RlastName.Text;
            string dob = BirthDayTime.Text;
            string userType = UserType.Text;

            if (String.IsNullOrEmpty(username) == false && String.IsNullOrEmpty(password) == false
                && String.IsNullOrEmpty(checkedPass) == false && String.IsNullOrEmpty(firstName) == false && String.IsNullOrEmpty(lastName) == false
                && String.IsNullOrEmpty(dob) == false && String.IsNullOrEmpty(userType) == false)
            {
                if (password.Equals(checkedPass))
                {
                    File.AppendAllText("login.txt", username + "," + password + "," + userType + "," + firstName + "," + lastName + "," + dob + Environment.NewLine);
                    User user = new User(username, password, firstName, lastName, dob, userType);
                    
                    SignUp signup = new SignUp();
                    signup.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password confirmation does not match! Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RpWord.Text = String.Empty;
                    RconPassWord.Text = String.Empty;
                }
            }
            else
            {
                MessageBox.Show("You need to complete this registration form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
