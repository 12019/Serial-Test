namespace SerialComms
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
            this.connectbtn = new System.Windows.Forms.Button();
            this.errortext = new System.Windows.Forms.TextBox();
            this.disconnectbtn = new System.Windows.Forms.Button();
            this.serialcombo = new System.Windows.Forms.ComboBox();
            this.nwbutton = new System.Windows.Forms.Button();
            this.nbutton = new System.Windows.Forms.Button();
            this.nebutton = new System.Windows.Forms.Button();
            this.ebutton = new System.Windows.Forms.Button();
            this.wbutton = new System.Windows.Forms.Button();
            this.sebutton = new System.Windows.Forms.Button();
            this.sbutton = new System.Windows.Forms.Button();
            this.swbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connectbtn
            // 
            this.connectbtn.Location = new System.Drawing.Point(165, 23);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(75, 23);
            this.connectbtn.TabIndex = 1;
            this.connectbtn.Text = "Connect";
            this.connectbtn.UseVisualStyleBackColor = true;
            this.connectbtn.Click += new System.EventHandler(this.connectbtn_Click);
            // 
            // errortext
            // 
            this.errortext.Location = new System.Drawing.Point(7, 220);
            this.errortext.Name = "errortext";
            this.errortext.Size = new System.Drawing.Size(269, 20);
            this.errortext.TabIndex = 2;
            // 
            // disconnectbtn
            // 
            this.disconnectbtn.Location = new System.Drawing.Point(165, 53);
            this.disconnectbtn.Name = "disconnectbtn";
            this.disconnectbtn.Size = new System.Drawing.Size(75, 23);
            this.disconnectbtn.TabIndex = 3;
            this.disconnectbtn.Text = "Disconnect";
            this.disconnectbtn.UseVisualStyleBackColor = true;
            this.disconnectbtn.Click += new System.EventHandler(this.disconnectbtn_Click);
            // 
            // serialcombo
            // 
            this.serialcombo.FormattingEnabled = true;
            this.serialcombo.Location = new System.Drawing.Point(38, 23);
            this.serialcombo.Name = "serialcombo";
            this.serialcombo.Size = new System.Drawing.Size(121, 21);
            this.serialcombo.TabIndex = 4;
            // 
            // nwbutton
            // 
            this.nwbutton.Location = new System.Drawing.Point(53, 84);
            this.nwbutton.Name = "nwbutton";
            this.nwbutton.Size = new System.Drawing.Size(50, 38);
            this.nwbutton.TabIndex = 5;
            this.nwbutton.Text = "NW";
            this.nwbutton.UseVisualStyleBackColor = true;
            this.nwbutton.Click += new System.EventHandler(this.nwbutton_Click);
            // 
            // nbutton
            // 
            this.nbutton.Location = new System.Drawing.Point(109, 84);
            this.nbutton.Name = "nbutton";
            this.nbutton.Size = new System.Drawing.Size(50, 38);
            this.nbutton.TabIndex = 6;
            this.nbutton.Text = "N";
            this.nbutton.UseVisualStyleBackColor = true;
            this.nbutton.Click += new System.EventHandler(this.nbutton_Click);
            // 
            // nebutton
            // 
            this.nebutton.Location = new System.Drawing.Point(165, 84);
            this.nebutton.Name = "nebutton";
            this.nebutton.Size = new System.Drawing.Size(50, 38);
            this.nebutton.TabIndex = 7;
            this.nebutton.Text = "NE";
            this.nebutton.UseVisualStyleBackColor = true;
            this.nebutton.Click += new System.EventHandler(this.nebutton_Click);
            // 
            // ebutton
            // 
            this.ebutton.Location = new System.Drawing.Point(164, 128);
            this.ebutton.Name = "ebutton";
            this.ebutton.Size = new System.Drawing.Size(50, 38);
            this.ebutton.TabIndex = 10;
            this.ebutton.Text = "E";
            this.ebutton.UseVisualStyleBackColor = true;
            this.ebutton.Click += new System.EventHandler(this.ebutton_Click);
            // 
            // wbutton
            // 
            this.wbutton.Location = new System.Drawing.Point(52, 128);
            this.wbutton.Name = "wbutton";
            this.wbutton.Size = new System.Drawing.Size(50, 38);
            this.wbutton.TabIndex = 8;
            this.wbutton.Text = "W";
            this.wbutton.UseVisualStyleBackColor = true;
            this.wbutton.Click += new System.EventHandler(this.wbutton_Click);
            // 
            // sebutton
            // 
            this.sebutton.Location = new System.Drawing.Point(164, 172);
            this.sebutton.Name = "sebutton";
            this.sebutton.Size = new System.Drawing.Size(50, 38);
            this.sebutton.TabIndex = 13;
            this.sebutton.Text = "SE";
            this.sebutton.UseVisualStyleBackColor = true;
            this.sebutton.Click += new System.EventHandler(this.sebutton_Click);
            // 
            // sbutton
            // 
            this.sbutton.Location = new System.Drawing.Point(108, 172);
            this.sbutton.Name = "sbutton";
            this.sbutton.Size = new System.Drawing.Size(50, 38);
            this.sbutton.TabIndex = 12;
            this.sbutton.Text = "S";
            this.sbutton.UseVisualStyleBackColor = true;
            this.sbutton.Click += new System.EventHandler(this.sbutton_Click);
            // 
            // swbutton
            // 
            this.swbutton.Location = new System.Drawing.Point(52, 172);
            this.swbutton.Name = "swbutton";
            this.swbutton.Size = new System.Drawing.Size(50, 38);
            this.swbutton.TabIndex = 11;
            this.swbutton.Text = "SW";
            this.swbutton.UseVisualStyleBackColor = true;
            this.swbutton.Click += new System.EventHandler(this.swbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.sebutton);
            this.Controls.Add(this.sbutton);
            this.Controls.Add(this.swbutton);
            this.Controls.Add(this.ebutton);
            this.Controls.Add(this.wbutton);
            this.Controls.Add(this.nebutton);
            this.Controls.Add(this.nbutton);
            this.Controls.Add(this.nwbutton);
            this.Controls.Add(this.serialcombo);
            this.Controls.Add(this.disconnectbtn);
            this.Controls.Add(this.errortext);
            this.Controls.Add(this.connectbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectbtn;
        private System.Windows.Forms.Button disconnectbtn;
        private System.Windows.Forms.Button nwbutton;
        private System.Windows.Forms.Button nbutton;
        private System.Windows.Forms.Button nebutton;
        private System.Windows.Forms.Button ebutton;
        private System.Windows.Forms.Button wbutton;
        private System.Windows.Forms.Button sebutton;
        private System.Windows.Forms.Button sbutton;
        private System.Windows.Forms.Button swbutton;
        internal System.Windows.Forms.ComboBox serialcombo;
        internal System.Windows.Forms.TextBox errortext;
    }
}

