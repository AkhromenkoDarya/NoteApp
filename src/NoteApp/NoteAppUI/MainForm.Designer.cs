
namespace NoteAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TwoColumnLayoutSplitContainer = new System.Windows.Forms.SplitContainer();
            this.NotesListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.ShowCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.ModificationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModificationTimeLabel = new System.Windows.Forms.Label();
            this.CreationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreationTimeLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TwoColumnLayoutSplitContainer)).BeginInit();
            this.TwoColumnLayoutSplitContainer.Panel1.SuspendLayout();
            this.TwoColumnLayoutSplitContainer.Panel2.SuspendLayout();
            this.TwoColumnLayoutSplitContainer.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TwoColumnLayoutSplitContainer
            // 
            this.TwoColumnLayoutSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoColumnLayoutSplitContainer.Location = new System.Drawing.Point(15, 46);
            this.TwoColumnLayoutSplitContainer.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.TwoColumnLayoutSplitContainer.Name = "TwoColumnLayoutSplitContainer";
            // 
            // TwoColumnLayoutSplitContainer.Panel1
            // 
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.NotesListBox);
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.RemoveButton);
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.AddButton);
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.EditButton);
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.ShowCategoryComboBox);
            // 
            // TwoColumnLayoutSplitContainer.Panel2
            // 
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.TitleLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.CategoryTextBox);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.ModificationTimeDateTimePicker);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.ModificationTimeLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.CreationTimeDateTimePicker);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.CreationTimeLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.CategoryLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.TextBox);
            this.TwoColumnLayoutSplitContainer.Size = new System.Drawing.Size(1032, 550);
            this.TwoColumnLayoutSplitContainer.SplitterDistance = 357;
            this.TwoColumnLayoutSplitContainer.TabIndex = 2;
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.ItemHeight = 16;
            this.NotesListBox.Location = new System.Drawing.Point(0, 33);
            this.NotesListBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(354, 468);
            this.NotesListBox.TabIndex = 0;
            this.NotesListBox.SelectedIndexChanged += new System.EventHandler(this.NotesListBox_SelectedIndexChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.Location = new System.Drawing.Point(112, 510);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(50, 40);
            this.RemoveButton.TabIndex = 2;
            this.ToolTip.SetToolTip(this.RemoveButton, "Remove Note");
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.Location = new System.Drawing.Point(0, 510);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 40);
            this.AddButton.TabIndex = 0;
            this.ToolTip.SetToolTip(this.AddButton, "Add Note");
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditButton.FlatAppearance.BorderSize = 0;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.Location = new System.Drawing.Point(56, 510);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 40);
            this.EditButton.TabIndex = 1;
            this.ToolTip.SetToolTip(this.EditButton, "Edit Note");
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(0, 6);
            this.ShowCategoryLabel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.ShowCategoryLabel.Size = new System.Drawing.Size(110, 20);
            this.ShowCategoryLabel.TabIndex = 1;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // ShowCategoryComboBox
            // 
            this.ShowCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowCategoryComboBox.FormattingEnabled = true;
            this.ShowCategoryComboBox.Location = new System.Drawing.Point(116, 3);
            this.ShowCategoryComboBox.Name = "ShowCategoryComboBox";
            this.ShowCategoryComboBox.Size = new System.Drawing.Size(238, 24);
            this.ShowCategoryComboBox.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(3, 3);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 29);
            this.TitleLabel.TabIndex = 0;
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.CategoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CategoryTextBox.Location = new System.Drawing.Point(80, 38);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(100, 15);
            this.CategoryTextBox.TabIndex = 7;
            // 
            // ModificationTimeDateTimePicker
            // 
            this.ModificationTimeDateTimePicker.CustomFormat = "dd.MM.yyyy    HH:mm";
            this.ModificationTimeDateTimePicker.Enabled = false;
            this.ModificationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModificationTimeDateTimePicker.Location = new System.Drawing.Point(351, 59);
            this.ModificationTimeDateTimePicker.Name = "ModificationTimeDateTimePicker";
            this.ModificationTimeDateTimePicker.Size = new System.Drawing.Size(172, 22);
            this.ModificationTimeDateTimePicker.TabIndex = 5;
            // 
            // ModificationTimeLabel
            // 
            this.ModificationTimeLabel.AutoSize = true;
            this.ModificationTimeLabel.Location = new System.Drawing.Point(280, 64);
            this.ModificationTimeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ModificationTimeLabel.Name = "ModificationTimeLabel";
            this.ModificationTimeLabel.Size = new System.Drawing.Size(65, 17);
            this.ModificationTimeLabel.TabIndex = 4;
            this.ModificationTimeLabel.Text = "Modified:";
            this.ModificationTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CreationTimeDateTimePicker
            // 
            this.CreationTimeDateTimePicker.CustomFormat = "dd.MM.yyyy    HH:mm";
            this.CreationTimeDateTimePicker.Enabled = false;
            this.CreationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreationTimeDateTimePicker.Location = new System.Drawing.Point(80, 59);
            this.CreationTimeDateTimePicker.Name = "CreationTimeDateTimePicker";
            this.CreationTimeDateTimePicker.Size = new System.Drawing.Size(172, 22);
            this.CreationTimeDateTimePicker.TabIndex = 3;
            // 
            // CreationTimeLabel
            // 
            this.CreationTimeLabel.AutoSize = true;
            this.CreationTimeLabel.Location = new System.Drawing.Point(5, 64);
            this.CreationTimeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CreationTimeLabel.Name = "CreationTimeLabel";
            this.CreationTimeLabel.Size = new System.Drawing.Size(62, 17);
            this.CreationTimeLabel.TabIndex = 3;
            this.CreationTimeLabel.Text = "Created:";
            this.CreationTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(5, 38);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(8, 88);
            this.TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(663, 462);
            this.TextBox.TabIndex = 6;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(15, 15);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1032, 28);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.ExitToolStripMenuItem.Text = "Exit                            Alt+F4";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNoteToolStripMenuItem,
            this.EditNoteToolStripMenuItem,
            this.RemoveNoteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // AddNoteToolStripMenuItem
            // 
            this.AddNoteToolStripMenuItem.Name = "AddNoteToolStripMenuItem";
            this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.AddNoteToolStripMenuItem.Text = "Add Note";
            this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.AddNoteToolStripMenuItem_Click);
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.EditNoteToolStripMenuItem_Click);
            // 
            // RemoveNoteToolStripMenuItem
            // 
            this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
            this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
            this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveNoteToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutF1ToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutF1ToolStripMenuItem
            // 
            this.AboutF1ToolStripMenuItem.Name = "AboutF1ToolStripMenuItem";
            this.AboutF1ToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.AboutF1ToolStripMenuItem.Text = "About                               F1";
            this.AboutF1ToolStripMenuItem.Click += new System.EventHandler(this.AboutF1ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 611);
            this.Controls.Add(this.TwoColumnLayoutSplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(840, 418);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TwoColumnLayoutSplitContainer.Panel1.ResumeLayout(false);
            this.TwoColumnLayoutSplitContainer.Panel1.PerformLayout();
            this.TwoColumnLayoutSplitContainer.Panel2.ResumeLayout(false);
            this.TwoColumnLayoutSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TwoColumnLayoutSplitContainer)).EndInit();
            this.TwoColumnLayoutSplitContainer.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.SplitContainer TwoColumnLayoutSplitContainer;
        private System.Windows.Forms.ListBox NotesListBox;
        private System.Windows.Forms.ComboBox ShowCategoryComboBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutF1ToolStripMenuItem;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ModificationTimeLabel;
        private System.Windows.Forms.Label CreationTimeLabel;
        private System.Windows.Forms.DateTimePicker CreationTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModificationTimeDateTimePicker;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox CategoryTextBox;
    }
}