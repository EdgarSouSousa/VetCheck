using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace VetCheck
{
    public partial class Login : Form
    {
        //iniciate SQL connection
        private SqlConnection CN = new SqlConnection();

        private SqlConnection getSGBDConnection()
        {
            return new SqlConnection("Data Source = " + "tcp:mednat.ieeta.pt\\SQLSERVER,8101" + " ;" + "Initial Catalog = "+ "p2g1"  + "; uid = " + "p2g1" + ";" + "password = " + "2TorresDeCT2001");
        }

        private bool verifySGBDConnection()
        {
            if (CN == null)
                CN = getSGBDConnection();

            if (CN.State != ConnectionState.Open)
                CN.Open();

            return CN.State == ConnectionState.Open;
        }

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clicking this button will check the database for the user's credentials
            //if the credentials are correct, the user will be logged in
            //if the credentials are incorrect, the user will be prompted to try again

            try
            {
                
                CN = getSGBDConnection();
                if (!verifySGBDConnection())
                {
                    MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE", "Connection Test", MessageBoxButtons.OK);
                    return;
                }
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Veterinarian WHERE email = @Username AND password = @Password", CN))
                {
                    cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        MessageBox.Show("Login successful!");
                        // You can close the login form and open the main application form here.
                        //open the main application form
                        MainVet mainForm = new MainVet();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CN.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}