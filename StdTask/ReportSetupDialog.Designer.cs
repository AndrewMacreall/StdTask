namespace StdTask
{
    partial class ReportSetupDialog
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
            this.okButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subjectsListBox = new System.Windows.Forms.ListBox();
            this.selectedSubjectsListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.subjectsLabel = new System.Windows.Forms.Label();
            this.addSubjectsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(150, 242);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(81, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = " Создать";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(176, 81);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(29, 24);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "->";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subjectsListBox
            // 
            this.subjectsListBox.FormattingEnabled = true;
            this.subjectsListBox.Location = new System.Drawing.Point(12, 31);
            this.subjectsListBox.Name = "subjectsListBox";
            this.subjectsListBox.Size = new System.Drawing.Size(133, 199);
            this.subjectsListBox.TabIndex = 2;
            // 
            // selectedSubjectsListBox
            // 
            this.selectedSubjectsListBox.FormattingEnabled = true;
            this.selectedSubjectsListBox.Location = new System.Drawing.Point(236, 31);
            this.selectedSubjectsListBox.Name = "selectedSubjectsListBox";
            this.selectedSubjectsListBox.Size = new System.Drawing.Size(133, 199);
            this.selectedSubjectsListBox.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeButton.Location = new System.Drawing.Point(176, 134);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(29, 24);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "<-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // subjectsLabel
            // 
            this.subjectsLabel.AutoSize = true;
            this.subjectsLabel.Location = new System.Drawing.Point(12, 15);
            this.subjectsLabel.Name = "subjectsLabel";
            this.subjectsLabel.Size = new System.Drawing.Size(105, 13);
            this.subjectsLabel.TabIndex = 5;
            this.subjectsLabel.Text = "Список предметов:";
            // 
            // addSubjectsLabel
            // 
            this.addSubjectsLabel.AutoSize = true;
            this.addSubjectsLabel.Location = new System.Drawing.Point(233, 15);
            this.addSubjectsLabel.Name = "addSubjectsLabel";
            this.addSubjectsLabel.Size = new System.Drawing.Size(129, 13);
            this.addSubjectsLabel.TabIndex = 6;
            this.addSubjectsLabel.Text = "Добавленые предметы:";
            // 
            // ReportSetupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 277);
            this.Controls.Add(this.addSubjectsLabel);
            this.Controls.Add(this.subjectsLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.selectedSubjectsListBox);
            this.Controls.Add(this.subjectsListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportSetupDialog";
            this.Text = "Первоначальная настройка ведомости";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportSetupDialog_FormClosing);
            this.Load += new System.EventHandler(this.ReportSetupDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox subjectsListBox;
        private System.Windows.Forms.ListBox selectedSubjectsListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label subjectsLabel;
        private System.Windows.Forms.Label addSubjectsLabel;
    }
}