using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitansCarRental
{
    static class Program
    {
        static public List<Customer> allmycustomers = new List<Customer>();
        static public List<CVehicle> VehicleList = new List<CVehicle>();
        static public List<CMotorcycle> MotorcycleList = new List<CMotorcycle>();
        static public List<Booking> allbookings = new List<Booking>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {         
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
