
namespace TitansCarRental
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Customers = new System.Windows.Forms.Button();
            this.Booking = new System.Windows.Forms.Button();
            this.Vehicle = new System.Windows.Forms.Button();
            this.Motorcycles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TitansCarRental.Properties.Resources.logo_Titan2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Customers
            // 
            this.Customers.BackColor = System.Drawing.Color.Gray;
            this.Customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Customers.Location = new System.Drawing.Point(30, 211);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(263, 105);
            this.Customers.TabIndex = 2;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = false;
            // 
            // Booking
            // 
            this.Booking.BackColor = System.Drawing.Color.Gray;
            this.Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Booking.Location = new System.Drawing.Point(352, 211);
            this.Booking.Name = "Booking";
            this.Booking.Size = new System.Drawing.Size(263, 105);
            this.Booking.TabIndex = 3;
            this.Booking.Text = "Booking";
            this.Booking.UseVisualStyleBackColor = false;
            // 
            // Vehicle
            // 
            this.Vehicle.BackColor = System.Drawing.Color.Gray;
            this.Vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Vehicle.Location = new System.Drawing.Point(694, 211);
            this.Vehicle.Name = "Vehicle";
            this.Vehicle.Size = new System.Drawing.Size(263, 105);
            this.Vehicle.TabIndex = 4;
            this.Vehicle.Text = "Vehicle";
            this.Vehicle.UseVisualStyleBackColor = false;
            // 
            // Motorcycles
            // 
            this.Motorcycles.BackColor = System.Drawing.Color.Gray;
            this.Motorcycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Motorcycles.Location = new System.Drawing.Point(1023, 211);
            this.Motorcycles.Name = "Motorcycles";
            this.Motorcycles.Size = new System.Drawing.Size(263, 105);
            this.Motorcycles.TabIndex = 5;
            this.Motorcycles.Text = "Motorcycle";
            this.Motorcycles.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 450);
            this.Controls.Add(this.Motorcycles);
            this.Controls.Add(this.Vehicle);
            this.Controls.Add(this.Booking);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Customers;
        private System.Windows.Forms.Button Booking;
        private System.Windows.Forms.Button Vehicle;
        private System.Windows.Forms.Button Motorcycles;
    }
}