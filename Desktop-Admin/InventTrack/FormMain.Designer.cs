namespace InventTrack
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.lbllfullname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnproduct = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnbooking = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnreport = new System.Windows.Forms.Button();
            this.panelcontainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblusername);
            this.panel1.Controls.Add(this.lbllfullname);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 74);
            this.panel1.TabIndex = 0;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(94, 36);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(61, 26);
            this.lblusername.TabIndex = 5;
            this.lblusername.Text = "Admin";
            // 
            // lbllfullname
            // 
            this.lbllfullname.AutoSize = true;
            this.lbllfullname.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllfullname.ForeColor = System.Drawing.Color.White;
            this.lbllfullname.Location = new System.Drawing.Point(92, 10);
            this.lbllfullname.Name = "lbllfullname";
            this.lbllfullname.Size = new System.Drawing.Size(206, 30);
            this.lbllfullname.TabIndex = 4;
            this.lbllfullname.Text = "Pandu Tria Adyatama";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(209, 715);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnManageUser);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 56);
            this.panel2.TabIndex = 2;
            // 
            // btnManageUser
            // 
            this.btnManageUser.BackColor = System.Drawing.Color.White;
            this.btnManageUser.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnManageUser.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUser.Image")));
            this.btnManageUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUser.Location = new System.Drawing.Point(-36, -20);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnManageUser.Size = new System.Drawing.Size(251, 94);
            this.btnManageUser.TabIndex = 3;
            this.btnManageUser.Text = "           Manage User";
            this.btnManageUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageUser.UseVisualStyleBackColor = false;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnproduct);
            this.panel3.Location = new System.Drawing.Point(3, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 56);
            this.panel3.TabIndex = 4;
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.White;
            this.btnproduct.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnproduct.Image = ((System.Drawing.Image)(resources.GetObject("btnproduct.Image")));
            this.btnproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.Location = new System.Drawing.Point(-36, -20);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnproduct.Size = new System.Drawing.Size(251, 94);
            this.btnproduct.TabIndex = 3;
            this.btnproduct.Text = "           Manage Product";
            this.btnproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnbooking);
            this.panel4.Location = new System.Drawing.Point(3, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 56);
            this.panel4.TabIndex = 5;
            // 
            // btnbooking
            // 
            this.btnbooking.BackColor = System.Drawing.Color.White;
            this.btnbooking.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnbooking.Image = ((System.Drawing.Image)(resources.GetObject("btnbooking.Image")));
            this.btnbooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbooking.Location = new System.Drawing.Point(-36, -20);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnbooking.Size = new System.Drawing.Size(251, 94);
            this.btnbooking.TabIndex = 3;
            this.btnbooking.Text = "           Manage Booking";
            this.btnbooking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbooking.UseVisualStyleBackColor = false;
            this.btnbooking.Click += new System.EventHandler(this.btnbooking_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnreport);
            this.panel5.Location = new System.Drawing.Point(3, 189);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 56);
            this.panel5.TabIndex = 6;
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.White;
            this.btnreport.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btnreport.Image = ((System.Drawing.Image)(resources.GetObject("btnreport.Image")));
            this.btnreport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.Location = new System.Drawing.Point(-36, -20);
            this.btnreport.Name = "btnreport";
            this.btnreport.Padding = new System.Windows.Forms.Padding(60, 0, 0, 0);
            this.btnreport.Size = new System.Drawing.Size(251, 94);
            this.btnreport.TabIndex = 3;
            this.btnreport.Text = "           Report Booking";
            this.btnreport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // panelcontainer
            // 
            this.panelcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontainer.Location = new System.Drawing.Point(209, 74);
            this.panelcontainer.Name = "panelcontainer";
            this.panelcontainer.Size = new System.Drawing.Size(991, 715);
            this.panelcontainer.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 789);
            this.Controls.Add(this.panelcontainer);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lbllfullname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnbooking;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Panel panelcontainer;
    }
}