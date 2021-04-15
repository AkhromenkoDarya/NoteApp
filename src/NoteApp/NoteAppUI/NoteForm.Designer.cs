
namespace NoteAppUI
{
    partial class NoteForm
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
            this.CreationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreationTimeLabel = new System.Windows.Forms.Label();
            this.ModificationTimeLabel = new System.Windows.Forms.Label();
            this.ModificationTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreationTimeDateTimePicker
            // 
            this.CreationTimeDateTimePicker.CustomFormat = "dd.MM.yyyy    HH:mm";
            this.CreationTimeDateTimePicker.Enabled = false;
            this.CreationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreationTimeDateTimePicker.Location = new System.Drawing.Point(90, 73);
            this.CreationTimeDateTimePicker.Name = "CreationTimeDateTimePicker";
            this.CreationTimeDateTimePicker.Size = new System.Drawing.Size(172, 22);
            this.CreationTimeDateTimePicker.TabIndex = 1;
            // 
            // CreationTimeLabel
            // 
            this.CreationTimeLabel.AutoSize = true;
            this.CreationTimeLabel.Location = new System.Drawing.Point(15, 78);
            this.CreationTimeLabel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CreationTimeLabel.Name = "CreationTimeLabel";
            this.CreationTimeLabel.Size = new System.Drawing.Size(62, 17);
            this.CreationTimeLabel.TabIndex = 0;
            this.CreationTimeLabel.Text = "Created:";
            // 
            // ModificationTimeLabel
            // 
            this.ModificationTimeLabel.AutoSize = true;
            this.ModificationTimeLabel.Location = new System.Drawing.Point(286, 78);
            this.ModificationTimeLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ModificationTimeLabel.Name = "ModificationTimeLabel";
            this.ModificationTimeLabel.Size = new System.Drawing.Size(65, 17);
            this.ModificationTimeLabel.TabIndex = 0;
            this.ModificationTimeLabel.Text = "Modified:";
            // 
            // ModificationTimeDateTimePicker
            // 
            this.ModificationTimeDateTimePicker.CustomFormat = "dd.MM.yyyy    HH:mm";
            this.ModificationTimeDateTimePicker.Enabled = false;
            this.ModificationTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ModificationTimeDateTimePicker.Location = new System.Drawing.Point(357, 73);
            this.ModificationTimeDateTimePicker.Name = "ModificationTimeDateTimePicker";
            this.ModificationTimeDateTimePicker.Size = new System.Drawing.Size(172, 22);
            this.ModificationTimeDateTimePicker.TabIndex = 1;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(15, 18);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 17);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(15, 46);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryLabel.TabIndex = 3;
            this.CategoryLabel.Text = "Category:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TitleTextBox.Location = new System.Drawing.Point(90, 15);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(693, 22);
            this.TitleTextBox.TabIndex = 4;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(90, 43);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(234, 24);
            this.CategoryComboBox.TabIndex = 5;
            this.CategoryComboBox.SelectionChangeCommitted += new System.EventHandler(this.CategoryComboBox_SelectionChangeCommitted);
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(15, 101);
            this.TextBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(768, 455);
            this.TextBox.TabIndex = 6;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(577, 562);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 30);
            this.OKButton.TabIndex = 7;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelChangesButton
            // 
            this.CancelChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelChangesButton.Location = new System.Drawing.Point(683, 562);
            this.CancelChangesButton.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.CancelChangesButton.Name = "CancelChangesButton";
            this.CancelChangesButton.Size = new System.Drawing.Size(100, 30);
            this.CancelChangesButton.TabIndex = 8;
            this.CancelChangesButton.Text = "Cancel";
            this.CancelChangesButton.UseVisualStyleBackColor = true;
            this.CancelChangesButton.Click += new System.EventHandler(this.CancelChangesButton_Click);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 607);
            this.Controls.Add(this.CreationTimeDateTimePicker);
            this.Controls.Add(this.ModificationTimeLabel);
            this.Controls.Add(this.ModificationTimeDateTimePicker);
            this.Controls.Add(this.CreationTimeLabel);
            this.Controls.Add(this.CancelChangesButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.TitleLabel);
            this.MinimumSize = new System.Drawing.Size(560, 398);
            this.Name = "NoteForm";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Note";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CreationTimeLabel;
        private System.Windows.Forms.DateTimePicker CreationTimeDateTimePicker;
        private System.Windows.Forms.Label ModificationTimeLabel;
        private System.Windows.Forms.DateTimePicker ModificationTimeDateTimePicker;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelChangesButton;
    }
}