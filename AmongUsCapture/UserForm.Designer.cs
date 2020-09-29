namespace AmongUsCapture
{
    partial class UserForm
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.UserSettings = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.CurrentStateGroupBox = new System.Windows.Forms.GroupBox();
			this.CurrentState = new System.Windows.Forms.Label();
			this.GameCodeGB = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.GameCodeBox = new System.Windows.Forms.TextBox();
			this.GameCodeCopyButton = new System.Windows.Forms.Button();
			this.SubmitButton = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ConnectCodeBox = new System.Windows.Forms.TextBox();
			this.ConsoleGroupBox = new System.Windows.Forms.GroupBox();
			this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AutoScrollMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.UserSettings.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.CurrentStateGroupBox.SuspendLayout();
			this.GameCodeGB.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SubmitButton.SuspendLayout();
			this.ConsoleGroupBox.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.UserSettings);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.ConsoleGroupBox);
			this.splitContainer1.Size = new System.Drawing.Size(824, 476);
			this.splitContainer1.SplitterDistance = 274;
			this.splitContainer1.TabIndex = 0;
			this.splitContainer1.Text = "splitContainer1";
			// 
			// UserSettings
			// 
			this.UserSettings.Controls.Add(this.tableLayoutPanel2);
			this.UserSettings.Controls.Add(this.SubmitButton);
			this.UserSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.UserSettings.Location = new System.Drawing.Point(0, 0);
			this.UserSettings.Name = "UserSettings";
			this.UserSettings.Size = new System.Drawing.Size(274, 476);
			this.UserSettings.TabIndex = 0;
			this.UserSettings.TabStop = false;
			this.UserSettings.Text = "Settings";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.CurrentStateGroupBox, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.GameCodeGB, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 349);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(268, 124);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// CurrentStateGroupBox
			// 
			this.CurrentStateGroupBox.Controls.Add(this.CurrentState);
			this.CurrentStateGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CurrentStateGroupBox.Location = new System.Drawing.Point(3, 65);
			this.CurrentStateGroupBox.Name = "CurrentStateGroupBox";
			this.CurrentStateGroupBox.Size = new System.Drawing.Size(262, 56);
			this.CurrentStateGroupBox.TabIndex = 3;
			this.CurrentStateGroupBox.TabStop = false;
			this.CurrentStateGroupBox.Text = "Current State";
			// 
			// CurrentState
			// 
			this.CurrentState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CurrentState.AutoSize = true;
			this.CurrentState.Location = new System.Drawing.Point(38, 28);
			this.CurrentState.Name = "CurrentState";
			this.CurrentState.Size = new System.Drawing.Size(59, 15);
			this.CurrentState.TabIndex = 0;
			this.CurrentState.Text = "Loading...";
			this.CurrentState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GameCodeGB
			// 
			this.GameCodeGB.AutoSize = true;
			this.GameCodeGB.Controls.Add(this.tableLayoutPanel3);
			this.GameCodeGB.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GameCodeGB.Location = new System.Drawing.Point(3, 3);
			this.GameCodeGB.Name = "GameCodeGB";
			this.GameCodeGB.Size = new System.Drawing.Size(262, 56);
			this.GameCodeGB.TabIndex = 4;
			this.GameCodeGB.TabStop = false;
			this.GameCodeGB.Text = "GameCode";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel3.Controls.Add(this.GameCodeBox, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.GameCodeCopyButton, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(256, 34);
			this.tableLayoutPanel3.TabIndex = 6;
			// 
			// GameCodeBox
			// 
			this.GameCodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GameCodeBox.Location = new System.Drawing.Point(3, 3);
			this.GameCodeBox.MaxLength = 6;
			this.GameCodeBox.Name = "GameCodeBox";
			this.GameCodeBox.PlaceholderText = "No Game Found";
			this.GameCodeBox.ReadOnly = true;
			this.GameCodeBox.Size = new System.Drawing.Size(150, 23);
			this.GameCodeBox.TabIndex = 0;
			this.GameCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// GameCodeCopyButton
			// 
			this.GameCodeCopyButton.AutoSize = true;
			this.GameCodeCopyButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.GameCodeCopyButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GameCodeCopyButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.GameCodeCopyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GameCodeCopyButton.Location = new System.Drawing.Point(159, 3);
			this.GameCodeCopyButton.Name = "GameCodeCopyButton";
			this.GameCodeCopyButton.Size = new System.Drawing.Size(94, 28);
			this.GameCodeCopyButton.TabIndex = 1;
			this.GameCodeCopyButton.Text = "Copy";
			this.GameCodeCopyButton.UseVisualStyleBackColor = true;
			this.GameCodeCopyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// SubmitButton
			// 
			this.SubmitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SubmitButton.Controls.Add(this.button1);
			this.SubmitButton.Controls.Add(this.ConnectCodeBox);
			this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SubmitButton.Location = new System.Drawing.Point(3, 19);
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.SubmitButton.Size = new System.Drawing.Size(268, 189);
			this.SubmitButton.TabIndex = 4;
			this.SubmitButton.TabStop = false;
			this.SubmitButton.Text = "Connect Code";
			this.SubmitButton.Enter += new System.EventHandler(this.ConnectCodeGB_Enter);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSize = true;
			this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.button1.BackColor = System.Drawing.SystemColors.Control;
			this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(9, 158);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(55, 25);
			this.button1.TabIndex = 2;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.SubmitButton_Click);
			// 
			// ConnectCodeBox
			// 
			this.ConnectCodeBox.Location = new System.Drawing.Point(6, 23);
			this.ConnectCodeBox.Multiline = true;
			this.ConnectCodeBox.Name = "ConnectCodeBox";
			this.ConnectCodeBox.Size = new System.Drawing.Size(256, 129);
			this.ConnectCodeBox.TabIndex = 0;
			// 
			// ConsoleGroupBox
			// 
			this.ConsoleGroupBox.Controls.Add(this.ConsoleTextBox);
			this.ConsoleGroupBox.Controls.Add(this.checkBox1);
			this.ConsoleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ConsoleGroupBox.Location = new System.Drawing.Point(0, 0);
			this.ConsoleGroupBox.Name = "ConsoleGroupBox";
			this.ConsoleGroupBox.Size = new System.Drawing.Size(546, 476);
			this.ConsoleGroupBox.TabIndex = 0;
			this.ConsoleGroupBox.TabStop = false;
			this.ConsoleGroupBox.Text = "Console Output";
			// 
			// ConsoleTextBox
			// 
			this.ConsoleTextBox.AutoWordSelection = true;
			this.ConsoleTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ConsoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ConsoleTextBox.ContextMenuStrip = this.contextMenuStrip1;
			this.ConsoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ConsoleTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ConsoleTextBox.Location = new System.Drawing.Point(3, 19);
			this.ConsoleTextBox.Name = "ConsoleTextBox";
			this.ConsoleTextBox.ReadOnly = true;
			this.ConsoleTextBox.Size = new System.Drawing.Size(540, 454);
			this.ConsoleTextBox.TabIndex = 0;
			this.ConsoleTextBox.Text = "";
			this.ConsoleTextBox.TextChanged += new System.EventHandler(this.ConsoleTextBox_TextChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoScrollMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
			// 
			// AutoScrollMenuItem
			// 
			this.AutoScrollMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
			this.AutoScrollMenuItem.Checked = true;
			this.AutoScrollMenuItem.CheckOnClick = true;
			this.AutoScrollMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.AutoScrollMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.AutoScrollMenuItem.Name = "AutoScrollMenuItem";
			this.AutoScrollMenuItem.Size = new System.Drawing.Size(129, 22);
			this.AutoScrollMenuItem.Text = "AutoScroll";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(250, 315);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(83, 19);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
			// 
			// UserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 476);
			this.Controls.Add(this.splitContainer1);
			this.Name = "UserForm";
			this.Text = "Among Us Capture";
			this.Load += new System.EventHandler(this.OnLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.UserSettings.ResumeLayout(false);
			this.UserSettings.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.CurrentStateGroupBox.ResumeLayout(false);
			this.CurrentStateGroupBox.PerformLayout();
			this.GameCodeGB.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.SubmitButton.ResumeLayout(false);
			this.SubmitButton.PerformLayout();
			this.ConsoleGroupBox.ResumeLayout(false);
			this.ConsoleGroupBox.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox UserSettings;
        private System.Windows.Forms.GroupBox ConsoleGroupBox;
        private System.Windows.Forms.GroupBox CurrentStateGroupBox;
        private System.Windows.Forms.Label CurrentState;
        private System.Windows.Forms.GroupBox SubmitButton;
        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AutoScrollMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox GameCodeGB;
        private System.Windows.Forms.Button GameCodeCopyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox GameCodeBox;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox ConnectCodeBox;
	}
}