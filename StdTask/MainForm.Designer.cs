namespace StdTask
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bestSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfectSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passedSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notPassedSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.reportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.AllowUserToAddRows = false;
            this.reportDataGridView.AllowUserToDeleteRows = false;
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDataGridView.Location = new System.Drawing.Point(0, 24);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.RowHeadersVisible = false;
            this.reportDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportDataGridView.Size = new System.Drawing.Size(1202, 559);
            this.reportDataGridView.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.sortToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenuStrip.Size = new System.Drawing.Size(1202, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(129, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(129, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDataToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.projectToolStripMenuItem.Text = "Проект";
            // 
            // addDataToolStripMenuItem
            // 
            this.addDataToolStripMenuItem.Name = "addDataToolStripMenuItem";
            this.addDataToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addDataToolStripMenuItem.Text = "Добавить";
            this.addDataToolStripMenuItem.Click += new System.EventHandler(this.addDataToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.removeToolStripMenuItem.Text = "Удалить";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestSearchToolStripMenuItem,
            this.perfectSearchToolStripMenuItem,
            this.goodSearchToolStripMenuItem,
            this.passedSearchToolStripMenuItem,
            this.notPassedSearchToolStripMenuItem,
            this.resetSearchToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Поиск";
            // 
            // bestSearchToolStripMenuItem
            // 
            this.bestSearchToolStripMenuItem.Name = "bestSearchToolStripMenuItem";
            this.bestSearchToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.bestSearchToolStripMenuItem.Text = "Лучшие";
            this.bestSearchToolStripMenuItem.Click += new System.EventHandler(this.bestSearchToolStripMenuItem_Click);
            // 
            // perfectSearchToolStripMenuItem
            // 
            this.perfectSearchToolStripMenuItem.Name = "perfectSearchToolStripMenuItem";
            this.perfectSearchToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.perfectSearchToolStripMenuItem.Text = "Отличники";
            this.perfectSearchToolStripMenuItem.Click += new System.EventHandler(this.perfectSearchToolStripMenuItem_Click);
            // 
            // goodSearchToolStripMenuItem
            // 
            this.goodSearchToolStripMenuItem.Name = "goodSearchToolStripMenuItem";
            this.goodSearchToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.goodSearchToolStripMenuItem.Text = "Хорошисты";
            this.goodSearchToolStripMenuItem.Click += new System.EventHandler(this.goodSearchToolStripMenuItem_Click);
            // 
            // passedSearchToolStripMenuItem
            // 
            this.passedSearchToolStripMenuItem.Name = "passedSearchToolStripMenuItem";
            this.passedSearchToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.passedSearchToolStripMenuItem.Text = "Троечники";
            this.passedSearchToolStripMenuItem.Click += new System.EventHandler(this.passedSearchToolStripMenuItem_Click);
            // 
            // notPassedSearchToolStripMenuItem
            // 
            this.notPassedSearchToolStripMenuItem.Name = "notPassedSearchToolStripMenuItem";
            this.notPassedSearchToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.notPassedSearchToolStripMenuItem.Text = "Не сдавшие";
            this.notPassedSearchToolStripMenuItem.Click += new System.EventHandler(this.notPassedSearchToolStripMenuItem_Click);
            // 
            // resetSearchToolStripMenuItem
            // 
            this.resetSearchToolStripMenuItem.Name = "resetSearchToolStripMenuItem";
            this.resetSearchToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.resetSearchToolStripMenuItem.Text = "Сбросить";
            this.resetSearchToolStripMenuItem.Click += new System.EventHandler(this.resetSearchToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.sortToolStripMenuItem.Text = "Сортировка";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // reportOpenFileDialog
            // 
            this.reportOpenFileDialog.DefaultExt = "json";
            this.reportOpenFileDialog.Filter = "Json files(*.json)|*.json";
            // 
            // reportSaveFileDialog
            // 
            this.reportSaveFileDialog.DefaultExt = "json";
            this.reportSaveFileDialog.Filter = "Json files(*.json)|*.json";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 583);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.mainMenuStrip);
            this.Name = "MainForm";
            this.Text = "Ведомость";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog reportOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog reportSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfectSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passedSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notPassedSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bestSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

