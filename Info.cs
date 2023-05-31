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

        private void LoadDataIntoDataGridView(string viewName, DataGridView dataGridView)
        {
            CN = getSGBDConnection();
            if (!verifySGBDConnection()) return;

            using (SqlCommand cmd = new SqlCommand($"SELECT * FROM {viewName}", CN))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView.DataSource = dt;
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {

            dtpCheckAvailableVet.Format = DateTimePickerFormat.Custom;
            dtpCheckAvailableVet.CustomFormat = "dd/MM/yyyy HH";

            LoadDataIntoDataGridView("vw_Appointments", dgvAppointments);
            LoadDataIntoDataGridView("vw_Animals", dgvAnimals);
            LoadDataIntoDataGridView("vw_Owners", dgvOwners);
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

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Details WHERE Appointment_id = @Appointment_id", CN))
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

        private void btnCheckAvailable_Click(object sender, EventArgs e)
        {
            // Create a new SqlCommand object to execute the UDF
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM GetAvailableVeterinariansByTimeAndDate(@appointment_datetime)", CN))
            {
                // Set the command type to Text
                cmd.CommandType = CommandType.Text;

                // Add the parameter for the UDF
                cmd.Parameters.Add(new SqlParameter("@appointment_datetime", SqlDbType.DateTime));
                cmd.Parameters["@appointment_datetime"].Value = dtpCheckAvailableVet.Value;

                // Execute the command and store the results in a DataTable
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }

                // Display the results in a pop-up window
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Available Veterinarians:");
                foreach (DataRow row in dt.Rows)
                {
                    sb.AppendLine($"{row["vet_id"]}: {row["first_name"]} {row["last_name"]}");
                }
                MessageBox.Show(sb.ToString());
            }
        }

    }
}
