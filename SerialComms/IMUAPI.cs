using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialComms
{
    class IMUAPI
    {
        static AHRS.MadgwickAHRS AHRS = new AHRS.MadgwickAHRS(1f / 256f, 0.1f);
        public IMUAPI()
        {

        }

        public bool initIUM()
        {
            try
            {
                x_IMU_API.xIMUserial xIMUserial = new x_IMU_API.xIMUserial("COM4");// Hard coded
                xIMUserial.Open();
                xIMUserial.CalInertialAndMagneticDataReceived += new x_IMU_API.xIMUserial.onCalInertialAndMagneticDataReceived(xIMUserial_CalInertialAndMagneticDataReceived_updateIMU);
                return true;
            }
            catch (System.IO.IOException)
            {
                System.Diagnostics.Debug.WriteLine("No IMU COM");
                return false;
            }
        }
        static void xIMUserial_CalInertialAndMagneticDataReceived_updateIMU(object sender, x_IMU_API.CalInertialAndMagneticData e)
        {

            AHRS.Update(deg2rad(e.Gyroscope[0]), deg2rad(e.Gyroscope[1]), deg2rad(e.Gyroscope[2]), e.Accelerometer[0], e.Accelerometer[1], e.Accelerometer[2]);
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
