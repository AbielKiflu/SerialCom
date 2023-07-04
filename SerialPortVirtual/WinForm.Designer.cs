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
            PnlPort.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPorts
            // 
            cmbPorts.FormattingEnabled = true;
            cmbPorts.Location = new Point(67, 39);
            cmbPorts.Name = "cmbPorts";
            cmbPorts.Size = new Size(121, 23);
            cmbPorts.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Ports";
            // 
            // PnlPort
            // 
            PnlPort.BackColor = Color.WhiteSmoke;
            PnlPort.BorderStyle = BorderStyle.FixedSingle;
            PnlPort.Controls.Add(cmbPorts);
            PnlPort.Controls.Add(label1);
            PnlPort.Location = new Point(12, 12);
            PnlPort.Name = "PnlPort";
            PnlPort.Size = new Size(318, 179);
            PnlPort.TabIndex = 2;
            // 
            // WinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}