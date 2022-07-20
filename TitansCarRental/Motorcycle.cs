using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TitansCarRental
{
    public partial class Motorcycle : Form
    {
        public Motorcycle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                int Index = listBox1.SelectedIndex;
                if (Program.MotorcycleList != null && Program.MotorcycleList.Count > 0)
                {
                    Program.MotorcycleList.RemoveAt(Index);
                    RefreshForm();
                }
                else
                    MessageBox.Show("Error, MotorcycleList is empty");
            }
            else
                MessageBox.Show("Please select an item in the list");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CMotorcycle m = new CMotorcycle();
            m.ID = int.Parse(txtID.Text);
            m.Name = txtName.Text;
            m.Year = txtYear.Text;
            Program.MotorcycleList.Add(m);
            RefreshForm();

        }

        private void RefreshForm()
        {
            listBox1.Items.Clear();
            foreach (CMotorcycle m in Program.MotorcycleList)
            {
                listBox1.Items.Add(m.ID + "      Name: " + m.Name + "      Year: " + m.Year);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class CMotorcycle
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }


    }
       
}
