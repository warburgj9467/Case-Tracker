using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CTClasses;
using System.Data.SqlClient;

namespace Capstone_CaseTracker
{
    public partial class Form1 : Form
    {        
        string userName;     
        string password;        
        bool login;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            userName = usernameTextBox.Text;
            password = passwordTextBox.Text;
            int count = 0;

            CTClasses.SQLCommands com = new SQLCommands();
            login = com.LogInRetrieval(userName, password);

            if (login == true)
            {
                CaseList select = new CaseList();
                select.ShowDialog();
                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }
            else
            {
                MessageBox.Show("The information you provided does not match our records.");
                usernameTextBox.Focus();
                usernameTextBox.Clear();
                passwordTextBox.Clear();
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form temp = new RevampForms.IARRevampForm();
            this.Hide();
            temp.ShowDialog();
            this.Show();
        }
    }
}
