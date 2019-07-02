namespace StdTask
{
    partial class SortDialog
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
            this.sortColumnLabel = new System.Windows.Forms.Label();
            this.sortColumnComboBox = new System.Windows.Forms.ComboBox();
            this.sortTypeLabel = new System.Windows.Forms.Label();
            this.increaseSortButton = new System.Windows.Forms.Button();
            this.decreaseSortButton = new System.Windows.Forms.Button();
            this.debugCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.sortMethodComboBox = new System.Windows.Forms.ComboBox();
            this.sortMethodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sortColumnLabel
            // 
            this.sortColumnLabel.AutoSize = true;
            this.sortColumnLabel.Location = new System.Drawing.Point(12, 9);
            this.sortColumnLabel.Name = "sortColumnLabel";
            this.sortColumnLabel.Size = new System.Drawing.Size(122, 13);
            this.sortColumnLabel.TabIndex = 0;
            this.sortColumnLabel.Text = "Сортируемая колонка:";
            // 
            // sortColumnComboBox
            // 
            this.sortColumnComboBox.FormattingEnabled = true;
            this.sortColumnComboBox.Location = new System.Drawing.Point(140, 6);
            this.sortColumnComboBox.Name = "sortColumnComboBox";
            this.sortColumnComboBox.Size = new System.Drawing.Size(128, 21);
            this.sortColumnComboBox.TabIndex = 1;
            // 
            // sortTypeLabel
            // 
            this.sortTypeLabel.AutoSize = true;
            this.sortTypeLabel.Location = new System.Drawing.Point(12, 56);
            this.sortTypeLabel.Name = "sortTypeLabel";
            this.sortTypeLabel.Size = new System.Drawing.Size(156, 13);
            this.sortTypeLabel.TabIndex = 2;
            this.sortTypeLabel.Text = "Сортировка по: Возрастанию";
            // 
            // increaseSortButton
            // 
            this.increaseSortButton.Location = new System.Drawing.Point(239, 36);
            this.increaseSortButton.Name = "increaseSortButton";
            this.increaseSortButton.Size = new System.Drawing.Size(25, 25);
            this.increaseSortButton.TabIndex = 4;
            this.increaseSortButton.Text = "/\\";
            this.increaseSortButton.UseVisualStyleBackColor = true;
            this.increaseSortButton.Click += new System.EventHandler(this.increaseSortButton_Click);
            // 
            // decreaseSortButton
            // 
            this.decreaseSortButton.Location = new System.Drawing.Point(239, 67);
            this.decreaseSortButton.Name = "decreaseSortButton";
            this.decreaseSortButton.Size = new System.Drawing.Size(25, 25);
            this.decreaseSortButton.TabIndex = 5;
            this.decreaseSortButton.Text = "\\/";
            this.decreaseSortButton.UseVisualStyleBackColor = true;
            this.decreaseSortButton.Click += new System.EventHandler(this.decreaseSortButton_Click);
            // 
            // debugCheckBox
            // 
            this.debugCheckBox.AutoSize = true;
            this.debugCheckBox.Location = new System.Drawing.Point(111, 125);
            this.debugCheckBox.Name = "debugCheckBox";
            this.debugCheckBox.Size = new System.Drawing.Size(58, 17);
            this.debugCheckBox.TabIndex = 6;
            this.debugCheckBox.Text = "Debug";
            this.debugCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(100, 148);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(81, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "Сортировать";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // sortMethodComboBox
            // 
            this.sortMethodComboBox.FormattingEnabled = true;
            this.sortMethodComboBox.Location = new System.Drawing.Point(140, 98);
            this.sortMethodComboBox.Name = "sortMethodComboBox";
            this.sortMethodComboBox.Size = new System.Drawing.Size(128, 21);
            this.sortMethodComboBox.TabIndex = 8;
            // 
            // sortMethodLabel
            // 
            this.sortMethodLabel.AutoSize = true;
            this.sortMethodLabel.Location = new System.Drawing.Point(12, 101);
            this.sortMethodLabel.Name = "sortMethodLabel";
            this.sortMethodLabel.Size = new System.Drawing.Size(70, 13);
            this.sortMethodLabel.TabIndex = 9;
            this.sortMethodLabel.Text = "Сортировка:";
            // 
            // SortDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 178);
            this.Controls.Add(this.sortMethodLabel);
            this.Controls.Add(this.sortMethodComboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.debugCheckBox);
            this.Controls.Add(this.decreaseSortButton);
            this.Controls.Add(this.increaseSortButton);
            this.Controls.Add(this.sortTypeLabel);
            this.Controls.Add(this.sortColumnComboBox);
            this.Controls.Add(this.sortColumnLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SortDialog";
            this.Text = "Сортировка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SortDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sortColumnLabel;
        private System.Windows.Forms.ComboBox sortColumnComboBox;
        private System.Windows.Forms.Label sortTypeLabel;
        private System.Windows.Forms.Button increaseSortButton;
        private System.Windows.Forms.Button decreaseSortButton;
        private System.Windows.Forms.CheckBox debugCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox sortMethodComboBox;
        private System.Windows.Forms.Label sortMethodLabel;
    }
}