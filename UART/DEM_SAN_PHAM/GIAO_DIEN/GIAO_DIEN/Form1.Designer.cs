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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.soLuong = new System.Windows.Forms.NumericUpDown();
            this.soThung = new System.Windows.Forms.NumericUpDown();
            this.thung = new System.Windows.Forms.Label();
            this.soCD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soThung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soCD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐẾM SẢN PHẨM";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 30);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Disconnect);
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 162);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComPorts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "COM";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(105, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Disconnect!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_Connect
            // 
            this.button_Connect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Connect.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_Connect.Location = new System.Drawing.Point(32, 108);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(121, 31);
            this.button_Connect.TabIndex = 5;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Disconnect.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button_Disconnect.Location = new System.Drawing.Point(179, 108);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(117, 31);
            this.button_Disconnect.TabIndex = 6;
            this.button_Disconnect.Text = "Disconnect";
            this.button_Disconnect.UseVisualStyleBackColor = true;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.send);
            this.groupBox2.Controls.Add(this.soCD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.soThung);
            this.groupBox2.Controls.Add(this.thung);
            this.groupBox2.Controls.Add(this.soLuong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(368, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 162);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infor";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(18, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng";
            // 
            // soLuong
            // 
            this.soLuong.Location = new System.Drawing.Point(118, 29);
            this.soLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(78, 30);
            this.soLuong.TabIndex = 1;
            this.soLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // soThung
            // 
            this.soThung.Location = new System.Drawing.Point(118, 69);
            this.soThung.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.soThung.Name = "soThung";
            this.soThung.Size = new System.Drawing.Size(78, 30);
            this.soThung.TabIndex = 3;
            this.soThung.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // thung
            // 
            this.thung.AutoSize = true;
            this.thung.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.thung.Location = new System.Drawing.Point(18, 69);
            this.thung.Name = "thung";
            this.thung.Size = new System.Drawing.Size(85, 22);
            this.thung.TabIndex = 2;
            this.thung.Text = "Số Thùng";
            // 
            // soCD
            // 
            this.soCD.Location = new System.Drawing.Point(121, 112);
            this.soCD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.soCD.Name = "soCD";
            this.soCD.Size = new System.Drawing.Size(78, 30);
            this.soCD.TabIndex = 5;
            this.soCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(21, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng";
            // 
            // send
            // 
            this.send.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.send.Location = new System.Drawing.Point(216, 107);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(81, 37);
            this.send.TabIndex = 6;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 247);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "Form1";
            this.Text = "GIAO DIỆN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soThung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.NumericUpDown soCD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown soThung;
        private System.Windows.Forms.Label thung;
        private System.Windows.Forms.NumericUpDown soLuong;
        private System.Windows.Forms.Label label3;
    }
}

