
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
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TwoColumnLayoutSplitContainer = new System.Windows.Forms.SplitContainer();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.ShowCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.CreationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreationTimeLabel = new System.Windows.Forms.Label();
            this.ModificationTimeLabel = new System.Windows.Forms.Label();
            this.ModificationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBox = new System.Windows.Forms.TextBox();
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
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.CategoryListBox);
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.RemoveNoteButton);
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.AddNoteButton);
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.EditNoteButton);
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.TwoColumnLayoutSplitContainer.Panel1.Controls.Add(this.ShowCategoryComboBox);
            // 
            // TwoColumnLayoutSplitContainer.Panel2
            // 
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.ModificationTimeDateTimePicker);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.ModificationTimeLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.CreationTimeDateTimePicker);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.CreationTimeLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.CategoryLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.TitleLabel);
            this.TwoColumnLayoutSplitContainer.Panel2.Controls.Add(this.TextBox);
            this.TwoColumnLayoutSplitContainer.Size = new System.Drawing.Size(1032, 550);
            this.TwoColumnLayoutSplitContainer.SplitterDistance = 357;
            this.TwoColumnLayoutSplitContainer.TabIndex = 2;
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveNoteButton.FlatAppearance.BorderSize = 0;
            this.RemoveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveNoteButton.Image")));
            this.RemoveNoteButton.Location = new System.Drawing.Point(112, 510);
            this.RemoveNoteButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(50, 40);
            this.RemoveNoteButton.TabIndex = 2;
            this.ToolTip.SetToolTip(this.RemoveNoteButton, "Remove Note");
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.FlatAppearance.BorderSize = 0;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.Image")));
            this.AddNoteButton.Location = new System.Drawing.Point(0, 510);
            this.AddNoteButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(50, 40);
            this.AddNoteButton.TabIndex = 0;
            this.ToolTip.SetToolTip(this.AddNoteButton, "Add Note");
            this.AddNoteButton.UseVisualStyleBackColor = true;
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.FlatAppearance.BorderSize = 0;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.Image")));
            this.EditNoteButton.Location = new System.Drawing.Point(56, 510);
            this.EditNoteButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(50, 40);
            this.EditNoteButton.TabIndex = 1;
            this.ToolTip.SetToolTip(this.EditNoteButton, "Edit Note");
            this.EditNoteButton.UseVisualStyleBackColor = true;
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
            // CategoryListBox
            // 
            this.CategoryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.ItemHeight = 16;
            this.CategoryListBox.Location = new System.Drawing.Point(0, 33);
            this.CategoryListBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(354, 468);
            this.CategoryListBox.TabIndex = 0;
            // 
            // CreationTimeDateTimePicker
            // 
            this.CreationTimeDateTimePicker.CustomFormat = "dd.MM.yyyy    HH:mm";
            this.CreationTimeDateTimePicker.Enabled = false;
            this.CreationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreationTimeDateTimePicker.Location = new System.Drawing.Point(73, 60);
            this.CreationTimeDateTimePicker.Name = "CreationTimeDateTimePicker";
            this.CreationTimeDateTimePicker.Size = new System.Drawing.Size(172, 22);
            this.CreationTimeDateTimePicker.TabIndex = 3;
            // 
            // CreationTimeLabel
            // 
            this.CreationTimeLabel.AutoSize = true;
            this.CreationTimeLabel.Location = new System.Drawing.Point(5, 65);
            this.CreationTimeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CreationTimeLabel.Name = "CreationTimeLabel";
            this.CreationTimeLabel.Size = new System.Drawing.Size(62, 17);
            this.CreationTimeLabel.TabIndex = 3;
            this.CreationTimeLabel.Text = "Created:";
            this.CreationTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModificationTimeLabel
            // 
            this.ModificationTimeLabel.AutoSize = true;
            this.ModificationTimeLabel.Location = new System.Drawing.Point(270, 65);
            this.ModificationTimeLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ModificationTimeLabel.Name = "ModificationTimeLabel";
            this.ModificationTimeLabel.Size = new System.Drawing.Size(65, 17);
            this.ModificationTimeLabel.TabIndex = 4;
            this.ModificationTimeLabel.Text = "Modified:";
            this.ModificationTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModificationTimeDateTimePicker
            // 
            this.ModificationTimeDateTimePicker.CustomFormat = "dd.MM.yyyy    HH:mm";
            this.ModificationTimeDateTimePicker.Enabled = false;
            this.ModificationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModificationTimeDateTimePicker.Location = new System.Drawing.Point(341, 60);
            this.ModificationTimeDateTimePicker.Name = "ModificationTimeDateTimePicker";
            this.ModificationTimeDateTimePicker.Size = new System.Drawing.Size(172, 22);
            this.ModificationTimeDateTimePicker.TabIndex = 5;
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
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 3);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(73, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Titile";
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
            // 
            // EditNoteToolStripMenuItem
            // 
            this.EditNoteToolStripMenuItem.Name = "EditNoteToolStripMenuItem";
            this.EditNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.EditNoteToolStripMenuItem.Text = "Edit Note";
            // 
            // RemoveNoteToolStripMenuItem
            // 
            this.RemoveNoteToolStripMenuItem.Name = "RemoveNoteToolStripMenuItem";
            this.RemoveNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.RemoveNoteToolStripMenuItem.Text = "Remove Note";
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
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.ComboBox ShowCategoryComboBox;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutF1ToolStripMenuItem;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ModificationTimeLabel;
        private System.Windows.Forms.Label CreationTimeLabel;
        private System.Windows.Forms.DateTimePicker CreationTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker ModificationTimeDateTimePicker;
        private System.Windows.Forms.TextBox TextBox;
    }
}