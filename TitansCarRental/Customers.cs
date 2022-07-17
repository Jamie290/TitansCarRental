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
            c.ID = int.Parse(txtID.Text);
            c.Name = txtName.Text;
            c.Email = txtEmail.Text;
            c.Phone = txtPhone.Text;
            allmycustomers.Add(c);
            RefreshForm();
        }
        private void RefreshForm()
        {
            listBox1.Items.Clear();
            foreach(Customer c in allmycustomers)
            {
                listBox1.Items.Add(c.ID +"      " + c.Name + "      " + c.Email + "     " + c.Phone);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                int Index = listBox1.SelectedIndex;
                if (allmycustomers!= null && allmycustomers.Count > 0)
                {
                    allmycustomers.RemoveAt(Index);
                    RefreshForm();
                }
                else
                    MessageBox.Show("Error, allmycustomers is empty");
            }
            else
                MessageBox.Show("Please select an item in the list");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public class Customer
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public int ID { get; set; }
    }
}
