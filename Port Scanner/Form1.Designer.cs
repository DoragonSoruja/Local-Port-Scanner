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
            this.SuspendLayout();
            // 
            // inputIP
            // 
            this.inputIP.Location = new System.Drawing.Point(70, 48);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(189, 20);
            this.inputIP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // newScan
            // 
            this.newScan.Location = new System.Drawing.Point(284, 48);
            this.newScan.Name = "newScan";
            this.newScan.Size = new System.Drawing.Size(66, 20);
            this.newScan.TabIndex = 2;
            this.newScan.Text = "New Scan";
            this.newScan.UseVisualStyleBackColor = true;
            this.newScan.Click += new System.EventHandler(this.newScan_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(28, 104);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(322, 250);
            this.resultBox.TabIndex = 3;
            // 
            // portScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 388);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.newScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputIP);
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
    }
}

