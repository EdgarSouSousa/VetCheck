using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetCheck
{
    public partial class MainVet : Form
    {
        public MainVet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adoption adoptionForm = new Adoption();
            adoptionForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Return returnForm = new Return();
            returnForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Info infoForm = new Info();
            infoForm.Show();
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            Appointment appointmentForm = new Appointment();
            appointmentForm.Show();
        }
    }
}
