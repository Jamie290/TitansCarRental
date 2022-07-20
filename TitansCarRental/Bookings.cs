using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TitansCarRental
{
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            foreach(Customer c in Program.allmycustomers)
            {
                comboBox1.Items.Add(c.Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class Booking
    {
        DateTime startdate;
        int days;
    }
}
