using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace SerialComms
{
    class Program
    {


        static IMUAPI imu = new IMUAPI();
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 gui = new Form1();
            imu.initIUM();

            
            Application.Run(gui);    
           

        }
        
    }
}
