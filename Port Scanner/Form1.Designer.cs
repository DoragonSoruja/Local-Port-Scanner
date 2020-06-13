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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(portScanner));
            this.inputIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newScan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.port1 = new System.Windows.Forms.TextBox();
            this.port2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.singlePorting = new System.Windows.Forms.CheckBox();
            this.scanProgress = new System.Windows.Forms.ProgressBar();
            this.portList = new System.Windows.Forms.ListView();
            this.port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // inputIP
            // 
            this.inputIP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.inputIP.Location = new System.Drawing.Point(58, 31);
            this.inputIP.Name = "inputIP";
            this.inputIP.Size = new System.Drawing.Size(213, 20);
            this.inputIP.TabIndex = 0;
            this.inputIP.Text = "Ex: 192.168.1.1";
            this.inputIP.Enter += new System.EventHandler(this.inputIP_Enter);
            this.inputIP.Leave += new System.EventHandler(this.inputIP_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // newScan
            // 
            this.newScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newScan.Location = new System.Drawing.Point(277, 29);
            this.newScan.Name = "newScan";
            this.newScan.Size = new System.Drawing.Size(66, 27);
            this.newScan.TabIndex = 2;
            this.newScan.Text = "Scan";
            this.newScan.UseVisualStyleBackColor = true;
            this.newScan.Click += new System.EventHandler(this.portScan);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ports";
            // 
            // port1
            // 
            this.port1.Location = new System.Drawing.Point(80, 61);
            this.port1.MaxLength = 5;
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(44, 20);
            this.port1.TabIndex = 5;
            // 
            // port2
            // 
            this.port2.Location = new System.Drawing.Point(155, 61);
            this.port2.MaxLength = 5;
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(44, 20);
            this.port2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "to";
            // 
            // singlePorting
            // 
            this.singlePorting.AutoSize = true;
            this.singlePorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePorting.Location = new System.Drawing.Point(32, 90);
            this.singlePorting.Name = "singlePorting";
            this.singlePorting.Size = new System.Drawing.Size(125, 17);
            this.singlePorting.TabIndex = 8;
            this.singlePorting.Text = "Single Port Scanning";
            this.singlePorting.UseVisualStyleBackColor = true;
            this.singlePorting.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // scanProgress
            // 
            this.scanProgress.Location = new System.Drawing.Point(-4, 444);
            this.scanProgress.Name = "scanProgress";
            this.scanProgress.Size = new System.Drawing.Size(378, 23);
            this.scanProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.scanProgress.TabIndex = 9;
            this.scanProgress.Visible = false;
            // 
            // portList
            // 
            this.portList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.port,
            this.status});
            this.portList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portList.HideSelection = false;
            this.portList.Location = new System.Drawing.Point(32, 113);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(311, 282);
            this.portList.TabIndex = 10;
            this.portList.UseCompatibleStateImageBehavior = false;
            this.portList.View = System.Windows.Forms.View.Details;
            // 
            // port
            // 
            this.port.Text = "Port";
            this.port.Width = 128;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 127;
            // 
            // portScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 461);
            this.Controls.Add(this.portList);
            this.Controls.Add(this.scanProgress);
            this.Controls.Add(this.singlePorting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.port2);
            this.Controls.Add(this.port1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newScan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox port1;
        private System.Windows.Forms.TextBox port2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox singlePorting;
        private System.Windows.Forms.ProgressBar scanProgress;
        private System.Windows.Forms.ListView portList;
        private System.Windows.Forms.ColumnHeader port;
        private System.Windows.Forms.ColumnHeader status;
    }
}

