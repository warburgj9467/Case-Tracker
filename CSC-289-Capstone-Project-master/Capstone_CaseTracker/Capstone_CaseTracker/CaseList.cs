using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CTClasses;

namespace Capstone_CaseTracker
{
    public partial class CaseList : Form
    {
        public CaseList()
        {
            InitializeComponent();            
            SQLCommands com = new SQLCommands();
            var names = com.RetrieveNameList();
            activeCaseListBox.DataSource = names;
        }

        private void viewCaseButton_Click(object sender, EventArgs e)
        {
            if (activeCaseListBox.SelectedIndex != -1)
            {
                SQLCommands com = new SQLCommands();
                int index = activeCaseListBox.SelectedIndex;
                string fullName = activeCaseListBox.Items[index].ToString();                
                string[] names = fullName.Split(' ');
                string firstName = names[0];
                string lastName = names[1];                
                var indiv = com.RetrieveIndivData(lastName);                
                CaseView view = new CaseView(lastName.ToString());
                view.Show();
            }
            else
            {
                MessageBox.Show("No case was selected.");
            }
           
        }

        private void caseListExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newCaseButton_Click(object sender, EventArgs e)
        {
            PersonForm person = new PersonForm();
            person.ShowDialog();
        }
    }
}
