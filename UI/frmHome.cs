using WindowsFormsApp4.DAL;
using WindowsFormsApp4.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankManagementSystem.DAL;

namespace WindowsFormsApp4.UI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        donorDAL dal = new donorDAL();
        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers users = new frmUsers();
            users.Show();
        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonors donors = new frmDonors();
            donors.Show();
        }
        private void frmHome_Load(object sender, EventArgs e)
        {
            //Load all the Blood Donors Count When Form is Loaded
            //Call allDonorCountMethod
            allDonorCount();

            //Display all the Donors
            DataTable dt = dal.Select();
            //dgvDonors.DataSource = dt;

            //Display the username of Logged In user
            //lblUser.Text = frmLogin.loggedInUser;
        }

        public void allDonorCount()
        {
            //Get the Donor Count from DAtabase and SEt in respective label
            lblOpositiveCount.Text = dal.countDonors("O+");
            lblOnegativeCount.Text = dal.countDonors("O-");
            lblApositiveCount.Text = dal.countDonors("A+");
            lblAnegativeCount.Text = dal.countDonors("A-");
            lblBpositiveCount.Text = dal.countDonors("B+");
            lblBnegativeCount.Text = dal.countDonors("B-");
            lblABpositiveCount.Text = dal.countDonors("AB+");
            lblABnegativeCount.Text = dal.countDonors("AB-");
        }

        private void frmHome_Activated(object sender, EventArgs e)
        {
            //Call allDonorCount Method
            allDonorCount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatient patient = new frmPatient();
            patient.Show();
        }
    }
}
