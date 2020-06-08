namespace Port_Scanner
{
    partial class portScanner
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
            this.inputIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newScan = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.port1 = new System.Windows.Forms.TextBox();
            this.port2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.singlePorting = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(54, 31);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(214, 20);
            this.inputIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // newScan
            // 
            this.newScan.Location = new System.Drawing.Point(284, 31);
            this.newScan.Name = "newScan";
            this.newScan.Size = new System.Drawing.Size(66, 20);
            this.newScan.TabIndex = 2;
            this.newScan.Text = "New Scan";
            this.newScan.UseVisualStyleBackColor = true;
            this.newScan.Click += new System.EventHandler(this.newScan_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(28, 113);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultBox.Size = new System.Drawing.Size(322, 250);
            this.resultBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ports";
            // 
            // port1
            // 
            this.port1.Location = new System.Drawing.Point(76, 61);
            this.port1.MaxLength = 5;
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(44, 20);
            this.port1.TabIndex = 5;
            // 
            // port2
            // 
            this.port2.Location = new System.Drawing.Point(151, 61);
            this.port2.MaxLength = 5;
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(44, 20);
            this.port2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "to";
            // 
            // singlePorting
            // 
            this.singlePorting.AutoSize = true;
            this.singlePorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePorting.Location = new System.Drawing.Point(28, 90);
            this.singlePorting.Name = "singlePorting";
            this.singlePorting.Size = new System.Drawing.Size(125, 17);
            this.singlePorting.TabIndex = 8;
            this.singlePorting.Text = "Single Port Scanning";
            this.singlePorting.UseVisualStyleBackColor = true;
            this.singlePorting.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // portScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 388);
            this.Controls.Add(this.singlePorting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.port2);
            this.Controls.Add(this.port1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.newScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputIP);
            this.MaximizeBox = false;
            this.Name = "portScanner";
            this.Text = "Port Scanner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newScan;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox port1;
        private System.Windows.Forms.TextBox port2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox singlePorting;
    }
}

