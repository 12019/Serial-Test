using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialComms
{
    public partial class Form1 : Form
    {
        static bool _connected = false;
        static SerialPort _serialPort;
        Thread readThread = new Thread(Read);
        public Form1()
        {
            InitializeComponent();
            serialInit();
            
        }
        private void serialInit()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                serialcombo.Items.Add(port);
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
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void disconnectbtn_Click(object sender, EventArgs e)
        {
            _connected= false;
            readThread.Join();
            _serialPort.Close();
            errortext.Text = "disconnected:" + readThread.IsAlive;
        }
        private void connectbtn_Click(object sender, EventArgs e)
        {
            errortext.Text = "connecting";
            System.Diagnostics.Debug.Write(serialcombo.Text);
            if (serialcombo.Text != "")
            {
                _serialPort.PortName = serialcombo.Text;
            }
            else
            {
                _serialPort.PortName = "COM1";
            }
            try
            {
                _serialPort.Open();
                errortext.Text = "connected";
                _connected = true;
                readThread.Start();
                _serialPort.WriteLine("can you hear me");

            }
            catch (Exception ex)
            {
                if (ex is System.IO.IOException)
                {
                    errortext.Text = "Arduino IO Error";
                }
                else if (ex is System.NullReferenceException)
                {
                    errortext.Text = "error2";
                }
            }            
        }
        public void VibOn(int vibnum)
        {
            if (_connected == true)
            {
                _serialPort.WriteLine("TxO" + vibnum + "UxT");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("alert");
            }
        }
        public void VibOff(int vibnum)
        {
            if (_connected == true)
            {
                _serialPort.WriteLine("TxP" + vibnum + "UxT");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("alert-");
            }
        }
        private void nbutton_Click(object sender, EventArgs e)
        {
            if (_connected == true)
            {
                _serialPort.WriteLine("N");
            }
        }
        private void nebutton_Click(object sender, EventArgs e)
        {
            if (_connected == true)
            {
                _serialPort.WriteLine("NE");
            }
        }
        private void ebutton_Click(object sender, EventArgs e)
        {
            if (_connected == true)
            {
                _serialPort.WriteLine("E");
            }
        }
        private void sebutton_Click(object sender, EventArgs e)
        {
            if (_connected == true)
            {
                _serialPort.WriteLine("SE");
            }
        }
        private void sbutton_Click(object sender, EventArgs e)
        {
            if (_connected == true)
            {
                _serialPort.WriteLine("S");
            }
        }
        private void swbutton_Click(object sender, EventArgs e)
        {
            if (_connected == true)
            {
                _serialPort.WriteLine("SW");
            }
        }
        private void wbutton_Click(object sender, EventArgs e)
        {
            if (_connected == true)
            {
                _serialPort.WriteLine("W");
            }
        }
        private void nwbutton_Click(object sender, EventArgs e)
        {
            if (_connected == true)
            {
                _serialPort.WriteLine("NW");
            }
        }
    }
    
    
}
