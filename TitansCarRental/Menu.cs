using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TitansCarRental
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            var myForm = new Customers();
            myForm.Show();
        }

        private void Booking_Click(object sender, EventArgs e)
        {
            var myForm = new Bookings();
            myForm.Show();
        }

        private void Vehicle_Click(object sender, EventArgs e)
        {
            var myForm = new Vehicle();
            myForm.Show();
        }

        private void Motorcycles_Click(object sender, EventArgs e)
        {
            var myForm = new Motorcycle();
            myForm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
