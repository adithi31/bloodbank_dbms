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

namespace WindowsFormsApp4.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();
        private void lblFormTItle_Click(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello!");
            //Step 1: Get the Values from UI
            //u.fullname = txtFullName.Text;
            //u.emailid = txtEmail.Text;
            //u.username = txtUsername.Text;
            //u.password = txtPassword.Text;
            //u.contact = txtContact.Text;

            //Step2: Adding the Values from UI to the Database
            //Create a Boolean Variable to check whether the data is inserted successfully or not
            //bool success = dal.Insert(u);
            //if (success == true)
            //{
            //Data or User Added Successfully
            //  MessageBox.Show("New User added Successfully.");

            //Display the user in DataGrid View
            //  DataTable dt = dal.Select();
            //dgvUsers.DataSource = dt;

            //Clear TextBoxes
            //Clear();
        }//
            //else
            //{
                //Failed to Add User
               // MessageBox.Show("Failed to Add New User.");
            //}
   // }
        public void Clear()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtContact.Text = "";
            txtPassword.Text = "";
            txtUserId.Text = "";
            //Path to Destination Folder
            //Get the Image path
        }
        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Find the Row Index of the Row Clicked on Users Data Frid View
            int RowIndex = e.RowIndex;
            //Int32.Parse(txtUserId.Text) = dgvUsers.Rows[RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[RowIndex].Cells[3].Value.ToString();
            txtFullName.Text = dgvUsers.Rows[RowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[RowIndex].Cells[5].Value.ToString();
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            //Display the Users in DAtagrid View When the Form is Loaded
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello!");
            //Step 1: Get the Values from UI
            
            u.fullname = txtFullName.Text;
            u.emailid = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;

            //Step2: Adding the Values from UI to the Database
            //Create a Boolean Variable to check whether the data is inserted successfully or not
            bool success = dal.Insert(u);
            if (success == true)
            {
            //Data or User Added Successfully
              MessageBox.Show("New User added Successfully.");

            //Display the user in DataGrid View
              DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

            //Clear TextBoxes
            Clear();
        }//
         else
         {
         //Failed to Add User
          MessageBox.Show("Failed to Add New User.");
         }
    }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            //Step1: Get the Values from UI
            u.userid = Int32.Parse(txtUserId.Text);
            u.fullname = txtFullName.Text;
            u.emailid = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;


            //Step 2: Create a Boolean variable to check whether the data is updated successfully or not
            bool success = dal.Update(u);

            //Remove the previous Image



            //Let's check whether the data is updated or not
            if (success == true)
            {
                //Data Udated Successfully
                MessageBox.Show("User Updated Successfully.");

                //Refresh DAta Grid View
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                //Clear the TextBoxes
                Clear();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //Step 1: Get the UserID from Text Box to Delete the User
            u.userid = Int32.Parse(txtUserId.Text);

            //REmove the Physical file of the User Profile


            //Step Create the Boolean value to check whether the user deleted or not
            bool success = dal.Delete(u);

            //Let's check whteher the user is Deleted or Not
            if (success == true)
            {
                //User Deleted Successfully
                MessageBox.Show("User Deleted Successfully.");

                //Refresh DataGrid View
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                //Clear the TextBoxes
                Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //Call the user Function
            Clear();
        }
    }
    
}

