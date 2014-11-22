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
        static SerialPort _serialPort;
        Thread readThread = new Thread(Read);
    }
}
