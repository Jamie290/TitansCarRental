using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TitansCarRental
{
    public partial class Customers : Form
    {
        public List<Customer> allmycustomers = new List<Customer>();

        public Customers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Name = txtName.Text;
            c.Email = txtEmail.Text;
            allmycustomers.Add(c);
            RefreshForm();
        }
        private void RefreshForm()
        {
            listBox1.Items.Clear();
            foreach(Customer c in allmycustomers)
            {
                listBox1.Items.Add(c.Name + " " + c.Email);
            }
        }
       
    }
    public class Customer
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
}
