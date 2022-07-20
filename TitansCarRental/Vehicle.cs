//using FormTitansCarRental.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TitansCarRental
{
    public partial class Vehicle : Form
    {
        private readonly string _rootDir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\";
       
        public Vehicle()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                int Index = listBox1.SelectedIndex;
                if (Program.VehicleList != null && Program.VehicleList.Count > 0)
                {
                    Program.VehicleList.RemoveAt(Index);
                    RefreshForm();
                }
                else
                    MessageBox.Show("Error, VehicleList is empty");
            }
            else
                MessageBox.Show("Please select an item in the list");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            CVehicle v = new CVehicle();
            v.ID = int.Parse(txtID.Text);
            v.Make = txtMake.Text;
            v.Miles = txtMiles.Text;
            v.Model = txtModel.Text;
            v.Fuel = txtFuel.Text;
            v.Rates = txtrates.Text;
            v.Year = txtYear.Text;
            v.Transmission = txtTrans.Text;
            v.Type = txtType.Text;
            Program.VehicleList.Add(v);
            RefreshForm();

        }

        private void RefreshForm()
        {
            listBox1.Items.Clear();
            foreach (CVehicle v in Program.VehicleList)
            {
                listBox1.Items.Add(v.ID + "     Type: " + v.Type + "     Make: " + v.Make + "    Model: " + v.Model + "     Mileage: " + v.Miles + "     Transmission: " + v.Transmission + "    Purchase Year: " + v.Year + "    Rental Rates: " + v.Rates + "    Fuel: " + v.Fuel);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.HorizontalScrollbar = true;
        }
    }

    public class CVehicle
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Rates { get; set; }

        public string Transmission { get; set; }
        public string Fuel { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string Miles { get; set; }


    }
}
