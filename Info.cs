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
    public partial class Info : Form
    {
        public Info()
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

        private void LoadDataIntoDataGridView(string tableName, DataGridView dataGridView)
        {
            CN = getSGBDConnection();
            if (!verifySGBDConnection()) return;

            using (SqlCommand cmd = new SqlCommand($"SELECT * FROM {tableName}", CN))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView.DataSource = dt;
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView("Appointment", dgvAppointments);
            LoadDataIntoDataGridView("Animal", dgvAnimals);
            LoadDataIntoDataGridView("Owner", dgvOwners);
        }

        private void btnUpForAdoption_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) return;

            using (SqlCommand cmd = new SqlCommand("usp_GetAnimalsForAdoption", CN))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAnimals.DataSource = dt;
            }

        }

        private void btnCancelApp_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) return;

            int appointmentId = Convert.ToInt32(txtCancelApp.Text);

            using (SqlCommand cmd = new SqlCommand("usp_DeleteAppointment", CN))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Appointment_id", appointmentId);

                cmd.ExecuteNonQuery();
            }

            Info_Load(sender, e);
        }

        private void btnCheckAppDetails_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection()) return;

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM ufn_GetAppointmentDetails(@Appointment_id)", CN))
            {
                int appointmentId = Convert.ToInt32(txtCheckAppDetails.Text);
                cmd.Parameters.AddWithValue("@Appointment_id", appointmentId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAppointmentDetails.DataSource = dt;
            }
        }

        private void LoadFilteredAppointments()
        {
            if (!verifySGBDConnection()) return;

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Appointment WHERE Appointment_Date > @CurrentDate", CN))
            {
                cmd.Parameters.AddWithValue("@CurrentDate", DateTime.Now);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAppointments.DataSource = dt;
            }
        }

        private void btnFutureOnly_Click(object sender, EventArgs e)
        {
            LoadFilteredAppointments();
        }
    }
}
