
namespace KeystrokeMonitor
{
    partial class frmHomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtControl = new MetroFramework.Controls.MetroTabControl();
            this.Home = new MetroFramework.Controls.MetroTabPage();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BlacklistWords = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBlacklistWord = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.lblWord = new MetroFramework.Controls.MetroLabel();
            this.txtWord = new MetroFramework.Controls.MetroTextBox();
            this.notifyTASK = new System.Windows.Forms.NotifyIcon(this.components);
            this.mtControl.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BlacklistWords.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlacklistWord)).BeginInit();
            this.SuspendLayout();
            // 
            // mtControl
            // 
            this.mtControl.Controls.Add(this.Home);
            this.mtControl.Controls.Add(this.BlacklistWords);
            this.mtControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.mtControl.Location = new System.Drawing.Point(20, 115);
            this.mtControl.Margin = new System.Windows.Forms.Padding(6);
            this.mtControl.Name = "mtControl";
            this.mtControl.SelectedIndex = 0;
            this.mtControl.Size = new System.Drawing.Size(746, 833);
            this.mtControl.TabIndex = 1;
            this.mtControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtControl.UseSelectable = true;
            this.mtControl.SelectedIndexChanged += new System.EventHandler(this.mtControl_SelectedIndexChanged);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.Control;
            this.Home.Controls.Add(this.btnStart);
            this.Home.Controls.Add(this.lblEmail);
            this.Home.Controls.Add(this.txtEmail);
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.HorizontalScrollbarBarColor = true;
            this.Home.HorizontalScrollbarHighlightOnWheel = false;
            this.Home.HorizontalScrollbarSize = 19;
            this.Home.Location = new System.Drawing.Point(8, 41);
            this.Home.Margin = new System.Windows.Forms.Padding(6);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(730, 784);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Home.VerticalScrollbarBarColor = true;
            this.Home.VerticalScrollbarHighlightOnWheel = false;
            this.Home.VerticalScrollbarSize = 20;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.SystemColors.Control;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.Highlight = true;
            this.btnStart.Location = new System.Drawing.Point(578, 687);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 52);
            this.btnStart.Style = MetroFramework.MetroColorStyle.Green;
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "START";
            this.btnStart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnStart.UseSelectable = true;
            this.btnStart.UseStyleColors = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmail.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblEmail.Location = new System.Drawing.Point(10, 685);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 25);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(378, 2);
            this.txtEmail.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(47, 47);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(138, 687);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Example@Mail.com";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(428, 52);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "Example@Mail.com";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 665);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BlacklistWords
            // 
            this.BlacklistWords.Controls.Add(this.tableLayoutPanel1);
            this.BlacklistWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlacklistWords.HorizontalScrollbarBarColor = true;
            this.BlacklistWords.HorizontalScrollbarHighlightOnWheel = false;
            this.BlacklistWords.HorizontalScrollbarSize = 19;
            this.BlacklistWords.Location = new System.Drawing.Point(8, 41);
            this.BlacklistWords.Margin = new System.Windows.Forms.Padding(6);
            this.BlacklistWords.Name = "BlacklistWords";
            this.BlacklistWords.Size = new System.Drawing.Size(730, 784);
            this.BlacklistWords.TabIndex = 2;
            this.BlacklistWords.Text = "Blacklist Words";
            this.BlacklistWords.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BlacklistWords.VerticalScrollbarBarColor = true;
            this.BlacklistWords.VerticalScrollbarHighlightOnWheel = false;
            this.BlacklistWords.VerticalScrollbarSize = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.16107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.83893F));
            this.tableLayoutPanel1.Controls.Add(this.dgvBlacklistWord, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWord, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtWord, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 719);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dgvBlacklistWord
            // 
            this.dgvBlacklistWord.AllowUserToAddRows = false;
            this.dgvBlacklistWord.AllowUserToDeleteRows = false;
            this.dgvBlacklistWord.BackgroundColor = System.Drawing.Color.White;
            this.dgvBlacklistWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBlacklistWord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBlacklistWord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlacklistWord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBlacklistWord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlacklistWord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dgvID,
            this.Word});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvBlacklistWord, 4);
            this.dgvBlacklistWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBlacklistWord.EnableHeadersVisualStyles = false;
            this.dgvBlacklistWord.Location = new System.Drawing.Point(6, 69);
            this.dgvBlacklistWord.Margin = new System.Windows.Forms.Padding(6);
            this.dgvBlacklistWord.MultiSelect = false;
            this.dgvBlacklistWord.Name = "dgvBlacklistWord";
            this.dgvBlacklistWord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlacklistWord.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBlacklistWord.RowHeadersVisible = false;
            this.dgvBlacklistWord.RowHeadersWidth = 82;
            this.dgvBlacklistWord.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBlacklistWord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBlacklistWord.Size = new System.Drawing.Size(706, 644);
            this.dgvBlacklistWord.TabIndex = 9;
            this.dgvBlacklistWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvBlacklistWord_KeyUp);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 200;
            // 
            // dgvID
            // 
            this.dgvID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvID.HeaderText = "#";
            this.dgvID.MinimumWidth = 10;
            this.dgvID.Name = "dgvID";
            // 
            // Word
            // 
            this.Word.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Word.HeaderText = "Words";
            this.Word.MinimumWidth = 10;
            this.Word.Name = "Word";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.Highlight = true;
            this.btnSave.Location = new System.Drawing.Point(569, 6);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 51);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWord.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblWord.Location = new System.Drawing.Point(6, 0);
            this.lblWord.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(100, 63);
            this.lblWord.TabIndex = 3;
            this.lblWord.Text = "Word";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWord.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtWord
            // 
            // 
            // 
            // 
            this.txtWord.CustomButton.Image = null;
            this.txtWord.CustomButton.Location = new System.Drawing.Point(379, 1);
            this.txtWord.CustomButton.Margin = new System.Windows.Forms.Padding(6);
            this.txtWord.CustomButton.Name = "";
            this.txtWord.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.txtWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWord.CustomButton.TabIndex = 1;
            this.txtWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWord.CustomButton.UseSelectable = true;
            this.txtWord.CustomButton.Visible = false;
            this.txtWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWord.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtWord.Lines = new string[0];
            this.txtWord.Location = new System.Drawing.Point(128, 6);
            this.txtWord.Margin = new System.Windows.Forms.Padding(6);
            this.txtWord.MaxLength = 32767;
            this.txtWord.Name = "txtWord";
            this.txtWord.PasswordChar = '\0';
            this.txtWord.PromptText = "Example";
            this.txtWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWord.SelectedText = "";
            this.txtWord.SelectionLength = 0;
            this.txtWord.SelectionStart = 0;
            this.txtWord.ShortcutsEnabled = true;
            this.txtWord.Size = new System.Drawing.Size(429, 51);
            this.txtWord.TabIndex = 8;
            this.txtWord.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWord.UseSelectable = true;
            this.txtWord.WaterMark = "Example";
            this.txtWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWord_KeyDown);
            // 
            // notifyTASK
            // 
            this.notifyTASK.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyTASK.Icon")));
            this.notifyTASK.Text = "Keystroke Monitor";
            this.notifyTASK.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyTASK_MouseDoubleClick);
            // 
            // frmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 967);
            this.Controls.Add(this.mtControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmHomePage";
            this.Padding = new System.Windows.Forms.Padding(20, 115, 20, 19);
            this.Resizable = false;
            this.Text = "Keystroke Monitor";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHomePage_FormClosing);
            this.Resize += new System.EventHandler(this.frmHomePage_Resize);
            this.mtControl.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BlacklistWords.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlacklistWord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtControl;
        private MetroFramework.Controls.MetroTabPage BlacklistWords;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel lblWord;
        private MetroFramework.Controls.MetroTextBox txtWord;
        private MetroFramework.Controls.MetroTabPage Home;
        private System.Windows.Forms.DataGridView dgvBlacklistWord;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.NotifyIcon notifyTASK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
    }
}

