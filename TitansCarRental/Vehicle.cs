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
                listBox1.Items.Add(v.ID + "      " + v.Type + "      " + v.Make + "     " + v.Model + "      " + v.Miles + "      " + v.Transmission + "     " + v.Year + "     " + v.Rates + "     " + v.Fuel);
            }
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
