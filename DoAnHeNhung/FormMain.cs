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
using System.Diagnostics;
using System.Collections;
using System.Threading;
using System.IO;

namespace DoAnHeNhung
{
    public partial class FormMain : Form
    {
        #region quan ly bien
        SerialPort UART = new SerialPort();
        String[] vs = new String[] { "2400", "4800", "9600", "14400", "19200" };
        #endregion quan ly bien

        #region quan ly ham
        public void Khoi_Tao()
        {
            try
            {
                cbtTenCongCom.DataSource = SerialPort.GetPortNames();
                if (cbtTenCongCom.Items.Count > 0)
                {
                    cbtTenCongCom.SelectedItem = 0;
                }
                cbBaudrate.DataSource = vs;
                cbBaudrate.SelectedIndex = 2;

                //setting cho do thi
                chartNhiet.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chartNhiet.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                chartNhiet.ChartAreas[1].AxisX.MajorGrid.LineWidth = 0;
                chartNhiet.ChartAreas[1].AxisY.MajorGrid.LineWidth = 0;
                chartNhiet.ChartAreas[2].AxisX.MajorGrid.LineWidth = 0;
                chartNhiet.ChartAreas[2].AxisY.MajorGrid.LineWidth = 0;
                chartNhiet.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
                chartNhiet.ChartAreas[1].AxisX.LabelStyle.Format = "hh:mm:ss";
                chartNhiet.ChartAreas[2].AxisX.LabelStyle.Format = "hh:mm:ss";
                chartNhiet.ChartAreas[0].AxisY.Maximum = 2;
                chartNhiet.ChartAreas[0].AxisY.Minimum = -1;

                chartNhiet.ChartAreas[0].AxisX.ScaleView.Size = 20;
                chartNhiet.ChartAreas[1].AxisX.ScaleView.Size = 20;
                chartNhiet.ChartAreas[2].AxisX.ScaleView.Size = 20;
                chartNhiet.ChartAreas[0].AxisX.MaximumAutoSize = 20;
                chartNhiet.ChartAreas[1].AxisX.MaximumAutoSize = 20;
                chartNhiet.ChartAreas[2].AxisX.MaximumAutoSize = 20;

                btnExport.Enabled = false;
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception " + e.ToString());
            }
        }
        #endregion quan ly ham

        #region quan ly form
        public FormMain()
        {
            InitializeComponent();
        }

        // load cac ham khi form khoi tao
        private void FromMain_Load(object sender, EventArgs e)
        {
            // nhan du lieu ma may tinh gui len form
            Control.CheckForIllegalCrossThreadCalls = false;
            Khoi_Tao();
            this.UART.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.UART_DataReceived);

        }


        //  hien thi ro cac component
        private void FromMain_Shown(object sender, EventArgs e)
        {

        }

        // su kien khi dong form
        private void FromMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UART.IsOpen == true)
            {
                UART.DataReceived -= UART_DataReceived;
                Thread.Sleep(100);
                UART.Close();
            }
        }

        // su kien khi nhan phim
        private void FromMain_KeyDown(object sender, KeyEventArgs e)
        {

        }
        #endregion quan ly form

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        #region cac su kien tao tac voi form
        // connect port
        private void btnConnected_Click(object sender, EventArgs e)
        {
            try
            {
                cbtTenCongCom.DataSource = SerialPort.GetPortNames();
                if (UART.IsOpen == true)
                {
                    UART.DataReceived -= UART_DataReceived;
                    Thread.Sleep(100);
                    UART.Close();
                    //Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnExit));
                    //CloseDown.Start();
                    
                    btnConnected.Text = "Connect";
                    btnExport.Enabled = true;
                    cbBaudrate.Enabled = true;
                    cbtTenCongCom.Enabled = true;
                }
                else
                {
                    UART.PortName = cbtTenCongCom.Text;
                    UART.BaudRate = Int32.Parse(cbBaudrate.Text);
                    UART.DataReceived += UART_DataReceived;
                    UART.Open();
                    if (UART.IsOpen == true)
                    {
                        btnConnected.Text = "Disconnect";
                        btnExport.Enabled = false;
                        cbBaudrate.Enabled = false;
                        cbtTenCongCom.Enabled = false;
                    }
                    else {
                        MessageBox.Show("Ket noi khong thanh cong");
                    }                    
                } 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion cac su kien thao tac voi form

        // nhan giu lieu tu may tinh gui len
        private void UART_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if(UART.IsOpen == true)
                {
                    String str = UART.ReadLine();
                    str = str.Split('S')[1];
                    string[] data = str.Split('|');
                    ListViewItem item = new ListViewItem(data[0], 0);
                    item.SubItems.Add(data[1]);
                    item.SubItems.Add(data[2]);
                    item.SubItems.Add(DateTime.Now.ToLongTimeString());
                    listView1.Items.Insert(0, item);

                    chartNhiet.Series[0].Points.InsertXY(0, DateTime.Now, data[0]);
                    chartNhiet.Series[1].Points.InsertXY(0, DateTime.Now, data[1]);
                    chartNhiet.Series[2].Points.InsertXY(0, DateTime.Now, data[2]);
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void chartNhiet_Click(object sender, EventArgs e)
        {

        }

        private void baudrate_Click(object sender, EventArgs e)
        {

        }

        private void cbBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try {
                string result = "Vibration,Celsius,Humidity,Time\n";
                if (listView1.Items.Count < 1)
                {
                    MessageBox.Show("Khong co du lieu!");
                    return;
                }
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    for (int j = 0; j < listView1.Columns.Count; j++)
                    {
                        result += listView1.Items[i].SubItems[j].Text + ",";
                    }
                    result = result.TrimEnd(',');
                    result = result + '\n';
                }
                File.WriteAllText("export.csv", result);
            } catch (Exception ex) {
                MessageBox.Show("Export data khong thanh cong!");
                throw ex;
            }
            MessageBox.Show("Export data thanh cong!");
        }
    }
}
