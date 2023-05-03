using WindowsFormsApp4.BLL;
using WindowsFormsApp4.DAL;
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
using WindowsFormsApp4.BLL;
using WindowsFormsApp4.DAL;
using BloodBankManagementSystem.DAL;

namespace WindowsFormsApp4.UI
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }
        //Create object of Donor BLL and Donor DAL
        //donorBLL d = new donorBLL();
        //donorDAL dal = new donorDAL();
        userDAL udal = new userDAL();
        patientBLL p = new patientBLL();
        patientDAL pdal = new patientDAL();



        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        //Create a Method to Clear all the Textboxes
        public void Clear()
        {
            //Clear all the TExtboxes
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPatientID.Text = "";
            cmbGender.Text = "";
            cmbBloodGroup.Text = "";
            txtContact.Text = "";
            txtAge.Text = "";
            txtPatientHistory.Text = "";

            //Clear the PictureBox
            //First we need to get the image Path
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

            string imagepath = path + "\\images\\no-image.jpg";

            //Display Image in PictureBox
        }

        private void dgvDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //SElect the DAta from DAtagrid View and Display in our Form

            //1. Find the Row Selected
            int RowIndex = e.RowIndex;

            txtPatientID.Text = dgvPatient.Rows[RowIndex].Cells[0].Value.ToString();
            txtFullName.Text = dgvPatient.Rows[RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvPatient.Rows[RowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvPatient.Rows[RowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvPatient.Rows[RowIndex].Cells[5].Value.ToString();
            txtAge.Text = dgvPatient.Rows[RowIndex].Cells[6].Value.ToString();
            cmbBloodGroup.Text = dgvPatient.Rows[RowIndex].Cells[7].Value.ToString();
            txtPatientHistory.Text = dgvPatient.Rows[RowIndex].Cells[2].Value.ToString();
        }
        private void frmPatient_Load(object sender, EventArgs e)
        {


        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //We will write the code to Add new Donor
            //Step 1. Get the Data from Manage Donors Form
            p.name = txtFullName.Text;
            p.email = txtEmail.Text;
            p.gender = cmbGender.Text;
            p.blood_group = cmbBloodGroup.Text;
            p.contact = txtContact.Text;
            p.age = txtAge.Text;
            p.patient_history = txtPatientHistory.Text;
            //d.donor_id = Int.Parse(txtDonorID.Text);

            //Get The ID of Logged In USer
            //string loggedInUser = frmLogin.loggedInUser;
            //userBLL usr = udal.GetIDFromUsername(loggedInUser);

            //d.added_by = usr.user_id;


            //Upload image
            //Check whether the user has selected the image or not


            //Step2: Inserting Data into Database
            //Create a Boolean Variable to Isnert DAta into DAtabase and check whether the data inserted successfully of not
            bool isSuccess = pdal.Insert(p);

            //if the Data is inserted successfully then the values of isSuccess will be True else it will be false
            if (isSuccess == true)
            {
                //Data Inserted Successfully
                MessageBox.Show("New Patient Added Successfully");

                //Refresh Datagrid View
                DataTable dt = pdal.Select();
                dgvPatient.DataSource = dt;

                //Clear all the Textboxes
                Clear();
            }
            else
            {
                //FAiled to Insert Data
                MessageBox.Show("Failed to Add new Donor.");
            }

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void frmDonors_Load_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click_2(object sender, EventArgs e)
        {
            //We will write the code to Add new Donor
            //Step 1. Get the Data from Manage Donors Form
            p.name = txtFullName.Text;
            p.email = txtEmail.Text;
            p.gender = cmbGender.Text;
            p.blood_group = cmbBloodGroup.Text;
            p.contact = txtContact.Text;
            p.age = txtAge.Text;
            p.patient_history = txtPatientHistory.Text;
            //d.donor_id = Int.Parse(txtDonorID.Text);

            //Get The ID of Logged In USer
            //string loggedInUser = frmLogin.loggedInUser;
            //userBLL usr = udal.GetIDFromUsername(loggedInUser);

            //d.added_by = usr.user_id;


            //Upload image
            //Check whether the user has selected the image or not


            //Step2: Inserting Data into Database
            //Create a Boolean Variable to Isnert DAta into DAtabase and check whether the data inserted successfully of not
            bool isSuccess = pdal.Insert(p);

            //if the Data is inserted successfully then the values of isSuccess will be True else it will be false
            if (isSuccess == true)
            {
                //Data Inserted Successfully
                MessageBox.Show("New Patient Added Successfully");

                //Refresh Datagrid View
                DataTable dt = pdal.Select();
                dgvPatient.DataSource = dt;

                //Clear all the Textboxes
                Clear();
            }
            else
            {
                //FAiled to Insert Data
                MessageBox.Show("Failed to Add new Donor.");
            }


        }

        private void btnUpdate_Click_2(object sender, EventArgs e)
        {
            //Add the Functionality to Update the Donors
            //1. Get the Values from Form
            p.patient_id = int.Parse(txtPatientID.Text);
            p.name = txtFullName.Text;
            p.email = txtEmail.Text;
            p.gender = cmbGender.Text;
            p.blood_group = cmbBloodGroup.Text;
            p.contact = txtContact.Text;
            p.age = txtAge.Text;
            p.patient_history = txtPatientHistory.Text;
            //Get The ID of Logged In USer
            //string loggedInUser = frmLogin.loggedInUser;
            //userBLL usr = udal.GetIDFromUsername(loggedInUser);

            //d.added_by = usr.user_id;
            //d.image_name = imageName;

            // Upload new image
            //Check whether the user has selected the image or not


            //Create a Boolean Variable to Check whether the data updated successfully or not
            bool isSuccess = pdal.Update(p);

            //REmove the previous image
            //Check whether the donor has profile picture or not


            //If the data updated successfully then the value of isSuccess will be true else it will be false
            if (isSuccess == true)
            {
                //Donor Updated Successfully
                MessageBox.Show("Patient updated Successfully.");
                Clear();

                //Refresh Datagridview
                DataTable dt = pdal.Select();
                dgvPatient.DataSource = dt;

            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to update patient.");
            }
        }

        private void btnDelete_Click_2(object sender, EventArgs e)
        {

            //Get the value from form
            p.patient_id = int.Parse(txtPatientID.Text);

            //Check whether the donor has profile picture or not


            //Create a Boolean Variable to Check whether the donor deleted or not
            bool isSuccess = pdal.Delete(p);

            if (isSuccess == true)
            {
                //Donor Deleted Successfully
                MessageBox.Show("Donor Deleted Successfully.");

                Clear();

                //Refresh Datagrid View
                DataTable dt = pdal.Select();
                dgvPatient.DataSource = dt;
            }
            else
            {
                //Failed to Delete Donor
                MessageBox.Show("Failed to Delete Donor");
            }
        }

        private void btnClear_Click_2(object sender, EventArgs e)
        {
            //Clear the TExtboxes
            Clear();
        }

        private void frmPatient_Load_1(object sender, EventArgs e)
        {
            //Display Donors in DataGrid View
            DataTable dt = pdal.Select();
            dgvPatient.DataSource = dt;
        }

        private void txtSearch_TextChanged_2(object sender, EventArgs e)
        {
            //Let's Add the Functionality to Search the Donors

            //1. Get the Keywords Typed on the Search TExt Box
            string keywords = txtSearch.Text;

            // Check Whether the Search TExtBox is Empty or Not
            if (keywords != null)
            {
                //Display the information of Donors Based on Keywords
                DataTable dt = pdal.Search(keywords);
                dgvPatient.DataSource = dt;
            }
            else
            {
                //DIsplay all the Donors
                DataTable dt = pdal.Select();
                dgvPatient.DataSource = dt;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
