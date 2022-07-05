namespace GIAO_DIEN
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
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.comboBaund = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Disconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.send2 = new System.Windows.Forms.Button();
            this.send1 = new System.Windows.Forms.Button();
            this.textBoxCC2 = new System.Windows.Forms.TextBox();
            this.textBoxCC1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxC2 = new System.Windows.Forms.TextBox();
            this.textBoxC1 = new System.Windows.Forms.TextBox();
            this.textBoxDA = new System.Windows.Forms.TextBox();
            this.textBoxND = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Quatoff = new System.Windows.Forms.Button();
            this.Quaton = new System.Windows.Forms.Button();
            this.Ledon = new System.Windows.Forms.Button();
            this.Ledoff = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(134, 23);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(251, 30);
            this.comboPort.TabIndex = 0;
            this.comboPort.SelectedIndexChanged += new System.EventHandler(this.comboPort_SelectedIndexChanged);
            // 
            // comboBaund
            // 
            this.comboBaund.FormattingEnabled = true;
            this.comboBaund.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBaund.Location = new System.Drawing.Point(134, 68);
            this.comboBaund.Name = "comboBaund";
            this.comboBaund.Size = new System.Drawing.Size(251, 30);
            this.comboBaund.TabIndex = 2;
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.Location = new System.Drawing.Point(134, 167);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(117, 33);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "PORT COM:";
            // 
            // Disconnect
            // 
            this.Disconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disconnect.Location = new System.Drawing.Point(267, 167);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(118, 33);
            this.Disconnect.TabIndex = 6;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baundrate: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Disconnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboPort);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.comboBaund);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 206);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup Connect";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(196, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 30);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Disconnect!";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(316, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "ĐIỀU KHIỂN THIẾT BỊ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(422, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(539, 22);
            this.textBox1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.send2);
            this.groupBox2.Controls.Add(this.send1);
            this.groupBox2.Controls.Add(this.textBoxCC2);
            this.groupBox2.Controls.Add(this.textBoxCC1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxC2);
            this.groupBox2.Controls.Add(this.textBoxC1);
            this.groupBox2.Controls.Add(this.textBoxDA);
            this.groupBox2.Controls.Add(this.textBoxND);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(422, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 226);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infor";
            // 
            // send2
            // 
            this.send2.Location = new System.Drawing.Point(393, 183);
            this.send2.Name = "send2";
            this.send2.Size = new System.Drawing.Size(104, 30);
            this.send2.TabIndex = 24;
            this.send2.Text = "Send";
            this.send2.UseVisualStyleBackColor = true;
            this.send2.Click += new System.EventHandler(this.send2_Click);
            // 
            // send1
            // 
            this.send1.Location = new System.Drawing.Point(393, 80);
            this.send1.Name = "send1";
            this.send1.Size = new System.Drawing.Size(104, 30);
            this.send1.TabIndex = 23;
            this.send1.Text = "Send";
            this.send1.UseVisualStyleBackColor = true;
            this.send1.Click += new System.EventHandler(this.send1_Click);
            // 
            // textBoxCC2
            // 
            this.textBoxCC2.Location = new System.Drawing.Point(393, 130);
            this.textBoxCC2.Name = "textBoxCC2";
            this.textBoxCC2.Size = new System.Drawing.Size(142, 30);
            this.textBoxCC2.TabIndex = 22;
            this.textBoxCC2.Text = "0";
            // 
            // textBoxCC1
            // 
            this.textBoxCC1.Location = new System.Drawing.Point(393, 26);
            this.textBoxCC1.Name = "textBoxCC1";
            this.textBoxCC1.Size = new System.Drawing.Size(142, 30);
            this.textBoxCC1.TabIndex = 21;
            this.textBoxCC1.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(310, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 20;
            this.label9.Text = "Cài C2: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cài C1: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxC2
            // 
            this.textBoxC2.Location = new System.Drawing.Point(139, 183);
            this.textBoxC2.Multiline = true;
            this.textBoxC2.Name = "textBoxC2";
            this.textBoxC2.Size = new System.Drawing.Size(142, 30);
            this.textBoxC2.TabIndex = 18;
            this.textBoxC2.Text = "0";
            // 
            // textBoxC1
            // 
            this.textBoxC1.Location = new System.Drawing.Point(139, 130);
            this.textBoxC1.Multiline = true;
            this.textBoxC1.Name = "textBoxC1";
            this.textBoxC1.Size = new System.Drawing.Size(142, 30);
            this.textBoxC1.TabIndex = 17;
            this.textBoxC1.Text = "0";
            // 
            // textBoxDA
            // 
            this.textBoxDA.Location = new System.Drawing.Point(139, 80);
            this.textBoxDA.Multiline = true;
            this.textBoxDA.Name = "textBoxDA";
            this.textBoxDA.Size = new System.Drawing.Size(142, 30);
            this.textBoxDA.TabIndex = 16;
            this.textBoxDA.Text = "0";
            // 
            // textBoxND
            // 
            this.textBoxND.Location = new System.Drawing.Point(139, 31);
            this.textBoxND.Multiline = true;
            this.textBoxND.Name = "textBoxND";
            this.textBoxND.Size = new System.Drawing.Size(142, 30);
            this.textBoxND.TabIndex = 15;
            this.textBoxND.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "C2          : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "C1          : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Độ ẩm    :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nhiệt  độ: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Ledoff);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.Quatoff);
            this.groupBox3.Controls.Add(this.Quaton);
            this.groupBox3.Controls.Add(this.Ledon);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 291);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // Quatoff
            // 
            this.Quatoff.Location = new System.Drawing.Point(208, 226);
            this.Quatoff.Name = "Quatoff";
            this.Quatoff.Size = new System.Drawing.Size(107, 31);
            this.Quatoff.TabIndex = 5;
            this.Quatoff.Text = "OFF";
            this.Quatoff.UseVisualStyleBackColor = true;
            this.Quatoff.Click += new System.EventHandler(this.Quatoff_Click);
            // 
            // Quaton
            // 
            this.Quaton.Location = new System.Drawing.Point(208, 179);
            this.Quaton.Name = "Quaton";
            this.Quaton.Size = new System.Drawing.Size(107, 31);
            this.Quaton.TabIndex = 4;
            this.Quaton.Text = "ON";
            this.Quaton.UseVisualStyleBackColor = true;
            this.Quaton.Click += new System.EventHandler(this.Quaton_Click);
            // 
            // Ledon
            // 
            this.Ledon.Location = new System.Drawing.Point(208, 43);
            this.Ledon.Name = "Ledon";
            this.Ledon.Size = new System.Drawing.Size(107, 31);
            this.Ledon.TabIndex = 2;
            this.Ledon.Text = "ON";
            this.Ledon.UseVisualStyleBackColor = true;
            this.Ledon.Click += new System.EventHandler(this.Ledon_Click);
            // 
            // Ledoff
            // 
            this.Ledoff.Location = new System.Drawing.Point(208, 104);
            this.Ledoff.Name = "Ledoff";
            this.Ledoff.Size = new System.Drawing.Size(107, 33);
            this.Ledoff.TabIndex = 15;
            this.Ledoff.Text = "OFF";
            this.Ledoff.UseVisualStyleBackColor = true;
            this.Ledoff.Click += new System.EventHandler(this.Ledoff_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GIAO_DIEN.Properties.Resources.QON;
            this.pictureBox4.Location = new System.Drawing.Point(20, 158);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(116, 108);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::GIAO_DIEN.Properties.Resources.ON1;
            this.pictureBox3.Location = new System.Drawing.Point(20, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GIAO_DIEN.Properties.Resources.QON1;
            this.pictureBox2.Location = new System.Drawing.Point(20, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::GIAO_DIEN.Properties.Resources.ON;
            this.pictureBox1.Location = new System.Drawing.Point(20, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "GIAO DIỆN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.ComboBox comboBaund;
        private System.Windows.Forms.Button Connect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxC2;
        private System.Windows.Forms.TextBox textBoxC1;
        private System.Windows.Forms.TextBox textBoxDA;
        private System.Windows.Forms.TextBox textBoxND;
        private System.Windows.Forms.Button send2;
        private System.Windows.Forms.Button send1;
        private System.Windows.Forms.TextBox textBoxCC2;
        private System.Windows.Forms.TextBox textBoxCC1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Quaton;
        private System.Windows.Forms.Button Ledon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Quatoff;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Ledoff;
    }
}

