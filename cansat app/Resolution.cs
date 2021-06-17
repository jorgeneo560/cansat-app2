using cansat_app;
using Cansat2021;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cansat_app
{
    public partial class Resolution : Form
    {
        public static List<byte> buffer = new List<byte>();
        public static List<byte> bufferout = new List<byte>();
        public static List<string> telemetry = new List<string>();
        public static SerialPort _serialPort;
        public Resolution()
        {
            InitializeComponent();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        
        static bool _continue;
        
        public  void init()
        {
            //TimerClass timer = new TimerClass();
            //TimerClass.Main();


            //CsvHelper csvHelper = new CsvHelper();
            //var myFile = csvHelper.readExampleFile();
            string name = "";
            string message = "";
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            //Thread readThread = new Thread(Read);

            // Create a new SerialPort object with default settings.  
            serialPort1 = new SerialPort();

            // Allow the user to set the appropriate properties.  
            serialPort1.PortName = SetPortName(Form1.portname );
            serialPort1.BaudRate = SetPortBaudRate(19200);
            serialPort1.Parity = SetPortParity(_serialPort.Parity);
            serialPort1.DataBits = SetPortDataBits(_serialPort.DataBits);
            serialPort1.StopBits = SetPortStopBits(_serialPort.StopBits);
            serialPort1.Handshake = SetPortHandshake(_serialPort.Handshake);


            //Set the read / write timeouts
            serialPort1.ReadTimeout = 500;
            serialPort1.WriteTimeout = 500;
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_OnReceiveDatazz);
            }

            //_serialPort.Open();
            _continue = true;
            //readThread.Start();

            Console.Write("Name: ");
            //name = Console.ReadLine();

            Console.WriteLine("Type QUIT to exit");

            //while (_continue)
            //{
            //    //message = Console.ReadLine();

            //    if (stringComparer.Equals("quit", message))
            //    {
            //        _continue = false;
            //    }
            //    else
            //    {
            //        _serialPort.WriteLine(
            //            String.Format("<{0}>: {1}", name, message));
            //    }
            //}

            //readThread.Join();
            //_serialPort.Close();
        }

        private  void port_OnReceiveDatazz(object sender,
                                  SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            var byteReaded = _serialPort.ReadByte();
            while (_serialPort.BytesToRead >1){

                if (byteReaded == 0x7E)
                {
                    buffer.Clear();
                    telemetry.Clear();
                }
                buffer.Add((byte)byteReaded);

                if (buffer.Count >= 9)
                {
                    var buffer2 = buffer[2];
                    byte aux;
                    aux = (byte)(buffer[2] + 0x04);
                    if (aux == (byte)buffer.Count) //pregunta si ya tenemos toda la trama dentro de buffer
                    {
                        var message = "";
                        for (int i = 8; i < (buffer.Count - 1); i++)
                        {
                            message += (char)buffer[i];
                        }



                        //Split message and send to CsvHelper class to create or append 
                        telemetry = message.Split(',').ToList();
                        Cansat2021.CsvHelper.writeCsvFromList(telemetry);

                        fillForm(telemetry);
                        //Send message to Mqtt server
                        Mqtt.Publish(message);
                    }
                }

            }
        }

        public  void fillForm(List<string> telemetry)
        {
            textBox1.Text = "hola";
        }
        public static string SetPortName(string defaultPortName)
        {
            try
            {
                string portName = "";

                Console.WriteLine("Available Ports:");
                foreach (string s in SerialPort.GetPortNames())
                {
                    Console.WriteLine("   {0}", s);
                }

                Console.Write("COM port({0}): ", defaultPortName);
                //portName = Console.ReadLine();

                if (portName == "")
                {
                    portName = defaultPortName;
                }
                return portName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static int SetPortBaudRate(int defaultPortBaudRate)
        {
            string baudRate = "";

            Console.Write("Baud Rate({0}): ", defaultPortBaudRate);
            //baudRate = Console.ReadLine();

            if (baudRate == "")
            {
                baudRate = defaultPortBaudRate.ToString();
            }

            return int.Parse(baudRate);
        }

        public static Parity SetPortParity(Parity defaultPortParity)
        {
            string parity = "";

            Console.WriteLine("Available Parity options:");
            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Parity({0}):", defaultPortParity.ToString());
            //parity = Console.ReadLine();

            if (parity == "")
            {
                parity = defaultPortParity.ToString();
            }

            return (Parity)Enum.Parse(typeof(Parity), parity);
        }

        public static int SetPortDataBits(int defaultPortDataBits)
        {
            string dataBits = "";

            Console.Write("Data Bits({0}): ", defaultPortDataBits);
            //dataBits = Console.ReadLine();

            if (dataBits == "")
            {
                dataBits = defaultPortDataBits.ToString();
            }

            return int.Parse(dataBits);
        }

        public static StopBits SetPortStopBits(StopBits defaultPortStopBits)
        {
            string stopBits = "";

            Console.WriteLine("Available Stop Bits options:");
            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Stop Bits({0}):", defaultPortStopBits.ToString());
            //stopBits = Console.ReadLine();

            if (stopBits == "")
            {
                stopBits = defaultPortStopBits.ToString();
            }

            return (StopBits)Enum.Parse(typeof(StopBits), stopBits);
        }

        public static Handshake SetPortHandshake(Handshake defaultPortHandshake)
        {
            string handshake = "";

            Console.WriteLine("Available Handshake options:");
            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                Console.WriteLine("   {0}", s);
            }

            Console.Write("Handshake({0}):", defaultPortHandshake.ToString());
            //handshake = Console.ReadLine();

            if (handshake == "")
            {
                handshake = defaultPortHandshake.ToString();
            }

            return (Handshake)Enum.Parse(typeof(Handshake), handshake);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            init();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                var datatx = "CMD,1231,SIM,ACTIVATE";
            bufferout.Clear();
            bufferout.Add(0x7E);
            bufferout.Add(0x00);
            bufferout.Add((byte)(datatx.Length + 5));
            bufferout.Add(0x01);
            bufferout.Add(0x01);
            bufferout.Add(0x01); //0x01 
            bufferout.Add(0x11); //0x11
            bufferout.Add(0x00);

            for (int i = 0; i < datatx.Length; i++)
            {
                bufferout.Add((byte)datatx[i]);
            }
            byte chkaux = 0;
            for (int i = 3; i < datatx.Length + 8; i++)
            {
                chkaux += bufferout[i];
            }
            chkaux = (byte)(0xFF - chkaux);
            bufferout.Add(chkaux);




            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();

            }
            serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var datatx = "CMD,1231,SIM,ENABLE";
            bufferout.Clear();
            bufferout.Add(0x7E);
            bufferout.Add(0x00);
            bufferout.Add((byte)(datatx.Length + 5));
            bufferout.Add(0x01);
            bufferout.Add(0x01);
            bufferout.Add(0x01); //0x01 
            bufferout.Add(0x11); //0x11
            bufferout.Add(0x00);

            for (int i = 0; i < datatx.Length; i++)
            {
                bufferout.Add((byte)datatx[i]);
            }
            byte chkaux = 0;
            for (int i = 3; i < datatx.Length + 8; i++)
            {
                chkaux += bufferout[i];
            }
            chkaux = (byte)(0xFF - chkaux);
            bufferout.Add(chkaux);




            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();

            }
            serialPort1.Write(bufferout.ToArray(), 0, bufferout.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Resolution_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
