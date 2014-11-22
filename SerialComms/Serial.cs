using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;

namespace SerialComms
{
    class Serial
    {
        static bool _connected = false;
        static bool SerialCheckout = false; // keeps multiple threads from accessing serial port
        static SerialPort _serialPort;
        Thread readThread;
        Form1 mainForm;

        public void serialInit(Form1 form_in)
        {
            mainForm = form_in;
            
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                mainForm.serialcombo.Items.Add(port);
            }
            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();

            _serialPort.BaudRate = 9600;
            _serialPort.Parity = Parity.None;
            _serialPort.StopBits = StopBits.One;
            _serialPort.DataBits = 8;
            _serialPort.Handshake = Handshake.None;

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            readThread = new Thread(Read); // start the reader thread

        }
        public Boolean Disconnect()
        {
            try
            {
                _connected = false;
                _serialPort.Close();
                mainForm.errortext.Text = "disconnected:" + readThread.IsAlive;
                return true;
            }
            catch (System.IO.IOException ex)
            {
                mainForm.errortext.Text = "Close Serial Port Error";
                return false;
            }
        }

        public Boolean Connect()
        {
            mainForm.errortext.Text = "connecting";
            System.Diagnostics.Debug.Write(mainForm.serialcombo.Text);
            if (mainForm.serialcombo.Text != "")
            {
                _serialPort.PortName = mainForm.serialcombo.Text;
            }
            else
            {
                _serialPort.PortName = "COM1";
            }
            try
            {
                _serialPort.Open();
                mainForm.errortext.Text = "connected";
                _connected = true;
                readThread.Start();
                _serialPort.WriteLine("can you hear me");
                return true;

            }
            catch (Exception ex)
            {
                if (ex is System.IO.IOException)
                {
                    mainForm.errortext.Text = "Arduino IO Error";
                }
                else if (ex is System.NullReferenceException)
                {
                    mainForm.errortext.Text = "error2";
                }
                return false;
            } 
        }
        public void startThread(int dirSelect)// select which direction to vibrate
        {
            if (SerialCheckout == false)
            {
                switch (dirSelect)
                {
                    case 1:

                        System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(vibUp),_serialPort);
                        SerialCheckout = true;
                        break;
                    case 2:
                        System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(vibLeft), _serialPort);
                        SerialCheckout = true;
                        break;
                    case 3:
                        System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(vibDown), _serialPort);
                        SerialCheckout = true;
                        break;
                    case 4:
                        System.Threading.ThreadPool.QueueUserWorkItem(new System.Threading.WaitCallback(vibRight), _serialPort);
                        SerialCheckout = true;
                        break;
                }
            }
        }
        public static void vibUp(Object sp_ob)
        {
            SerialPort sp = (SerialPort)sp_ob;
            if (_connected == true)
            {
                
                sp.WriteLine("TxO" + 0 + "UxT");
                Thread.Sleep(1000);
                sp.WriteLine("TxP" + 0 + "UxT");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("alert");
            }
            SerialCheckout = false;
        }
        public static void vibLeft(Object sp_ob)
        {
            SerialPort sp = (SerialPort)sp_ob;
            if (_connected == true)
            {

                sp.WriteLine("TxO" + 2 + "UxT");
                Thread.Sleep(1000);
                sp.WriteLine("TxP" + 2 + "UxT");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("alert");
            }
            SerialCheckout = false;
        }
        public static void vibDown(Object sp_ob)
        {
            SerialPort sp = (SerialPort)sp_ob;
            if (_connected == true)
            {

                sp.WriteLine("TxO" + 4 + "UxT");
                Thread.Sleep(1000);
                sp.WriteLine("TxP" + 4 + "UxT");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("alert");
            }
            SerialCheckout = false;
        }
        public static void vibRight(Object sp_ob)
        {
            SerialPort sp = (SerialPort)sp_ob;
            if (_connected == true)
            {

                sp.WriteLine("TxO" + 5 + "UxT");
                Thread.Sleep(1000);
                sp.WriteLine("TxP" + 5 + "UxT");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("alert");
            }
            SerialCheckout = false;
        }
        public static void Read()
        {
            while (_connected)
            {
                try
                {
                    string message = _serialPort.ReadLine();
                    System.Diagnostics.Debug.Write(message);
                }
                catch (TimeoutException) { }
                catch (System.IO.IOException ex) { System.Diagnostics.Debug.WriteLine("Serial port closed too early"); }
            }
        }
    }

}
