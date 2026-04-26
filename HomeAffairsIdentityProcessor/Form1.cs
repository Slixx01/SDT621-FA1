using SectionB_Q2_HomeAffairsIdentityProcessor;

namespace HomeAffairsIdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbCitizen.Items.Add("Citizen");
            cmbCitizen.Items.Add("Permanent Residant");
            cmbCitizen.Items.Add("Visitor");
            cmbCitizen.Items.Add("South African");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string Id = txtId.Text;
            CitizenProfile profile = new CitizenProfile(name, Id);

            lblValidConfirmation.Text = profile.ValidateID();


        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string Id = txtId.Text;
            CitizenProfile profile = new CitizenProfile(name, Id);

            txtProfile.Text =
            "==== DIGITAL CITIZEN SUMMARY ====\r\n" +
            "Name: " + profile.Name + "\r\n" +
            "ID Number: " + profile.IdNumber + "\r\n" +
            "Age: " + profile.Age + "\r\n" +
            "Citizenship: " + cmbCitizen.Text + "\r\n" +
            "Validation: " + profile.ValidateID() + "\r\n" +
            "Processed at: Home Affairs Digital Desk\r\n" +
            "Timestamp: " + DateTime.Now;

        }


    }
}
