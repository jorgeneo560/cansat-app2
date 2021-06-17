using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO.Ports;


namespace cansat_app
{
    public partial class Form1 : Form
    {
        public static List<byte> bufferout = new List<byte>();
        SerialPort mySerialPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximize.Visible = true;
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenForm(Object Formchild)
        {
            if (this.PanelContainer.Controls.Count > 0)
                this.PanelContainer.Controls.RemoveAt(0);
            System.Windows.Forms.Form fc = Formchild as System.Windows.Forms.Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(fc);
            this.PanelContainer.Tag = fc;
            fc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            this.comboBox1.Items.AddRange(ports);
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            OpenForm(new Main());
        }

        private void btnResolution_Click(object sender, EventArgs e)
        {
            OpenForm(new Resolution());
        }

        private void btnConnect_Click(object sender, EventArgs e)
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

        private void btnSendData_Click(object sender, EventArgs e)
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
