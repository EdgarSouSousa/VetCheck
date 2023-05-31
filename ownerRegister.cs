using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetCheck
{
    public partial class ownerRegister : Form
    {
        //iniciate SQL connection
        private SqlConnection CN = new SqlConnection();

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\\SQLSERVER,8101" + " ;" + "Initial Catalog = " + "p2g1" + "; uid = " + "p2g1" + ";" + "password = " + "2TorresDeCT2001");
        }

        private bool verifySGBDConnection()
        {
            if (CN == null)
                CN = getSGBDConnection();

            if (CN.State != ConnectionState.Open)
                CN.Open();

            return CN.State == ConnectionState.Open;
        }
        public ownerRegister()
        {
            InitializeComponent();
        }

        private void ownerRegister_Load(object sender, EventArgs e)
        {

        }

        private void submitOwnerButton_Click(object sender, EventArgs e)
        {
            try
            {
                CN = getSGBDConnection();
                if (!verifySGBDConnection())
                {
                    MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE", "Connection Test", MessageBoxButtons.OK);
                    return;
                }

                // Retrieve the maximum OwnerID from the Owner table and increment it by 1.
                int ownerID;
                using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(owner_id), 0) + 1 FROM Owner", CN))
                {
                    object result = cmd.ExecuteScalar();
                    ownerID = (result != null) ? Convert.ToInt32(result) : 1;
                }

                // Get the values from the textboxes
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string address = txtAddress.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string email = txtEmail.Text;

                // Insert the new entry into the Owner table
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Owner (owner_id, first_name, last_name, address, phone_number, email) VALUES (@owner_id, @first_name, @last_name, @address, @phone_number, @email)", CN))
                {
                    cmd.Parameters.AddWithValue("@owner_id", ownerID);
                    cmd.Parameters.AddWithValue("@first_name", firstName);
                    cmd.Parameters.AddWithValue("@last_name", lastName);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@phone_number", phoneNumber);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.ExecuteNonQuery();
                }

                // Close the database connection
                CN.Close();
                //close this form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
