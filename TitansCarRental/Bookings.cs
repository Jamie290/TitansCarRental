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
            Booking b = new Booking();
            b.Name = BoxName.Text;
            b.ID = BoxID.Text;
            b.Status = txtStatus.Text;
            b.Weeks = txtWeeks.Text;
            b.Days = txtDays.Text;
            b.startdate = Convert.ToDateTime(DateTime.Text);
            Program.allbookings.Add(b);
            RefreshForm();
        }

        private void RefreshForm()
        {
            listBox1.Items.Clear();
            foreach (Booking b in Program.allbookings)
            {
                listBox1.Items.Add(b.ID + "     Name: " + b.Name + "     Booking Status: " + b.Status + "    Start Date: " + b.startdate + "     Booked Weeks: " + b.Weeks + "     Booked Days: " + b.Days);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            foreach(Customer c in Program.allmycustomers)
            {
                BoxName.Items.Add(c.Name);
            }

            foreach (CVehicle v in Program.VehicleList)
            {
                BoxID.Items.Add(v.ID + " (Car)");
            }

            foreach (CMotorcycle M in Program.MotorcycleList)
            {
                BoxID.Items.Add(M.ID + " (Motorcycle)");
            }


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex > -1)
            {
                int Index = listBox1.SelectedIndex;
                if (Program.allbookings != null && Program.allbookings.Count > 0)
                {
                    Program.allbookings.RemoveAt(Index);
                    RefreshForm();
                }
                else
                    MessageBox.Show("Error, allbookings is empty");
            }
            else
                MessageBox.Show("Please select an item in the list");
        }
    }
    public class Booking
    {
        public DateTime startdate { get; set; }
        public string Days { get; set; }
        public string Weeks { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }


    }
}
