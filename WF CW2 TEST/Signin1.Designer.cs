namespace WF_CW2_TEST
{
    partial class Signin1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin1));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsignin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsigninid = new System.Windows.Forms.TextBox();
            this.txtsinginpassword = new System.Windows.Forms.TextBox();
            this.btnforget = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1290, 678);
            this.pictureBox3.TabIndex = 62;
            this.pictureBox3.TabStop = false;
            // 
            // pbclose
            // 
            this.pbclose.Image = ((System.Drawing.Image)(resources.GetObject("pbclose.Image")));
            this.pbclose.Location = new System.Drawing.Point(1253, 12);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(28, 29);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbclose.TabIndex = 0;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Crimson;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 678);
            this.panel2.TabIndex = 64;
            // 
            // btnsignin
            // 
            this.btnsignin.BackColor = System.Drawing.Color.Crimson;
            this.btnsignin.FlatAppearance.BorderSize = 0;
            this.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignin.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsignin.Location = new System.Drawing.Point(288, 514);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(191, 55);
            this.btnsignin.TabIndex = 63;
            this.btnsignin.Text = " Sign In";
            this.btnsignin.UseVisualStyleBackColor = false;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.pbclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 51);
            this.panel1.TabIndex = 59;
            // 
            // txtsigninid
            // 
            this.txtsigninid.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsigninid.ForeColor = System.Drawing.Color.Gray;
            this.txtsigninid.Location = new System.Drawing.Point(173, 266);
            this.txtsigninid.Name = "txtsigninid";
            this.txtsigninid.Size = new System.Drawing.Size(418, 40);
            this.txtsigninid.TabIndex = 65;
            this.txtsigninid.Text = "     ID";
            this.txtsigninid.Enter += new System.EventHandler(this.txtsigninid_Enter);
            this.txtsigninid.Leave += new System.EventHandler(this.txtsigninid_Leave);
            // 
            // txtsinginpassword
            // 
            this.txtsinginpassword.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsinginpassword.ForeColor = System.Drawing.Color.Gray;
            this.txtsinginpassword.Location = new System.Drawing.Point(173, 367);
            this.txtsinginpassword.Name = "txtsinginpassword";
            this.txtsinginpassword.Size = new System.Drawing.Size(418, 40);
            this.txtsinginpassword.TabIndex = 66;
            this.txtsinginpassword.Text = "     Password";
            this.txtsinginpassword.Enter += new System.EventHandler(this.txtsinginpassword_Enter);
            this.txtsinginpassword.Leave += new System.EventHandler(this.txtsinginpassword_Leave);
            // 
            // btnforget
            // 
            this.btnforget.BackColor = System.Drawing.Color.CadetBlue;
            this.btnforget.FlatAppearance.BorderSize = 0;
            this.btnforget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnforget.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnforget.ForeColor = System.Drawing.Color.White;
            this.btnforget.Location = new System.Drawing.Point(249, 445);
            this.btnforget.Name = "btnforget";
            this.btnforget.Size = new System.Drawing.Size(277, 45);
            this.btnforget.TabIndex = 67;
            this.btnforget.Text = " Reset Password?";
            this.btnforget.UseVisualStyleBackColor = false;
            this.btnforget.Click += new System.EventHandler(this.btnforget_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(288, 644);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 55);
            this.button1.TabIndex = 68;
            this.button1.Text = " Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Signin1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnforget);
            this.Controls.Add(this.txtsinginpassword);
            this.Controls.Add(this.txtsigninid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signin1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZMC Academy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbclose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtsigninid;
        private System.Windows.Forms.TextBox txtsinginpassword;
        private System.Windows.Forms.Button btnforget;
        private System.Windows.Forms.Button button1;
    }
}