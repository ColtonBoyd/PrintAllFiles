namespace PrintAllFiles
{
    partial class Form1
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
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lstBoxSources = new System.Windows.Forms.ListBox();
            this.lstBoxFileList = new System.Windows.Forms.ListBox();
            this.chkShowFiles = new System.Windows.Forms.CheckBox();
            this.chkHidePath = new System.Windows.Forms.CheckBox();
            this.chkMultiThread = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getMeOutaHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSourceListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearOutputListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkMultipleFolders = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(706, 404);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(82, 34);
            this.btnPopulate.TabIndex = 0;
            this.btnPopulate.Text = "&Start Search";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(618, 404);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(82, 34);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lstBoxSources
            // 
            this.lstBoxSources.FormattingEnabled = true;
            this.lstBoxSources.Location = new System.Drawing.Point(551, 26);
            this.lstBoxSources.Name = "lstBoxSources";
            this.lstBoxSources.Size = new System.Drawing.Size(237, 368);
            this.lstBoxSources.TabIndex = 1;
            // 
            // lstBoxFileList
            // 
            this.lstBoxFileList.FormattingEnabled = true;
            this.lstBoxFileList.Location = new System.Drawing.Point(12, 25);
            this.lstBoxFileList.Name = "lstBoxFileList";
            this.lstBoxFileList.Size = new System.Drawing.Size(533, 368);
            this.lstBoxFileList.TabIndex = 1;
            this.lstBoxFileList.DoubleClick += new System.EventHandler(this.lstBoxFileList_DoubleClick);
            // 
            // chkShowFiles
            // 
            this.chkShowFiles.AutoSize = true;
            this.chkShowFiles.Location = new System.Drawing.Point(12, 414);
            this.chkShowFiles.Name = "chkShowFiles";
            this.chkShowFiles.Size = new System.Drawing.Size(77, 17);
            this.chkShowFiles.TabIndex = 2;
            this.chkShowFiles.Text = "Show Files";
            this.chkShowFiles.UseVisualStyleBackColor = true;
            // 
            // chkHidePath
            // 
            this.chkHidePath.AutoSize = true;
            this.chkHidePath.Location = new System.Drawing.Point(95, 414);
            this.chkHidePath.Name = "chkHidePath";
            this.chkHidePath.Size = new System.Drawing.Size(73, 17);
            this.chkHidePath.TabIndex = 2;
            this.chkHidePath.Text = "Hide Path";
            this.chkHidePath.UseVisualStyleBackColor = true;
            // 
            // chkMultiThread
            // 
            this.chkMultiThread.AutoSize = true;
            this.chkMultiThread.Location = new System.Drawing.Point(174, 414);
            this.chkMultiThread.Name = "chkMultiThread";
            this.chkMultiThread.Size = new System.Drawing.Size(81, 17);
            this.chkMultiThread.TabIndex = 2;
            this.chkMultiThread.Text = "Multi-thread";
            this.chkMultiThread.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.listsToolStripMenuItem,
            this.viewOutputToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getMeOutaHereToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // getMeOutaHereToolStripMenuItem
            // 
            this.getMeOutaHereToolStripMenuItem.Name = "getMeOutaHereToolStripMenuItem";
            this.getMeOutaHereToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.getMeOutaHereToolStripMenuItem.Text = "Get Me Outa Here";
            this.getMeOutaHereToolStripMenuItem.Click += new System.EventHandler(this.getMeOutaHereToolStripMenuItem_Click);
            // 
            // listsToolStripMenuItem
            // 
            this.listsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSourceListToolStripMenuItem,
            this.clearOutputListToolStripMenuItem});
            this.listsToolStripMenuItem.Name = "listsToolStripMenuItem";
            this.listsToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.listsToolStripMenuItem.Text = "Lists";
            // 
            // clearSourceListToolStripMenuItem
            // 
            this.clearSourceListToolStripMenuItem.Name = "clearSourceListToolStripMenuItem";
            this.clearSourceListToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.clearSourceListToolStripMenuItem.Text = "Clear Source List";
            this.clearSourceListToolStripMenuItem.Click += new System.EventHandler(this.clearSourceListToolStripMenuItem_Click);
            // 
            // clearOutputListToolStripMenuItem
            // 
            this.clearOutputListToolStripMenuItem.Name = "clearOutputListToolStripMenuItem";
            this.clearOutputListToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.clearOutputListToolStripMenuItem.Text = "Clear Output List";
            this.clearOutputListToolStripMenuItem.Click += new System.EventHandler(this.clearOutputListToolStripMenuItem_Click);
            // 
            // viewOutputToolStripMenuItem
            // 
            this.viewOutputToolStripMenuItem.Name = "viewOutputToolStripMenuItem";
            this.viewOutputToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.viewOutputToolStripMenuItem.Text = "View Output";
            this.viewOutputToolStripMenuItem.Click += new System.EventHandler(this.viewOutputToolStripMenuItem_Click);
            // 
            // chkMultipleFolders
            // 
            this.chkMultipleFolders.AutoSize = true;
            this.chkMultipleFolders.Location = new System.Drawing.Point(261, 414);
            this.chkMultipleFolders.Name = "chkMultipleFolders";
            this.chkMultipleFolders.Size = new System.Drawing.Size(99, 17);
            this.chkMultipleFolders.TabIndex = 2;
            this.chkMultipleFolders.Text = "Multiple Folders";
            this.chkMultipleFolders.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkMultipleFolders);
            this.Controls.Add(this.chkMultiThread);
            this.Controls.Add(this.chkHidePath);
            this.Controls.Add(this.chkShowFiles);
            this.Controls.Add(this.lstBoxFileList);
            this.Controls.Add(this.lstBoxSources);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ListBox lstBoxSources;
        private System.Windows.Forms.ListBox lstBoxFileList;
        private System.Windows.Forms.CheckBox chkShowFiles;
        private System.Windows.Forms.CheckBox chkHidePath;
        private System.Windows.Forms.CheckBox chkMultiThread;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getMeOutaHereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSourceListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearOutputListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewOutputToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkMultipleFolders;
    }
}

