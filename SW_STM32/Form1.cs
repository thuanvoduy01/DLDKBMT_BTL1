using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace SW_STM32
{
    public partial class Form1 : Form
    {
        string dataOut;
        byte[] bPOS = { 0x02, 0x47, 0x50, 0x4F, 0x53, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x16, 0x03};
        byte[] bSTT = { 0x02, 0x47, 0x53, 0x54, 0x54, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x16, 0x03};
        byte[] bMOV = { 0x02, 0x4D, 0x4F, 0x56, 0x4C, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x16, 0x03};
        byte[] bVEL = { 0x02, 0x47, 0x56, 0x45, 0x4C, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x01, 0x16, 0x03};
        string DataSend, DataReceive,SendData;
        int DataLength;
        string newLine = Environment.NewLine;
        string SendDataRaw;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxName.Items.AddRange(ports);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxName.Text;
                serialPort1.BaudRate = Convert.ToInt32 (cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataSize.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text);

                serialPort1.Open();
                progressBar1.Value = 100;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close(); 
                progressBar1.Value = 0;
            }    
        }

        private void btnSend_1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = tBoxSend_1.Text;
                serialPort1.WriteLine(dataOut);
                DataLength = tBoxSend_1.TextLength;
                tBoxSend_1.Clear();
                StatusLabel.Text = string.Format("{0:00}", DataLength) + " byte sent";
            }
        }

        private void btnSend_2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOut = tBoxSend_2.Text;
                serialPort1.WriteLine(dataOut);
                DataLength = tBoxSend_2.TextLength;
                tBoxSend_2.Clear();
                StatusLabel.Text = string.Format("{0:00}", DataLength) + " byte sent";
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(bPOS, 0, 18);
                SendDataRaw = BitConverter.ToString(bPOS);
                SendData = string.Join(" ", SendDataRaw.Split('-'));
                this.Invoke(new EventHandler(Tramsmit));
            }
        }

        private void Tramsmit(object sender, EventArgs e)
        {
            tBoxData.Text += SendData + newLine;
            StatusLabel.Text = string.Format("{0:00}", 18) + " byte written";
            if (SendDataRaw == BitConverter.ToString(bPOS))
            {
                tBoxData.Text += "POS CMD" + newLine;
            }
            else if(SendDataRaw == BitConverter.ToString(bVEL))
            {
                tBoxData.Text += "VEL CMD" + newLine;
            }
            else if (SendDataRaw == BitConverter.ToString(bSTT))
            {
                tBoxData.Text += "STT CMD" + newLine;
            }
            else if (SendDataRaw == BitConverter.ToString(bMOV))
            {
                tBoxData.Text += "MOV CMD" + newLine;
            }
        }

        private void btnVEL_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(bVEL, 0, 18);
                SendDataRaw = BitConverter.ToString(bVEL);
                SendData = string.Join(" ", SendDataRaw.Split('-'));
                this.Invoke(new EventHandler(Tramsmit));
            }
        }

        private void btnSTT_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(bSTT, 0, 18);
                SendDataRaw = BitConverter.ToString(bSTT);
                SendData = string.Join(" ", SendDataRaw.Split('-'));
                this.Invoke(new EventHandler(Tramsmit));
            }
        }

        private void btnMOV_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(bMOV, 0, 18);
                SendDataRaw = BitConverter.ToString(bMOV);
                SendData = string.Join(" ", SendDataRaw.Split('-'));
                this.Invoke(new EventHandler(Tramsmit));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(tBoxData.Text !="")
            {
                tBoxData.Text = "";
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!serialPort1.IsOpen) return;
            Thread.Sleep(100);
            int bytes = serialPort1.BytesToRead;
            byte[] buffer = new byte[bytes];
            string DataReceiveRaw;
            serialPort1.Read(buffer, 0, bytes);
            if (buffer.Length == bytes)
            {
                DataReceiveRaw = BitConverter.ToString(buffer);
                DataReceive = string.Join(" ", DataReceiveRaw.Split('-'));
                this.Invoke(new EventHandler(ShowData));
            }
        }

        private void ShowData(object sender, EventArgs e)
        {
            tBoxData.Text += DataReceive + newLine;
            tBoxData.Text += "Receive" + newLine;
            StatusLabel.Text = string.Format("{0:00}", 18) + " byte received";
        }
    }
}
