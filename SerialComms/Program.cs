using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace SerialComms
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static AHRS.MadgwickAHRS AHRS = new AHRS.MadgwickAHRS(1f / 256f, 0.1f);
        static Form1 gui;
        static long time = System.Diagnostics.Stopwatch.GetTimestamp();
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gui = new Form1();
            System.Diagnostics.Stopwatch.StartNew();

            try
            {
                x_IMU_API.xIMUserial xIMUserial = new x_IMU_API.xIMUserial("COM4");// Hard coded
                xIMUserial.Open();
                xIMUserial.CalInertialAndMagneticDataReceived += new x_IMU_API.xIMUserial.onCalInertialAndMagneticDataReceived(xIMUserial_CalInertialAndMagneticDataReceived_updateIMU);
            }
            catch (System.IO.IOException)
            {
                System.Diagnostics.Debug.WriteLine("No IMU COM");

            }
            Thread.Sleep(2000);
            //Application.Run(gui);    
           

        }
        static void xIMUserial_CalInertialAndMagneticDataReceived_updateIMU(object sender, x_IMU_API.CalInertialAndMagneticData e)
        {
            
            AHRS.Update(deg2rad(e.Gyroscope[0]), deg2rad(e.Gyroscope[1]), deg2rad(e.Gyroscope[2]), e.Accelerometer[0], e.Accelerometer[1], e.Accelerometer[2]);
            System.Diagnostics.Debug.WriteLine(System.Diagnostics.Stopwatch.GetTimestamp() - time);
            time = System.Diagnostics.Stopwatch.GetTimestamp();
            //System.Diagnostics.Debug.WriteLine(AHRS.Quaternion[1]);
            //if (AHRS.Quaternion[1] > 0)
            //{
            //    gui.VibOn(1);
            //}
            //else if (AHRS.Quaternion[1] < -.25)
            //{
            //    gui.VibOn(1);
            //}
            //else
            //{
            //    gui.VibOff(1);
            //}
        }

        static float deg2rad(float degrees) 
        {
            return (float)(Math.PI / 180) * degrees;
        }
    }
}
