namespace ArduinoCsharp
{
    partial class FrmArduino
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
            btnON = new Button();
            btnOFF = new Button();
            txtData = new TextBox();
            SuspendLayout();
            // 
            // btnON
            // 
            btnON.Location = new Point(141, 111);
            btnON.Name = "btnON";
            btnON.Size = new Size(75, 23);
            btnON.TabIndex = 0;
            btnON.Text = "ON";
            btnON.UseVisualStyleBackColor = true;
            btnON.Click += btnON_Click;
            // 
            // btnOFF
            // 
            btnOFF.Location = new Point(255, 111);
            btnOFF.Name = "btnOFF";
            btnOFF.Size = new Size(75, 23);
            btnOFF.TabIndex = 1;
            btnOFF.Text = "OFF";
            btnOFF.UseVisualStyleBackColor = true;
            btnOFF.Click += btnOFF_Click;
            // 
            // txtData
            // 
            txtData.Location = new Point(141, 47);
            txtData.Name = "txtData";
            txtData.Size = new Size(189, 23);
            txtData.TabIndex = 2;
            // 
            // FrmArduino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtData);
            Controls.Add(btnOFF);
            Controls.Add(btnON);
            Name = "FrmArduino";
            Text = "FrmArduino";
            FormClosing += FrmArduino_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnON;
        private Button btnOFF;
        private TextBox txtData;
    }
}