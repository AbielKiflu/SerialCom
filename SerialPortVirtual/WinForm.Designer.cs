namespace SerialPortVirtual
{
    partial class WinForm
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
            cmbPorts = new ComboBox();
            label1 = new Label();
            PnlPort = new Panel();
            btnSavePortConf = new Button();
            label5 = new Label();
            txtStopBits = new TextBox();
            label4 = new Label();
            txtDataBits = new TextBox();
            label3 = new Label();
            txtParity = new TextBox();
            label2 = new Label();
            txtBaudRate = new TextBox();
            btnLoadStl = new Button();
            PnlPort.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPorts
            // 
            cmbPorts.FormattingEnabled = true;
            cmbPorts.Location = new Point(93, 12);
            cmbPorts.Name = "cmbPorts";
            cmbPorts.Size = new Size(172, 23);
            cmbPorts.TabIndex = 0;
            cmbPorts.SelectedIndexChanged += cmbPorts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 20);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Ports";
            // 
            // PnlPort
            // 
            PnlPort.BackColor = Color.WhiteSmoke;
            PnlPort.BorderStyle = BorderStyle.FixedSingle;
            PnlPort.Controls.Add(btnSavePortConf);
            PnlPort.Controls.Add(label5);
            PnlPort.Controls.Add(txtStopBits);
            PnlPort.Controls.Add(label4);
            PnlPort.Controls.Add(txtDataBits);
            PnlPort.Controls.Add(label3);
            PnlPort.Controls.Add(txtParity);
            PnlPort.Controls.Add(label2);
            PnlPort.Controls.Add(txtBaudRate);
            PnlPort.Controls.Add(cmbPorts);
            PnlPort.Controls.Add(label1);
            PnlPort.Location = new Point(12, 12);
            PnlPort.Name = "PnlPort";
            PnlPort.Size = new Size(318, 227);
            PnlPort.TabIndex = 2;
            // 
            // btnSavePortConf
            // 
            btnSavePortConf.Location = new Point(224, 185);
            btnSavePortConf.Name = "btnSavePortConf";
            btnSavePortConf.Size = new Size(75, 23);
            btnSavePortConf.TabIndex = 5;
            btnSavePortConf.Text = "Update";
            btnSavePortConf.UseVisualStyleBackColor = true;
            btnSavePortConf.Click += btnSavePortConf_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 139);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 9;
            label5.Text = "StopBits ";
            // 
            // txtStopBits
            // 
            txtStopBits.Location = new Point(93, 131);
            txtStopBits.Name = "txtStopBits";
            txtStopBits.Size = new Size(172, 23);
            txtStopBits.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 110);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "DataBits ";
            // 
            // txtDataBits
            // 
            txtDataBits.Location = new Point(93, 102);
            txtDataBits.Name = "txtDataBits";
            txtDataBits.Size = new Size(172, 23);
            txtDataBits.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 81);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Parity ";
            // 
            // txtParity
            // 
            txtParity.Location = new Point(93, 73);
            txtParity.Name = "txtParity";
            txtParity.Size = new Size(172, 23);
            txtParity.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "BaudRate ";
            // 
            // txtBaudRate
            // 
            txtBaudRate.Location = new Point(93, 44);
            txtBaudRate.Name = "txtBaudRate";
            txtBaudRate.Size = new Size(172, 23);
            txtBaudRate.TabIndex = 2;
            // 
            // btnLoadStl
            // 
            btnLoadStl.Location = new Point(17, 390);
            btnLoadStl.Name = "btnLoadStl";
            btnLoadStl.Size = new Size(75, 23);
            btnLoadStl.TabIndex = 4;
            btnLoadStl.Text = "Load STL";
            btnLoadStl.UseVisualStyleBackColor = true;
            // 
            // WinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 631);
            Controls.Add(btnLoadStl);
            Controls.Add(PnlPort);
            Name = "WinForm";
            Text = "WinForm";
            Load += WinForm_Load;
            PnlPort.ResumeLayout(false);
            PnlPort.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPorts;
        private Label label1;
        private Panel PnlPort;
        private Button btnLoadStl;
        private Label label4;
        private TextBox txtDataBits;
        private Label label3;
        private TextBox txtParity;
        private Label label2;
        private TextBox txtBaudRate;
        private Label label5;
        private TextBox txtStopBits;
        private Button btnSavePortConf;
    }
}