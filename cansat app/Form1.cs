using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace cansat_app
{
    public partial class Form1 : Form
    {
        public static List<byte> bufferout = new List<byte>();
        SerialPort mySerialPort = new SerialPort();
        MqttClient client = new MqttClient(IPAddress.Parse(MQTT_BROKER_ADDRESS));
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            this.comboBox1 .Items.AddRange (ports);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                mySerialPort.PortName = this.comboBox1.Text;
                mySerialPort.BaudRate = 19200;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;
                mySerialPort.Handshake = Handshake.None;
                mySerialPort.RtsEnable = true;
                mySerialPort.Open();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var datatx = "CMD,1231,CX,ON";
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
            
            

            
            if (!mySerialPort.IsOpen)
            {
                mySerialPort.Open();

            }
            mySerialPort.Write(bufferout.ToArray(), 0, bufferout.Count);

            //_serialPort.Close(); //esta linea se agrego despues de la prueba
        }
    }
}
