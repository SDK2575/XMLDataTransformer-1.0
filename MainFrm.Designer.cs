namespace XMLDataTransformer
{
    partial class MainFrm
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
            this.lblfolder = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLob = new System.Windows.Forms.Label();
            this.cbLob = new System.Windows.Forms.ComboBox();
            this.btnTransform = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblExpFileName = new System.Windows.Forms.Label();
            this.txtExpFile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iCEWebScrapperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inspireWSTesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfolder
            // 
            this.lblfolder.AutoSize = true;
            this.lblfolder.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfolder.Location = new System.Drawing.Point(23, 36);
            this.lblfolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfolder.Name = "lblfolder";
            this.lblfolder.Size = new System.Drawing.Size(150, 18);
            this.lblfolder.TabIndex = 0;
            this.lblfolder.Text = "Select XML Data Folder";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.BackColor = System.Drawing.Color.Wheat;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(477, 36);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(105, 30);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse Folder";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Files To Process";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.BackColor = System.Drawing.Color.Wheat;
            this.btnLoadFiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFiles.Location = new System.Drawing.Point(187, 74);
            this.btnLoadFiles.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(94, 30);
            this.btnLoadFiles.TabIndex = 5;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = false;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(187, 148);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(408, 251);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select All";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(496, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deselect All";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblLob
            // 
            this.lblLob.AutoSize = true;
            this.lblLob.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLob.Location = new System.Drawing.Point(24, 412);
            this.lblLob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLob.Name = "lblLob";
            this.lblLob.Size = new System.Drawing.Size(70, 18);
            this.lblLob.TabIndex = 9;
            this.lblLob.Text = "Select Lob";
            // 
            // cbLob
            // 
            this.cbLob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbLob.FormattingEnabled = true;
            this.cbLob.Items.AddRange(new object[] {
            "BC",
            "DW",
            "GC",
            "HO",
            "PL AUTO",
            "PL CA",
            "PL CGL",
            "TRADE Check",
            "UMB",
            "WCC",
            "WCU PC"});
            this.cbLob.Location = new System.Drawing.Point(187, 414);
            this.cbLob.Margin = new System.Windows.Forms.Padding(2);
            this.cbLob.Name = "cbLob";
            this.cbLob.Size = new System.Drawing.Size(116, 21);
            this.cbLob.Sorted = true;
            this.cbLob.TabIndex = 10;
            this.cbLob.SelectedIndexChanged += new System.EventHandler(this.cbLob_SelectedIndexChanged);
            // 
            // btnTransform
            // 
            this.btnTransform.BackColor = System.Drawing.Color.Wheat;
            this.btnTransform.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransform.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransform.Location = new System.Drawing.Point(187, 462);
            this.btnTransform.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(154, 33);
            this.btnTransform.TabIndex = 11;
            this.btnTransform.Text = "Transform Data";
            this.btnTransform.UseVisualStyleBackColor = false;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.Wheat;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.Location = new System.Drawing.Point(478, 510);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(118, 34);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.Text = "Export To Excel";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblExpFileName
            // 
            this.lblExpFileName.AutoSize = true;
            this.lblExpFileName.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpFileName.Location = new System.Drawing.Point(27, 516);
            this.lblExpFileName.Name = "lblExpFileName";
            this.lblExpFileName.Size = new System.Drawing.Size(112, 18);
            this.lblExpFileName.TabIndex = 13;
            this.lblExpFileName.Text = "Export File Name";
            // 
            // txtExpFile
            // 
            this.txtExpFile.Location = new System.Drawing.Point(187, 518);
            this.txtExpFile.Name = "txtExpFile";
            this.txtExpFile.Size = new System.Drawing.Size(278, 20);
            this.txtExpFile.TabIndex = 14;
            this.txtExpFile.Text = "C:\\PKGExpData\\WCUData.xls";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Maroon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(587, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(286, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(262, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Maroon;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(345, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Maroon;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(578, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(579, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "6";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Orange;
            this.btnReset.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(478, 564);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 38);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset All";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iCEWebScrapperToolStripMenuItem,
            this.inspireWSTesterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iCEWebScrapperToolStripMenuItem
            // 
            this.iCEWebScrapperToolStripMenuItem.Name = "iCEWebScrapperToolStripMenuItem";
            this.iCEWebScrapperToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.iCEWebScrapperToolStripMenuItem.Text = "ICE Web Scrapper";
            this.iCEWebScrapperToolStripMenuItem.Click += new System.EventHandler(this.iCEWebScrapperToolStripMenuItem_Click);
            // 
            // inspireWSTesterToolStripMenuItem
            // 
            this.inspireWSTesterToolStripMenuItem.Name = "inspireWSTesterToolStripMenuItem";
            this.inspireWSTesterToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.inspireWSTesterToolStripMenuItem.Text = "Inspire WS Tester";
            this.inspireWSTesterToolStripMenuItem.Click += new System.EventHandler(this.inspireWSTesterToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 614);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExpFile);
            this.Controls.Add(this.lblExpFileName);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.cbLob);
            this.Controls.Add(this.lblLob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLoadFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblfolder);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Parser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLob;
        private System.Windows.Forms.ComboBox cbLob;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblExpFileName;
        private System.Windows.Forms.TextBox txtExpFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iCEWebScrapperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inspireWSTesterToolStripMenuItem;
    }
}

