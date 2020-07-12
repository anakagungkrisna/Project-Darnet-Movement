namespace GUI_DMS
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.BtnScanPort = new System.Windows.Forms.Button();
            this.CmbScanPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbBaud = new System.Windows.Forms.ComboBox();
            this.BtnCon = new System.Windows.Forms.Button();
            this.BtnDiscon = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnRead = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxX = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxY = new System.Windows.Forms.TextBox();
            this.txtBoxZ = new System.Windows.Forms.TextBox();
            this.txtBoxAngle = new System.Windows.Forms.TextBox();
            this.txtBoxSetA2 = new System.Windows.Forms.TextBox();
            this.txtBoxa6 = new System.Windows.Forms.TextBox();
            this.txtBoxMirror = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnScanPort
            // 
            this.BtnScanPort.Location = new System.Drawing.Point(32, 28);
            this.BtnScanPort.Name = "BtnScanPort";
            this.BtnScanPort.Size = new System.Drawing.Size(85, 21);
            this.BtnScanPort.TabIndex = 0;
            this.BtnScanPort.Text = "Scan Port";
            this.BtnScanPort.UseVisualStyleBackColor = true;
            this.BtnScanPort.Click += new System.EventHandler(this.BtnScanPort_Click);
            // 
            // CmbScanPort
            // 
            this.CmbScanPort.FormattingEnabled = true;
            this.CmbScanPort.Location = new System.Drawing.Point(123, 28);
            this.CmbScanPort.Name = "CmbScanPort";
            this.CmbScanPort.Size = new System.Drawing.Size(90, 21);
            this.CmbScanPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baud Rate";
            // 
            // CmbBaud
            // 
            this.CmbBaud.FormattingEnabled = true;
            this.CmbBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.CmbBaud.Location = new System.Drawing.Point(300, 28);
            this.CmbBaud.Name = "CmbBaud";
            this.CmbBaud.Size = new System.Drawing.Size(81, 21);
            this.CmbBaud.TabIndex = 3;
            // 
            // BtnCon
            // 
            this.BtnCon.Location = new System.Drawing.Point(32, 56);
            this.BtnCon.Name = "BtnCon";
            this.BtnCon.Size = new System.Drawing.Size(79, 23);
            this.BtnCon.TabIndex = 4;
            this.BtnCon.Text = "Connect";
            this.BtnCon.UseVisualStyleBackColor = true;
            this.BtnCon.Click += new System.EventHandler(this.BtnCon_Click);
            // 
            // BtnDiscon
            // 
            this.BtnDiscon.Enabled = false;
            this.BtnDiscon.Location = new System.Drawing.Point(32, 85);
            this.BtnDiscon.Name = "BtnDiscon";
            this.BtnDiscon.Size = new System.Drawing.Size(79, 23);
            this.BtnDiscon.TabIndex = 5;
            this.BtnDiscon.Text = "Disconnect";
            this.BtnDiscon.UseVisualStyleBackColor = true;
            this.BtnDiscon.Click += new System.EventHandler(this.BtnDiscon_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(264, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 201);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Received Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Mirror";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(354, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "a[6]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "SetA2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Angle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            // 
            // BtnRead
            // 
            this.BtnRead.Enabled = false;
            this.BtnRead.Location = new System.Drawing.Point(143, 309);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(79, 21);
            this.BtnRead.TabIndex = 1;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(20, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(412, 157);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(299, 58);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(81, 20);
            this.progressBar1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "X        : maju mundur";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "mirror  :1 left, 0 kanan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Z        : kiri kanan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Angle : rotasi kaki";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "setA2 : kemiringan (tilt)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "a[6]    : jenis kaki";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Y        : atas bawah";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(123, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 158);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keterangan";
            // 
            // txtBoxX
            // 
            this.txtBoxX.Location = new System.Drawing.Point(36, 36);
            this.txtBoxX.Name = "txtBoxX";
            this.txtBoxX.Size = new System.Drawing.Size(56, 20);
            this.txtBoxX.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxMirror);
            this.groupBox3.Controls.Add(this.txtBoxa6);
            this.groupBox3.Controls.Add(this.txtBoxSetA2);
            this.groupBox3.Controls.Add(this.txtBoxAngle);
            this.groupBox3.Controls.Add(this.txtBoxZ);
            this.groupBox3.Controls.Add(this.txtBoxY);
            this.groupBox3.Controls.Add(this.btnSend);
            this.groupBox3.Controls.Add(this.txtBoxX);
            this.groupBox3.Location = new System.Drawing.Point(264, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 105);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Data";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(35, 80);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(56, 19);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxY
            // 
            this.txtBoxY.Location = new System.Drawing.Point(97, 36);
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.Size = new System.Drawing.Size(56, 20);
            this.txtBoxY.TabIndex = 15;
            // 
            // txtBoxZ
            // 
            this.txtBoxZ.Location = new System.Drawing.Point(159, 36);
            this.txtBoxZ.Name = "txtBoxZ";
            this.txtBoxZ.Size = new System.Drawing.Size(56, 20);
            this.txtBoxZ.TabIndex = 15;
            // 
            // txtBoxAngle
            // 
            this.txtBoxAngle.Location = new System.Drawing.Point(221, 36);
            this.txtBoxAngle.Name = "txtBoxAngle";
            this.txtBoxAngle.Size = new System.Drawing.Size(56, 20);
            this.txtBoxAngle.TabIndex = 16;
            // 
            // txtBoxSetA2
            // 
            this.txtBoxSetA2.Location = new System.Drawing.Point(281, 36);
            this.txtBoxSetA2.Name = "txtBoxSetA2";
            this.txtBoxSetA2.Size = new System.Drawing.Size(56, 20);
            this.txtBoxSetA2.TabIndex = 17;
            // 
            // txtBoxa6
            // 
            this.txtBoxa6.Location = new System.Drawing.Point(343, 36);
            this.txtBoxa6.Name = "txtBoxa6";
            this.txtBoxa6.Size = new System.Drawing.Size(56, 20);
            this.txtBoxa6.TabIndex = 18;
            // 
            // txtBoxMirror
            // 
            this.txtBoxMirror.Location = new System.Drawing.Point(405, 36);
            this.txtBoxMirror.Name = "txtBoxMirror";
            this.txtBoxMirror.Size = new System.Drawing.Size(27, 20);
            this.txtBoxMirror.TabIndex = 15;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(778, 408);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCon);
            this.Controls.Add(this.CmbBaud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbScanPort);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnScanPort);
            this.Controls.Add(this.BtnDiscon);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form4";
            this.Text = "Serial Connection";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnScanPort;
        private System.Windows.Forms.ComboBox CmbScanPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbBaud;
        private System.Windows.Forms.Button BtnCon;
        private System.Windows.Forms.Button BtnDiscon;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBoxMirror;
        private System.Windows.Forms.TextBox txtBoxa6;
        private System.Windows.Forms.TextBox txtBoxSetA2;
        private System.Windows.Forms.TextBox txtBoxAngle;
        private System.Windows.Forms.TextBox txtBoxZ;
        private System.Windows.Forms.TextBox txtBoxY;
    }
}