namespace TabImportExport
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Setup = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImportToServer = new System.Windows.Forms.TextBox();
            this.txtImportUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImportPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtExportFromServer = new System.Windows.Forms.TextBox();
            this.txtExportUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExportPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocalFolder = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTabCmd = new System.Windows.Forms.TextBox();
            this.Export = new System.Windows.Forms.TabPage();
            this.btnDelete2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoadExport = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.TabPage();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoadImport = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.workbookInfo = new TabImportExport.WorkbookInfo();
            this.workbooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._workbooksTableAdapter = new TabImportExport.WorkbookInfoTableAdapters._workbooksTableAdapter();
            this.tabControl1.SuspendLayout();
            this.Setup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Export.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.Import.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workbookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workbooksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Setup);
            this.tabControl1.Controls.Add(this.Export);
            this.tabControl1.Controls.Add(this.Import);
            this.tabControl1.Location = new System.Drawing.Point(-4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(813, 394);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Setup
            // 
            this.Setup.Controls.Add(this.groupBox2);
            this.Setup.Controls.Add(this.groupBox1);
            this.Setup.Controls.Add(this.button1);
            this.Setup.Controls.Add(this.label5);
            this.Setup.Controls.Add(this.txtLocalFolder);
            this.Setup.Controls.Add(this.btnOpenFile);
            this.Setup.Controls.Add(this.label1);
            this.Setup.Controls.Add(this.txtTabCmd);
            this.Setup.Location = new System.Drawing.Point(4, 22);
            this.Setup.Name = "Setup";
            this.Setup.Padding = new System.Windows.Forms.Padding(3);
            this.Setup.Size = new System.Drawing.Size(805, 368);
            this.Setup.TabIndex = 0;
            this.Setup.Text = "Setup";
            this.Setup.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImportToServer);
            this.groupBox2.Controls.Add(this.txtImportUserName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtImportPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(6, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 120);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import Information";
            // 
            // txtImportToServer
            // 
            this.txtImportToServer.Location = new System.Drawing.Point(105, 29);
            this.txtImportToServer.Name = "txtImportToServer";
            this.txtImportToServer.Size = new System.Drawing.Size(345, 20);
            this.txtImportToServer.TabIndex = 5;
            this.txtImportToServer.Text = "http://localhost:8000";
            // 
            // txtImportUserName
            // 
            this.txtImportUserName.Location = new System.Drawing.Point(105, 52);
            this.txtImportUserName.Name = "txtImportUserName";
            this.txtImportUserName.Size = new System.Drawing.Size(141, 20);
            this.txtImportUserName.TabIndex = 6;
            this.txtImportUserName.Text = "simple\\flinstone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "User Name";
            // 
            // txtImportPassword
            // 
            this.txtImportPassword.Location = new System.Drawing.Point(105, 76);
            this.txtImportPassword.MaxLength = 50;
            this.txtImportPassword.Name = "txtImportPassword";
            this.txtImportPassword.PasswordChar = '*';
            this.txtImportPassword.Size = new System.Drawing.Size(345, 20);
            this.txtImportPassword.TabIndex = 7;
            this.txtImportPassword.Text = "1LikeBetty!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Import To Server";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExportFromServer);
            this.groupBox1.Controls.Add(this.txtExportUserName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtExportPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 120);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Information";
            // 
            // txtExportFromServer
            // 
            this.txtExportFromServer.Location = new System.Drawing.Point(105, 29);
            this.txtExportFromServer.Name = "txtExportFromServer";
            this.txtExportFromServer.Size = new System.Drawing.Size(345, 20);
            this.txtExportFromServer.TabIndex = 2;
            this.txtExportFromServer.Text = "http://localhost:8000";
            // 
            // txtExportUserName
            // 
            this.txtExportUserName.Location = new System.Drawing.Point(105, 52);
            this.txtExportUserName.Name = "txtExportUserName";
            this.txtExportUserName.Size = new System.Drawing.Size(141, 20);
            this.txtExportUserName.TabIndex = 3;
            this.txtExportUserName.Text = "simple\\flinstone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            // 
            // txtExportPassword
            // 
            this.txtExportPassword.Location = new System.Drawing.Point(105, 76);
            this.txtExportPassword.MaxLength = 50;
            this.txtExportPassword.Name = "txtExportPassword";
            this.txtExportPassword.PasswordChar = '*';
            this.txtExportPassword.Size = new System.Drawing.Size(345, 20);
            this.txtExportPassword.TabIndex = 4;
            this.txtExportPassword.Text = "1LikeBetty!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Export From Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Temp Folder";
            // 
            // txtLocalFolder
            // 
            this.txtLocalFolder.Location = new System.Drawing.Point(103, 32);
            this.txtLocalFolder.Name = "txtLocalFolder";
            this.txtLocalFolder.Size = new System.Drawing.Size(345, 20);
            this.txtLocalFolder.TabIndex = 1;
            this.txtLocalFolder.Text = "c:\\Copy";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(454, 6);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(31, 22);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TabCmd Location";
            // 
            // txtTabCmd
            // 
            this.txtTabCmd.Location = new System.Drawing.Point(103, 6);
            this.txtTabCmd.Name = "txtTabCmd";
            this.txtTabCmd.Size = new System.Drawing.Size(345, 20);
            this.txtTabCmd.TabIndex = 0;
            this.txtTabCmd.Text = "C:\\Program Files (x86)\\Tableau\\Tableau Server\\8.0\\bin\\TabCmd.exe";
            // 
            // Export
            // 
            this.Export.Controls.Add(this.btnDelete2);
            this.Export.Controls.Add(this.dataGridView2);
            this.Export.Controls.Add(this.btnExport);
            this.Export.Controls.Add(this.btnLoadExport);
            this.Export.Location = new System.Drawing.Point(4, 22);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(805, 368);
            this.Export.TabIndex = 2;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            // 
            // btnDelete2
            // 
            this.btnDelete2.Location = new System.Drawing.Point(438, 24);
            this.btnDelete2.Name = "btnDelete2";
            this.btnDelete2.Size = new System.Drawing.Size(203, 23);
            this.btnDelete2.TabIndex = 8;
            this.btnDelete2.Tag = "btnDelete";
            this.btnDelete2.Text = "Remove Selected Workbooks From List";
            this.btnDelete2.UseVisualStyleBackColor = true;
            this.btnDelete2.Click += new System.EventHandler(this.btnDelete2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 66);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 208);
            this.dataGridView2.TabIndex = 7;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(45, 295);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(733, 23);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Export Selected Workbooks To File System";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLoadExport
            // 
            this.btnLoadExport.Location = new System.Drawing.Point(141, 24);
            this.btnLoadExport.Name = "btnLoadExport";
            this.btnLoadExport.Size = new System.Drawing.Size(291, 23);
            this.btnLoadExport.TabIndex = 3;
            this.btnLoadExport.Text = "Load Available Workbooks For Export From Server";
            this.btnLoadExport.UseVisualStyleBackColor = true;
            this.btnLoadExport.Click += new System.EventHandler(this.btnLoadExport_Click);
            // 
            // Import
            // 
            this.Import.Controls.Add(this.btnImport);
            this.Import.Controls.Add(this.btnDelete);
            this.Import.Controls.Add(this.dataGridView1);
            this.Import.Controls.Add(this.btnLoadImport);
            this.Import.Location = new System.Drawing.Point(4, 22);
            this.Import.Name = "Import";
            this.Import.Padding = new System.Windows.Forms.Padding(3);
            this.Import.Size = new System.Drawing.Size(805, 368);
            this.Import.TabIndex = 1;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(27, 296);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(744, 23);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Export Workbooks in List to Server";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(389, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Tag = "btnDelete";
            this.btnDelete.Text = "Remove Selected Workbooks From List";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(27, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 223);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnLoadImport
            // 
            this.btnLoadImport.Location = new System.Drawing.Point(151, 24);
            this.btnLoadImport.Name = "btnLoadImport";
            this.btnLoadImport.Size = new System.Drawing.Size(232, 23);
            this.btnLoadImport.TabIndex = 0;
            this.btnLoadImport.Text = "Load Available Workbooks From File System";
            this.btnLoadImport.UseVisualStyleBackColor = true;
            this.btnLoadImport.Click += new System.EventHandler(this.btnLoadImport_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "TabCmd.exe";
            this.openFileDialog1.Filter = "TabCmd Executable | TabCmd.Exe";
            this.openFileDialog1.InitialDirectory = "C:\\Program Files (x86)\\Tableau\\Tableau Server\\6.1\\bin";
            // 
            // txtOutput
            // 
            this.txtOutput.AcceptsReturn = true;
            this.txtOutput.AcceptsTab = true;
            this.txtOutput.Location = new System.Drawing.Point(829, 27);
            this.txtOutput.MaxLength = 0;
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(364, 368);
            this.txtOutput.TabIndex = 1;
            // 
            // workbookInfo
            // 
            this.workbookInfo.DataSetName = "WorkbookInfo";
            this.workbookInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workbooksBindingSource
            // 
            this.workbooksBindingSource.DataMember = "_workbooks";
            this.workbooksBindingSource.DataSource = this.workbookInfo;
            // 
            // _workbooksTableAdapter
            // 
            this._workbooksTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 411);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "No, I\'m not on the UI team.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Setup.ResumeLayout(false);
            this.Setup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Export.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.Import.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workbookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workbooksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Setup;
        private System.Windows.Forms.TabPage Import;
        private System.Windows.Forms.TabPage Export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTabCmd;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExportFromServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExportPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExportUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocalFolder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private WorkbookInfo workbookInfo;
        private System.Windows.Forms.BindingSource workbooksBindingSource;
        private WorkbookInfoTableAdapters._workbooksTableAdapter _workbooksTableAdapter;
        private System.Windows.Forms.Button btnLoadExport;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtImportToServer;
        private System.Windows.Forms.TextBox txtImportUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImportPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLoadImport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnImport;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDelete2;
    }
}

