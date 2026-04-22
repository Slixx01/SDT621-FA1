using System;
using System.Windows.Forms;

namespace SectionA_Q3_ProgrammingLanguages
{
    public partial class ProgrammingLanguages : Form
    {
        public ProgrammingLanguages()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            txtLanguageInput.Clear();
            lblDisplay.Text = ""; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userText = txtLanguageInput.Text;
            if (lstDisplay.Items.Contains(userText))
            {
                MessageBox.Show("Value enter is a duplication");
            }
            else if (userText == null || txtLanguageInput.Text.Length == 0)
            {
                MessageBox.Show("Please enter a value");
            }
            else
            {
                txtLanguageInput.Clear();
                lstDisplay.Items.Add(userText);
                lblDisplay.Text = "";
                lblDisplay.Text = $"Added {userText} at {DateTime.Now}";
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string RemovedLanguage = txtLanguageInput.Text;

            if (RemovedLanguage == null || txtLanguageInput.Text.Length == 0)
            {
                MessageBox.Show("Please enter a language to remove");
            }
            else
            {
                lstDisplay.Items.Remove(RemovedLanguage);
                lblDisplay.Text = "";
                lblDisplay.Text = $"Removed {RemovedLanguage} at {DateTime.Now}";
            }


        }
    }
}
