namespace DoAnHeNhung
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.formConnect = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chartNhiet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colRung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNhiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.baudrate = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.btnConnected = new System.Windows.Forms.Button();
            this.cbtTenCongCom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExport = new System.Windows.Forms.Button();
            this.formConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhiet)).BeginInit();
            this.SuspendLayout();
            // 
            // formConnect
            // 
            this.formConnect.Controls.Add(this.btnExport);
            this.formConnect.Controls.Add(this.label2);
            this.formConnect.Controls.Add(this.chartNhiet);
            this.formConnect.Controls.Add(this.listView1);
            this.formConnect.Controls.Add(this.baudrate);
            this.formConnect.Controls.Add(this.cbBaudrate);
            this.formConnect.Controls.Add(this.btnConnected);
            this.formConnect.Controls.Add(this.cbtTenCongCom);
            this.formConnect.Controls.Add(this.label1);
            this.formConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.formConnect.Location = new System.Drawing.Point(12, 12);
            this.formConnect.Name = "formConnect";
            this.formConnect.Size = new System.Drawing.Size(1109, 565);
            this.formConnect.TabIndex = 0;
            this.formConnect.TabStop = false;
            this.formConnect.Text = "Data Export Screen";
            this.formConnect.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 12;
            // 
            // chartNhiet
            // 
            chartArea1.Name = "ChartAreaRung";
            chartArea2.BorderWidth = 2;
            chartArea2.Name = "ChartAreaNhiet";
            chartArea3.BorderWidth = 2;
            chartArea3.Name = "ChartAreaAm";
            this.chartNhiet.ChartAreas.Add(chartArea1);
            this.chartNhiet.ChartAreas.Add(chartArea2);
            this.chartNhiet.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.chartNhiet.Legends.Add(legend1);
            this.chartNhiet.Location = new System.Drawing.Point(27, 102);
            this.chartNhiet.Name = "chartNhiet";
            series1.ChartArea = "ChartAreaRung";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Rung";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartAreaNhiet";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "NhietDo";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartAreaAm";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "DoAm";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartNhiet.Series.Add(series1);
            this.chartNhiet.Series.Add(series2);
            this.chartNhiet.Series.Add(series3);
            this.chartNhiet.Size = new System.Drawing.Size(733, 438);
            this.chartNhiet.TabIndex = 10;
            this.chartNhiet.Text = "chart1";
            this.chartNhiet.Click += new System.EventHandler(this.chartNhiet_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRung,
            this.colNhiet,
            this.colAm,
            this.Time});
            this.listView1.Location = new System.Drawing.Point(775, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(314, 438);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colRung
            // 
            this.colRung.Text = "Rung";
            this.colRung.Width = 55;
            // 
            // colNhiet
            // 
            this.colNhiet.Text = "Nhiet";
            this.colNhiet.Width = 57;
            // 
            // colAm
            // 
            this.colAm.Text = "Do am";
            this.colAm.Width = 59;
            // 
            // baudrate
            // 
            this.baudrate.AutoSize = true;
            this.baudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudrate.Location = new System.Drawing.Point(24, 68);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(77, 18);
            this.baudrate.TabIndex = 8;
            this.baudrate.Text = "Baud Rate";
            this.baudrate.Click += new System.EventHandler(this.baudrate_Click);
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(132, 67);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(152, 24);
            this.cbBaudrate.TabIndex = 2;
            this.cbBaudrate.TabStop = false;
            this.cbBaudrate.SelectedIndexChanged += new System.EventHandler(this.cbBaudrate_SelectedIndexChanged);
            // 
            // btnConnected
            // 
            this.btnConnected.Location = new System.Drawing.Point(318, 32);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(88, 59);
            this.btnConnected.TabIndex = 3;
            this.btnConnected.Text = "Connect";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // cbtTenCongCom
            // 
            this.cbtTenCongCom.FormattingEnabled = true;
            this.cbtTenCongCom.Location = new System.Drawing.Point(132, 32);
            this.cbtTenCongCom.Name = "cbtTenCongCom";
            this.cbtTenCongCom.Size = new System.Drawing.Size(152, 24);
            this.cbtTenCongCom.TabIndex = 0;
            this.cbtTenCongCom.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connect to Port";
            this.label1.UseMnemonic = false;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 126;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(433, 32);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(95, 59);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 600);
            this.Controls.Add(this.formConnect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hiển thị dữ liệu đọc từ thiết bị";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FromMain_FormClosing);
            this.Load += new System.EventHandler(this.FromMain_Load);
            this.Shown += new System.EventHandler(this.FromMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FromMain_KeyDown);
            this.formConnect.ResumeLayout(false);
            this.formConnect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartNhiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox formConnect;
        private System.Windows.Forms.ComboBox cbtTenCongCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label baudrate;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colRung;
        private System.Windows.Forms.ColumnHeader colNhiet;
        private System.Windows.Forms.ColumnHeader colAm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNhiet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Button btnExport;
    }
}

