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

namespace GUI_DMS
{
    public partial class Form4 : Form
    {
        string RxString;/***************************/
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //Me.CenterToParent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); /**********************/
        }

        void getAvailablePorts()
        {
            CmbScanPort.Items.Clear();
            CmbScanPort.Text = "";
            string[] ports = SerialPort.GetPortNames();
            CmbScanPort.Items.AddRange(ports);
        }
        /************************************************************************/
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }
        
        private void DisplayText(object sender, EventArgs e)
        {
            textBox1.AppendText(RxString);
        }
        /**************************************************************************/
        private void BtnScanPort_Click(object sender, EventArgs e)
        {
            getAvailablePorts();
        }
        
        private void BtnCon_Click(object sender, EventArgs e)
        {
            try
            {
                if(CmbScanPort.Text == "" || CmbBaud.Text == "")
                {
                    textBox1.Text = "Please select Port and Baud Rate";
                }
                else
                {
                    //if (serialPort1.IsOpen == false) textBox1.Text = "Make sure you have connect your serial port";
                    serialPort1.PortName = CmbScanPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(CmbBaud.Text);
                    serialPort1.Open();
                    progressBar1.Value = 100;
                    BtnRead.Enabled = true;
                    BtnCon.Enabled = false;
                    BtnDiscon.Enabled = true;

                }
            }
            catch(UnauthorizedAccessException)
            {
                textBox1.Text = "Unauthorized Access";
            }

        }

        private void BtnDiscon_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            progressBar1.Value = 0;
            BtnDiscon.Enabled = false;
            BtnCon.Enabled = true;
            BtnRead.Enabled = false;
            CmbScanPort.Text = "";
            CmbBaud.Text = "";
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RxString = serialPort1.ReadExisting();
                textBox1.AppendText(RxString);

            }
            catch(TimeoutException)
            {
                textBox1.Text = "Timeout Exception";
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string  data = "x" + txtBoxX.Text + ";y" + txtBoxY.Text + ";z" + txtBoxZ.Text + ";A" + txtBoxAngle.Text + ";s" + txtBoxSetA2.Text + ";a" + txtBoxa6.Text + ";m" + txtBoxMirror.Text + ":";
            //double data = Convert.ToDouble(txtBoxSend.Text);
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(data);
            }
            //Console.WriteLine(data);
            else textBox1.Text = "serial connection is lost";
        }
    }
}
