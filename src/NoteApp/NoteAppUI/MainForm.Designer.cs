
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
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SelectedCategoryLabel = new System.Windows.Forms.Label();
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
            this.TwoColumnLayoutSplitContainer.Location = new System.Drawing.Point(0, 31);
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
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.CategoryComboBox);
            this.TwoColumnLayoutSplitContainer.Panel1MinSize = 196;
            // 
            // TwoColumnLayoutSplitContainer.Panel2
            // 
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.TitleLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.SelectedCategoryLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.ModificationTimeDateTimePicker);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.ModificationTimeLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.CreationTimeDateTimePicker);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.CreationTimeLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.CategoryLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.TextBox);
            this.TwoColumnLayoutSplitContainer.Panel2MinSize = 408;
            this.TwoColumnLayoutSplitContainer.Size = new System.Drawing.Size(1062, 580);
            this.TwoColumnLayoutSplitContainer.SplitterDistance = 366;
            this.TwoColumnLayoutSplitContainer.TabIndex = 1;
            // 
            // NotesListBox
            // 
            this.NotesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotesListBox.FormattingEnabled = true;
            this.NotesListBox.ItemHeight = 16;
            this.NotesListBox.Location = new System.Drawing.Point(15, 33);
            this.NotesListBox.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.NotesListBox.Name = "NotesListBox";
            this.NotesListBox.Size = new System.Drawing.Size(347, 484);
            this.NotesListBox.TabIndex = 2;
            this.NotesListBox.SelectedValueChanged += new System.EventHandler(this.NotesListBox_SelectedValueChanged);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveButton.Image")));
            this.RemoveButton.Location = new System.Drawing.Point(127, 525);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(50, 40);
            this.RemoveButton.TabIndex = 5;
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
            this.AddButton.Location = new System.Drawing.Point(15, 525);
            this.AddButton.Margin = new System.Windows.Forms.Padding(15, 3, 3, 15);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 40);
            this.AddButton.TabIndex = 3;
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
            this.EditButton.Location = new System.Drawing.Point(71, 525);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 40);
            this.EditButton.TabIndex = 4;
            this.ToolTip.SetToolTip(this.EditButton, "Edit Note");
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(12, 6);
            this.ShowCategoryLabel.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Padding = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.ShowCategoryLabel.Size = new System.Drawing.Size(110, 20);
            this.ShowCategoryLabel.TabIndex = 0;
            this.ShowCategoryLabel.Text = "Show Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(128, 3);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(234, 24);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(54, 25);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.Text = "Title";
            // 
            // SelectedCategoryLabel
            // 
            this.SelectedCategoryLabel.AutoSize = true;
            this.SelectedCategoryLabel.Location = new System.Drawing.Point(77, 38);
            this.SelectedCategoryLabel.Name = "SelectedCategoryLabel";
            this.SelectedCategoryLabel.Size = new System.Drawing.Size(63, 17);
            this.SelectedCategoryLabel.TabIndex = 8;
            this.SelectedCategoryLabel.Text = "category";
            // 
            // ModificationTimeDateTimePicker
            // 
            this.ModificationTimeDateTimePicker.CustomFormat = "dd.MM.yyyy    HH:mm";
            this.ModificationTimeDateTimePicker.Enabled = false;
            this.ModificationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModificationTimeDateTimePicker.Location = new System.Drawing.Point(357, 59);
            this.ModificationTimeDateTimePicker.Name = "ModificationTimeDateTimePicker";
            this.ModificationTimeDateTimePicker.Size = new System.Drawing.Size(172, 22);
            this.ModificationTimeDateTimePicker.TabIndex = 6;
            // 
            // ModificationTimeLabel
            // 
            this.ModificationTimeLabel.AutoSize = true;
            this.ModificationTimeLabel.Location = new System.Drawing.Point(276, 64);
            this.ModificationTimeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ModificationTimeLabel.Name = "ModificationTimeLabel";
            this.ModificationTimeLabel.Size = new System.Drawing.Size(65, 17);
            this.ModificationTimeLabel.TabIndex = 5;
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
            this.CreationTimeDateTimePicker.TabIndex = 4;
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
            this.TextBox.Margin = new System.Windows.Forms.Padding(3, 3, 15, 15);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(669, 477);
            this.TextBox.TabIndex = 7;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1062, 28);
            this.MenuStrip.TabIndex = 0;
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
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
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
            this.AddNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AddNoteToolStripMenuItem.Text = "Add Note";
            this.AddNoteToolStripMenuItem.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            this.EditNoteToolStripMenuItem.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RemoveNoteToolStripMenuItem
            // 
            this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
            this.RemoveNoteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
            this.RemoveNoteToolStripMenuItem.Click += new System.EventHandler(this.RemoveButton_Click);
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
            this.AboutF1ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutF1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.AboutF1ToolStripMenuItem.Text = "About";
            this.AboutF1ToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 611);
            this.Controls.Add(this.TwoColumnLayoutSplitContainer);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(852, 430);
            this.Name = "MainForm";
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
        private System.Windows.Forms.ComboBox CategoryComboBox;
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
        private System.Windows.Forms.Label ModificationTimeLabel;
        private System.Windows.Forms.Label CreationTimeLabel;
        private System.Windows.Forms.DateTimePicker CreationTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModificationTimeDateTimePicker;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label SelectedCategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}