namespace BB
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTenCom = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.btnBat1 = new System.Windows.Forms.Button();
            this.btnTat1 = new System.Windows.Forms.Button();
            this.btnTat2 = new System.Windows.Forms.Button();
            this.btnBat2 = new System.Windows.Forms.Button();
            this.btnTat3 = new System.Windows.Forms.Button();
            this.btnBat3 = new System.Windows.Forms.Button();
            this.UART = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Com";
            // 
            // cbxTenCom
            // 
            this.cbxTenCom.FormattingEnabled = true;
            this.cbxTenCom.Location = new System.Drawing.Point(163, 43);
            this.cbxTenCom.Name = "cbxTenCom";
            this.cbxTenCom.Size = new System.Drawing.Size(283, 30);
            this.cbxTenCom.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Location = new System.Drawing.Point(163, 88);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(105, 31);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisConnect.Enabled = false;
            this.btnDisConnect.Location = new System.Drawing.Point(297, 88);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(105, 31);
            this.btnDisConnect.TabIndex = 3;
            this.btnDisConnect.Text = "Diconnect";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // btnBat1
            // 
            this.btnBat1.Location = new System.Drawing.Point(525, 88);
            this.btnBat1.Name = "btnBat1";
            this.btnBat1.Size = new System.Drawing.Size(102, 38);
            this.btnBat1.TabIndex = 4;
            this.btnBat1.Text = "Bật 1";
            this.btnBat1.UseVisualStyleBackColor = true;
            this.btnBat1.Click += new System.EventHandler(this.btnBat1_Click);
            // 
            // btnTat1
            // 
            this.btnTat1.Location = new System.Drawing.Point(643, 88);
            this.btnTat1.Name = "btnTat1";
            this.btnTat1.Size = new System.Drawing.Size(102, 38);
            this.btnTat1.TabIndex = 5;
            this.btnTat1.Text = "Tắt 1";
            this.btnTat1.UseVisualStyleBackColor = true;
            this.btnTat1.Click += new System.EventHandler(this.btnTat1_Click);
            // 
            // btnTat2
            // 
            this.btnTat2.Location = new System.Drawing.Point(643, 144);
            this.btnTat2.Name = "btnTat2";
            this.btnTat2.Size = new System.Drawing.Size(102, 38);
            this.btnTat2.TabIndex = 7;
            this.btnTat2.Text = "Tắt 2";
            this.btnTat2.UseVisualStyleBackColor = true;
            this.btnTat2.Click += new System.EventHandler(this.btnTat2_Click);
            // 
            // btnBat2
            // 
            this.btnBat2.Location = new System.Drawing.Point(525, 144);
            this.btnBat2.Name = "btnBat2";
            this.btnBat2.Size = new System.Drawing.Size(102, 38);
            this.btnBat2.TabIndex = 6;
            this.btnBat2.Text = "Bật 2";
            this.btnBat2.UseVisualStyleBackColor = true;
            this.btnBat2.Click += new System.EventHandler(this.btnBat2_Click);
            // 
            // btnTat3
            // 
            this.btnTat3.Location = new System.Drawing.Point(643, 200);
            this.btnTat3.Name = "btnTat3";
            this.btnTat3.Size = new System.Drawing.Size(102, 38);
            this.btnTat3.TabIndex = 9;
            this.btnTat3.Text = "Tắt 3";
            this.btnTat3.UseVisualStyleBackColor = true;
            this.btnTat3.Click += new System.EventHandler(this.btnTat3_Click);
            // 
            // btnBat3
            // 
            this.btnBat3.Location = new System.Drawing.Point(525, 200);
            this.btnBat3.Name = "btnBat3";
            this.btnBat3.Size = new System.Drawing.Size(102, 38);
            this.btnBat3.TabIndex = 8;
            this.btnBat3.Text = "Bật 3";
            this.btnBat3.UseVisualStyleBackColor = true;
            this.btnBat3.Click += new System.EventHandler(this.btnBat3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnTat3);
            this.Controls.Add(this.btnBat3);
            this.Controls.Add(this.btnTat2);
            this.Controls.Add(this.btnBat2);
            this.Controls.Add(this.btnTat1);
            this.Controls.Add(this.btnBat1);
            this.Controls.Add(this.btnDisConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbxTenCom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GIAO TIẾP MÁY TÍNH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTenCom;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Button btnBat1;
        private System.Windows.Forms.Button btnTat1;
        private System.Windows.Forms.Button btnTat2;
        private System.Windows.Forms.Button btnBat2;
        private System.Windows.Forms.Button btnTat3;
        private System.Windows.Forms.Button btnBat3;
        private System.IO.Ports.SerialPort UART;
    }
}

