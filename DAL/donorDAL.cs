using WindowsFormsApp4.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.DAL
{
    class donorDAL
    {
        //Create a Connection String to Connect Database
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region SELECT to display data in DataGridView from database
        public DataTable Select()
        {
            // Create object to DataTAble to hold the data from database and return it
            DataTable dt = new DataTable();

            //Create object of SQL Connection to Connect DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write SQL Query to SElect the DAta from DAtabase
                string sql = "SELECT * FROM tb1_donorsss";

                //Create the SQlCommand to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create SQl DAta Adapter to Hold the Data Temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open Database Connection
                conn.Open();

                //Pass the Data from adapter to DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Display Message if there's any Exceptional Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return dt;
        }
        #endregion
        #region INSERT data to database
        public bool Insert(donorBLL d)
        {
            //Create a Boolean Variable and SEt its default value to false
            bool isSuccess = false;

            //Create SqlConnection to Connect Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write the Query to INSERT data into database
                string sql = "INSERT INTO tb1_donorsss (name, email, contact, gender, donor_history, blood_group, age) VALUES (@name, @email, @contact, @gender, @age, @blood_group, @donor_history)";

                //Create SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the value to SQL Query
                
                cmd.Parameters.AddWithValue("@name", d.name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@donor_history", d.donor_history);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@age", d.age);


                //Open DAtabase Connection
                conn.Open();

                //Create an Integer Variable to Check whether the query was executed Successfully or Not
                int rows = cmd.ExecuteNonQuery();

                //If the Query is Executed Successfully the value of rows willb e greater than Zero else it will be Zero
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Exceptional Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //CLose Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region UPDATE donors in DAtabase
        public bool Update(donorBLL d)
        {
            //Create a Boolean Variable and SEt its Default Value to FAlse
            bool isSuccess = false;
            //Create SQLConnection to Connect DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Create a SQL Query to Update Donors
                string sql = "UPDATE tb1_donorsss SET name=@name, email=@email, contact=@contact, gender=@gender, age=@age, blood_group=@blood_group, donor_history=@donor_history WHERE donor_id=@donor_id";

                //Create SQL Command Here
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the Value to SQL Query
                cmd.Parameters.AddWithValue("@name", d.name);
                cmd.Parameters.AddWithValue("@email", d.email);
                cmd.Parameters.AddWithValue("@contact", d.contact);
                cmd.Parameters.AddWithValue("@gender", d.gender);
                cmd.Parameters.AddWithValue("@age", d.age);
                cmd.Parameters.AddWithValue("@blood_group", d.blood_group);
                cmd.Parameters.AddWithValue("@donor_history", d.donor_history);
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);



                //Open Database Connection
                conn.Open();

                //Create an Integer Variable to check whether the query executed Successfully or not
                int rows = cmd.ExecuteNonQuery();

                //If the Query is Executed Successfully then its value will be greater than 0 else it will be 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any exceptional errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //CLose Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region DELETE donros from Database
        public bool Delete(donorBLL d)
        {
            //Create a Boolean variable and set its default value to false
            bool isSuccess = false;
            //Create SqlConnection To Connect DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Write the Query to Delete Donors from Database
                string sql = "DELETE FROM tb1_donorsss WHERE donor_id=@donor_id";

                //Create SQL Command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Pass the Value to Sql Query using Parameters
                cmd.Parameters.AddWithValue("@donor_id", d.donor_id);

                //Open Database Connection
                conn.Open();

                //Create an Integer VAriable to Check whether the query executed Successfully or Not
                int rows = cmd.ExecuteNonQuery();

                //If the Query executed succesfully then the value of rows will be greater than 0 else it will be 0
                if (rows > 0)
                {
                    //Query Executed Successfully
                    isSuccess = true;
                }
                else
                {
                    //FAiled to Exeute Query
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Exceptional Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //CLose Database Connection
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Count Donors for Specific Blood Group
        public string countDonors(string blood_group)
        {
            //Create SQL Connection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create astring variable for donor count and set its default value to 0
            string donors = "0";

            try
            {
                //SQL Query to Count donors for Specific Blood Group
                string sql = "SELECT * FROM tb1_donorsss WHERE blood_group = '" + blood_group + "'";

                //Sql Command to Execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Sql Data Adapter to Get the data from DAtabase
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Databale to Hold the DAta Temporarily
                DataTable dt = new DataTable();

                //Pass tehe value from SqlDataAdapter to DataTable
                adapter.Fill(dt);

                //Get the Total Number of Donors Based on Blood Group
                donors = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                //Display error message if there's any
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database Connection
                conn.Close();
            }

            return donors;
        }
        #endregion

        #region Method to Search Donors
        public DataTable Search(string keywords)
        {
            //1. SQL Connection to Connect DAtabase
            SqlConnection conn = new SqlConnection(myconnstrng);

            //2. Create DataTable to hold the data Temporarily
            DataTable dt = new DataTable();

            try
            {
                //Write the Code to Search Donors based on Keywords Typed on TextBox
                //Write SQL Query to SEarch Donors
                string sql = "SELECT * FROM tb1_donorsss WHERE donor_id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%' OR email LIKE '%" + keywords + "%' OR blood_group LIKE '" + keywords + "'";

                //Create SQL Command to Execute the Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //SQlDataAdapter to Save Data from Database
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database Connection
                conn.Open();

                //Transfer the Data from SQL Data Adapter to DataTable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Display Error Message if there's any Exceptional Errors
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close the DAtabase Connection
                conn.Close();
            }

            return dt;
        }
        #endregion
    }
}

