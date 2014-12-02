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
        Serial s = new Serial();
        public Form1()
        {
            InitializeComponent();
            s.serialInit(this);
            
        }
        
        private void disconnectbtn_Click(object sender, EventArgs e)
        {
            s.Disconnect();
        }
        private void connectbtn_Click(object sender, EventArgs e)
        {
            s.Connect();          
        }
        
        private void nbutton_Click(object sender, EventArgs e)
        {
            s.startThread(1);
        }
        private void nebutton_Click(object sender, EventArgs e)
        {
        }
        private void ebutton_Click(object sender, EventArgs e)
        {
            s.startThread(2);
        }
        private void sebutton_Click(object sender, EventArgs e)
        {

        }
        private void sbutton_Click(object sender, EventArgs e)
        {
            s.startThread(3);
        }
        private void swbutton_Click(object sender, EventArgs e)
        {

        }
        private void wbutton_Click(object sender, EventArgs e)
        {
            s.startThread(4);
        }
        private void nwbutton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            s.Disconnect();
        }
    }
    
    
}
