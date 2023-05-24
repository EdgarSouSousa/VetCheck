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
    public partial class Appointment : Form
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
        public Appointment()
        {
            InitializeComponent();
        }

        private void Appointment_Load(object sender, EventArgs e)
        { // Populate treatments
            CN = getSGBDConnection();
            string sql = "SELECT treatment_id, name FROM Treatment";
            if (verifySGBDConnection())
            {
                using (SqlCommand command = new SqlCommand(sql, CN))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int treatmentId = reader.GetInt32(0);
                        string treatmentName = reader.GetString(1);
                        lstTreatments.Items.Add(new TreatmentItem(treatmentId, treatmentName));
                    }
                    reader.Close();
                }
            }

            // Populate diagnoses
            sql = "SELECT diagnostic_id, name FROM Diagnostic";
            if (verifySGBDConnection())
            {
                using (SqlCommand command = new SqlCommand(sql, CN))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int diagnosticId = reader.GetInt32(0);
                        string diagnosticName = reader.GetString(1);
                        lstDiagnostics.Items.Add(new DiagnosticItem(diagnosticId, diagnosticName));
                    }
                    reader.Close();
                }
            }
        }

        // Helper classes for ComboBox and ListBox items
        class TreatmentItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public TreatmentItem(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        class DiagnosticItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DiagnosticItem(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CN = getSGBDConnection();
            if (!verifySGBDConnection())
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE", "Connection Test", MessageBoxButtons.OK);
                return;
            }

            int appointmentId;
            using (SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(Appointment_id), 0) + 1 FROM Appointment", CN))
            {
                object result = cmd.ExecuteScalar();
                appointmentId = (result != null) ? Convert.ToInt32(result) : 1;
            }

            int animalId = int.Parse(txtAnimalId.Text);
            int vetId = int.Parse(txtVetId.Text);
            DateTime appointmentDate = dtpAppointmentDate.Value;
            string appointmentReason = txtAppointmentReason.Text;


            // Insert appointment into the database
            string sql = "INSERT INTO Appointment (Appointment_id ,animal_id, vet_id, Appointment_date, Appointment_reason) VALUES (@appointmentId,@animalId, @vetId, @appointmentDate, @appointmentReason); SELECT SCOPE_IDENTITY();";

            if (verifySGBDConnection())
            {
                using (SqlCommand command = new SqlCommand(sql, CN))
                {
                    command.Parameters.AddWithValue("@appointmentId", appointmentId); // Change parameter name to @appointmentId
                    command.Parameters.AddWithValue("@animalId", animalId);
                    command.Parameters.AddWithValue("@vetId", vetId);
                    command.Parameters.AddWithValue("@appointmentDate", appointmentDate);
                    command.Parameters.AddWithValue("@appointmentReason", appointmentReason);
                    command.ExecuteNonQuery();
                }
            }

            // Insert selected treatments into Appointment_Treatment table
            foreach (TreatmentItem item in lstTreatments.SelectedItems)
            {
                int treatmentId = item.Id;
                sql = "INSERT INTO Appointment_Treatment (Appointment_id, treatment_id) VALUES (@appointmentId, @treatmentId)";
                if (verifySGBDConnection())
                {
                    using (SqlCommand command = new SqlCommand(sql, CN))
                    {
                        command.Parameters.AddWithValue("@appointmentId", appointmentId);
                        command.Parameters.AddWithValue("@treatmentId", treatmentId);
                        command.ExecuteNonQuery();
                    }
                }
            }

            // Insert selected diagnoses into Appointment_Diagnostic table
            foreach (DiagnosticItem item in lstDiagnostics.SelectedItems)
            {
                int diagnosticId = item.Id;
                sql = "INSERT INTO Appointment_Diagnostic (Appointment_id, diagnostic_id) VALUES (@appointmentId, @diagnosticId)";
                if (verifySGBDConnection())
                {
                    using (SqlCommand command = new SqlCommand(sql, CN))
                    {
                        command.Parameters.AddWithValue("@appointmentId", appointmentId);
                        command.Parameters.AddWithValue("@diagnosticId", diagnosticId);
                        command.ExecuteNonQuery();
                    }
                }
            }

            this.Close();

        }
    }
}
