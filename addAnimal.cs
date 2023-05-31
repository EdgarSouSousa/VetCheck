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
    public partial class addAnimal : Form
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

        public addAnimal()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            // Read the values from the textboxes
            string name = txtName.Text;
            string species = txtSpecies.Text;
            int age = int.Parse(txtAge.Text);
            string gender = txtGender.Text;
            decimal weight = decimal.Parse(txtWeight.Text);

            // Open a connection to the database
            CN = getSGBDConnection();
            if (!verifySGBDConnection())
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE", "Connection Test", MessageBoxButtons.OK);
                return;
            }

            // Retrieve the maximum OwnerID from the Owner table and increment it by 1.
            int animalID;
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(animal_id), 0) + 1 FROM Animal", CN))
            {
                object result = cmd.ExecuteScalar();
                animalID = (result != null) ? Convert.ToInt32(result) : 1;
            }

            // Insert the animal into the database using the stored procedure
            using (SqlCommand command = new SqlCommand("AddAnimal", CN))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@animal_id", animalID); // changed from "@animalId" to "@animal_id"
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@species", species);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@weight", weight);
                command.ExecuteNonQuery();
            }

            // Display a message box to indicate that the animal was added successfully and display its id
            MessageBox.Show("Animal added successfully", "Add Animal", MessageBoxButtons.OK);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addAnimal_Load(object sender, EventArgs e)
        {

        }
    }
}
