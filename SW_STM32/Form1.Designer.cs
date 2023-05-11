namespace SW_STM32
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tBoxData = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBoxSend_2 = new System.Windows.Forms.TextBox();
            this.tBoxSend_1 = new System.Windows.Forms.TextBox();
            this.btnSend_2 = new System.Windows.Forms.Button();
            this.btnSend_1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cBoxMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxHandShake = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxDataSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSTT = new System.Windows.Forms.Button();
            this.btnMOV = new System.Windows.Forms.Button();
            this.btnVEL = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.StatusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.tBoxData);
            this.groupBox1.Location = new System.Drawing.Point(8, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receive Data";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(467, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 59);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tBoxData
            // 
            this.tBoxData.Location = new System.Drawing.Point(6, 21);
            this.tBoxData.Multiline = true;
            this.tBoxData.Name = "tBoxData";
            this.tBoxData.ReadOnly = true;
            this.tBoxData.Size = new System.Drawing.Size(455, 252);
            this.tBoxData.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBoxSend_2);
            this.groupBox2.Controls.Add(this.tBoxSend_1);
            this.groupBox2.Controls.Add(this.btnSend_2);
            this.groupBox2.Controls.Add(this.btnSend_1);
            this.groupBox2.Location = new System.Drawing.Point(28, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 129);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Data";
            // 
            // tBoxSend_2
            // 
            this.tBoxSend_2.Location = new System.Drawing.Point(6, 85);
            this.tBoxSend_2.Name = "tBoxSend_2";
            this.tBoxSend_2.Size = new System.Drawing.Size(100, 22);
            this.tBoxSend_2.TabIndex = 0;
            // 
            // tBoxSend_1
            // 
            this.tBoxSend_1.Location = new System.Drawing.Point(6, 37);
            this.tBoxSend_1.Name = "tBoxSend_1";
            this.tBoxSend_1.Size = new System.Drawing.Size(100, 22);
            this.tBoxSend_1.TabIndex = 0;
            // 
            // btnSend_2
            // 
            this.btnSend_2.Location = new System.Drawing.Point(151, 85);
            this.btnSend_2.Name = "btnSend_2";
            this.btnSend_2.Size = new System.Drawing.Size(75, 23);
            this.btnSend_2.TabIndex = 5;
            this.btnSend_2.Text = "Send";
            this.btnSend_2.UseVisualStyleBackColor = true;
            this.btnSend_2.Click += new System.EventHandler(this.btnSend_2_Click);
            // 
            // btnSend_1
            // 
            this.btnSend_1.Location = new System.Drawing.Point(151, 36);
            this.btnSend_1.Name = "btnSend_1";
            this.btnSend_1.Size = new System.Drawing.Size(75, 23);
            this.btnSend_1.TabIndex = 5;
            this.btnSend_1.Text = "Send";
            this.btnSend_1.UseVisualStyleBackColor = true;
            this.btnSend_1.Click += new System.EventHandler(this.btnSend_1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Controls.Add(this.cBoxMode);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cBoxHandShake);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cBoxParity);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cBoxDataSize);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cBoxBaudRate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cBoxName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Location = new System.Drawing.Point(633, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 504);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serial";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(80, 250);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(165, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(196, 400);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 32);
            this.textBox6.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(196, 352);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 32);
            this.textBox5.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(196, 296);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 32);
            this.textBox4.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(170, 220);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(36, 220);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cBoxMode
            // 
            this.cBoxMode.FormattingEnabled = true;
            this.cBoxMode.Location = new System.Drawing.Point(170, 177);
            this.cBoxMode.Name = "cBoxMode";
            this.cBoxMode.Size = new System.Drawing.Size(121, 24);
            this.cBoxMode.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mode";
            // 
            // cBoxHandShake
            // 
            this.cBoxHandShake.FormattingEnabled = true;
            this.cBoxHandShake.Location = new System.Drawing.Point(170, 147);
            this.cBoxHandShake.Name = "cBoxHandShake";
            this.cBoxHandShake.Size = new System.Drawing.Size(121, 24);
            this.cBoxHandShake.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "HandShake";
            // 
            // cBoxParity
            // 
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParity.Location = new System.Drawing.Point(170, 117);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(121, 24);
            this.cBoxParity.TabIndex = 4;
            this.cBoxParity.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parity";
            // 
            // cBoxDataSize
            // 
            this.cBoxDataSize.FormattingEnabled = true;
            this.cBoxDataSize.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataSize.Location = new System.Drawing.Point(170, 87);
            this.cBoxDataSize.Name = "cBoxDataSize";
            this.cBoxDataSize.Size = new System.Drawing.Size(121, 24);
            this.cBoxDataSize.TabIndex = 4;
            this.cBoxDataSize.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "DataSize";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "14400",
            "19200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(170, 57);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cBoxBaudRate.TabIndex = 4;
            this.cBoxBaudRate.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "BaudRate";
            // 
            // cBoxName
            // 
            this.cBoxName.FormattingEnabled = true;
            this.cBoxName.Location = new System.Drawing.Point(170, 27);
            this.cBoxName.Name = "cBoxName";
            this.cBoxName.Size = new System.Drawing.Size(121, 24);
            this.cBoxName.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(146, 400);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "STT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "VEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "POS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox4);
            this.groupBox5.Controls.Add(this.checkBox3);
            this.groupBox5.Controls.Add(this.checkBox2);
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Location = new System.Drawing.Point(17, 296);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(123, 131);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Static";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 104);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(76, 21);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "GPIO 2";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 78);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 21);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "Led 2";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 52);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 21);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "GPIO 1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Led 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSTT);
            this.groupBox4.Controls.Add(this.btnMOV);
            this.groupBox4.Controls.Add(this.btnVEL);
            this.groupBox4.Controls.Add(this.btnPOS);
            this.groupBox4.Location = new System.Drawing.Point(337, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(233, 148);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Static";
            // 
            // btnSTT
            // 
            this.btnSTT.Location = new System.Drawing.Point(18, 84);
            this.btnSTT.Name = "btnSTT";
            this.btnSTT.Size = new System.Drawing.Size(75, 23);
            this.btnSTT.TabIndex = 5;
            this.btnSTT.Text = "STT";
            this.btnSTT.UseVisualStyleBackColor = true;
            this.btnSTT.Click += new System.EventHandler(this.btnSTT_Click);
            // 
            // btnMOV
            // 
            this.btnMOV.Location = new System.Drawing.Point(129, 84);
            this.btnMOV.Name = "btnMOV";
            this.btnMOV.Size = new System.Drawing.Size(75, 23);
            this.btnMOV.TabIndex = 5;
            this.btnMOV.Text = "MOV";
            this.btnMOV.UseVisualStyleBackColor = true;
            this.btnMOV.Click += new System.EventHandler(this.btnMOV_Click);
            // 
            // btnVEL
            // 
            this.btnVEL.Location = new System.Drawing.Point(129, 35);
            this.btnVEL.Name = "btnVEL";
            this.btnVEL.Size = new System.Drawing.Size(75, 23);
            this.btnVEL.TabIndex = 5;
            this.btnVEL.Text = "VEL";
            this.btnVEL.UseVisualStyleBackColor = true;
            this.btnVEL.Click += new System.EventHandler(this.btnVEL_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(18, 35);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(75, 23);
            this.btnPOS.TabIndex = 5;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(657, 532);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Time";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(793, 533);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Event";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(12, 570);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            this.StatusLabel.TabIndex = 4;
            this.StatusLabel.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 621);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBoxData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cBoxMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxHandShake;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBoxDataSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tBoxSend_2;
        private System.Windows.Forms.TextBox tBoxSend_1;
        private System.Windows.Forms.Button btnSend_2;
        private System.Windows.Forms.Button btnSend_1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnSTT;
        private System.Windows.Forms.Button btnMOV;
        private System.Windows.Forms.Button btnVEL;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label StatusLabel;
    }
}

