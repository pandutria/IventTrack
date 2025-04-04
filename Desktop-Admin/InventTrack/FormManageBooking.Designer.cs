namespace InventTrack
{
    partial class FormManageBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageBooking));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tbsearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // tbsearch
            // 
            this.tbsearch.AcceptsReturn = false;
            this.tbsearch.AcceptsTab = false;
            this.tbsearch.AnimationSpeed = 200;
            this.tbsearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbsearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbsearch.AutoSizeHeight = true;
            this.tbsearch.BackColor = System.Drawing.Color.Transparent;
            this.tbsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsearch.BackgroundImage")));
            this.tbsearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbsearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbsearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbsearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbsearch.BorderRadius = 10;
            this.tbsearch.BorderThickness = 1;
            this.tbsearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbsearch.DefaultFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsearch.DefaultText = "";
            this.tbsearch.FillColor = System.Drawing.Color.White;
            this.tbsearch.HideSelection = true;
            this.tbsearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("tbsearch.IconLeft")));
            this.tbsearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbsearch.IconPadding = 10;
            this.tbsearch.IconRight = null;
            this.tbsearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbsearch.Lines = new string[0];
            this.tbsearch.Location = new System.Drawing.Point(39, 79);
            this.tbsearch.MaxLength = 32767;
            this.tbsearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbsearch.Modified = false;
            this.tbsearch.Multiline = false;
            this.tbsearch.Name = "tbsearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbsearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbsearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbsearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbsearch.OnIdleState = stateProperties4;
            this.tbsearch.Padding = new System.Windows.Forms.Padding(3);
            this.tbsearch.PasswordChar = '\0';
            this.tbsearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbsearch.PlaceholderText = "Search by User";
            this.tbsearch.ReadOnly = false;
            this.tbsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbsearch.SelectedText = "";
            this.tbsearch.SelectionLength = 0;
            this.tbsearch.SelectionStart = 0;
            this.tbsearch.ShortcutsEnabled = true;
            this.tbsearch.Size = new System.Drawing.Size(236, 43);
            this.tbsearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbsearch.TabIndex = 36;
            this.tbsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbsearch.TextMarginBottom = 0;
            this.tbsearch.TextMarginLeft = 15;
            this.tbsearch.TextMarginTop = 0;
            this.tbsearch.TextPlaceholder = "Search by User";
            this.tbsearch.UseSystemPasswordChar = false;
            this.tbsearch.WordWrap = true;
            this.tbsearch.TextChanged += new System.EventHandler(this.tbsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 50);
            this.label1.TabIndex = 35;
            this.label1.Text = "Manage Booking";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(39, 147);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(818, 528);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // FormManageBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(902, 708);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageBooking";
            this.Text = "FormManageBooking";
            this.Load += new System.EventHandler(this.FormManageBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox tbsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}