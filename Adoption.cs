﻿using System;
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
    public partial class Adoption : Form
    {
        public Adoption()
        {
            InitializeComponent();
        }

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

        private void submitAdoptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                CN = getSGBDConnection();
                if (!verifySGBDConnection())
                {
                    MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE", "Connection Test", MessageBoxButtons.OK);
                    return;
                }

                // Retrieve the maximum AdoptionID from the Visit table and increment it by 1.
                int adoptionID;
                using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(adoption_id), 0) + 1 FROM Adoption", CN))
                {
                    object result = cmd.ExecuteScalar();
                    adoptionID = (result != null) ? Convert.ToInt32(result) : 1;
                }

                // First, insert a new visit record for the adoption
                int animalID = int.Parse(txtAnimalID.Text);
                int ownerID = int.Parse(txtOwnerID.Text);
                int vetID = int.Parse(txtVetID.Text);
                DateTime adoptionDate = dtpAdoptionDate.Value;
                double adoptionFee = double.Parse(txtAdoptionFee.Text);
                bool isReturn = isReturnCheck.Checked;

                // Insert the adoption into the database using the stored procedure
                using (SqlCommand command = new SqlCommand("InsertAdoption", CN))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@adoption_id", adoptionID);
                    command.Parameters.AddWithValue("@animal_id", animalID);
                    command.Parameters.AddWithValue("@adoption_date", adoptionDate);
                    command.Parameters.AddWithValue("@adoption_fee", adoptionFee);
                    command.Parameters.AddWithValue("@owner_id", ownerID);
                    command.Parameters.AddWithValue("@isReturn", isReturn);

                    command.ExecuteNonQuery();
                }

                // Close the database connection
                CN.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void newOwner_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form ownerRegister= new ownerRegister();
            ownerRegister.Show();
        }

        private void Adoption_Load(object sender, EventArgs e)
        {

        }
    }
}
