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

        }
    }

    public class CVehicle
    {
        public string Name { get; set; }
    }
}
