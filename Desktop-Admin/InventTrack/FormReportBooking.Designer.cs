namespace InventTrack
{
    partial class FormReportBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportBooking));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tbsearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
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
            this.tbsearch.Location = new System.Drawing.Point(35, 91);
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
            this.tbsearch.TabIndex = 37;
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
            this.label1.Location = new System.Drawing.Point(265, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 50);
            this.label1.TabIndex = 38;
            this.label1.Text = "Report Booking";
            // 
            // dgvData
            // 
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.GridColor = System.Drawing.Color.White;
            this.dgvData.Location = new System.Drawing.Point(35, 153);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(729, 408);
            this.dgvData.TabIndex = 50;
            // 
            // btn
            // 
            this.btn.AllowAnimations = true;
            this.btn.AllowMouseEffects = true;
            this.btn.AllowToggling = false;
            this.btn.AnimationSpeed = 200;
            this.btn.AutoGenerateColors = false;
            this.btn.AutoRoundBorders = false;
            this.btn.AutoSizeLeftIcon = true;
            this.btn.AutoSizeRightIcon = true;
            this.btn.BackColor = System.Drawing.Color.Transparent;
            this.btn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn.BackgroundImage")));
            this.btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn.ButtonText = "Report Excel";
            this.btn.ButtonTextMarginLeft = 0;
            this.btn.ColorContrastOnClick = 45;
            this.btn.ColorContrastOnHover = 45;
            this.btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn.CustomizableEdges = borderEdges1;
            this.btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.IconLeft = null;
            this.btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn.IconMarginLeft = 11;
            this.btn.IconPadding = 10;
            this.btn.IconRight = null;
            this.btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn.IconSize = 25;
            this.btn.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn.IdleBorderRadius = 0;
            this.btn.IdleBorderThickness = 0;
            this.btn.IdleFillColor = System.Drawing.Color.Empty;
            this.btn.IdleIconLeftImage = null;
            this.btn.IdleIconRightImage = null;
            this.btn.IndicateFocus = false;
            this.btn.Location = new System.Drawing.Point(589, 91);
            this.btn.Name = "btn";
            this.btn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn.OnDisabledState.BorderRadius = 32;
            this.btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn.OnDisabledState.BorderThickness = 1;
            this.btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn.OnDisabledState.IconLeftImage = null;
            this.btn.OnDisabledState.IconRightImage = null;
            this.btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn.onHoverState.BorderRadius = 32;
            this.btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn.onHoverState.BorderThickness = 1;
            this.btn.onHoverState.FillColor = System.Drawing.Color.White;
            this.btn.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn.onHoverState.IconLeftImage = null;
            this.btn.onHoverState.IconRightImage = null;
            this.btn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn.OnIdleState.BorderRadius = 32;
            this.btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn.OnIdleState.BorderThickness = 1;
            this.btn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn.OnIdleState.IconLeftImage = null;
            this.btn.OnIdleState.IconRightImage = null;
            this.btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn.OnPressedState.BorderRadius = 32;
            this.btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn.OnPressedState.BorderThickness = 1;
            this.btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn.OnPressedState.IconLeftImage = null;
            this.btn.OnPressedState.IconRightImage = null;
            this.btn.Size = new System.Drawing.Size(175, 39);
            this.btn.TabIndex = 58;
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn.TextMarginLeft = 0;
            this.btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn.UseDefaultRadiusAndThickness = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // FormReportBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportBooking";
            this.Text = "FormReportBooking";
            this.Load += new System.EventHandler(this.FormReportBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox tbsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvData;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn;
    }
}