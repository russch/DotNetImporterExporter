using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;


namespace TabImportExport
{
    public partial class Form1 : Form
    {
        // Used while pushing reports to a server
        DataTable dtable = new WorkbookInfo.WorkbooksToImportDataTable();
        // Used while pulling reports from a server
        DataTable dtable2 = new WorkbookInfo._workbooksDataTable();
        // Used to update text window
        StringBuilder sb3 = new StringBuilder();

        // variables to hold server names, passwords, etc.
        private string m_ExportServer;
        private string m_ExportUserName;
        private string m_ExportPassword;
        private string m_ImportServer;
        private string m_ImportUserName;
        private string m_ImportPassword;
        private string m_TabCmd;
        private string m_TempFolder;




#region Threading Stuff

        delegate void SetTextCallback(string text);

        // This thread is used to for thread-safe calls to update the UI thread
        private Thread demoThread = null;

        private void SafeTextUpdate()
        {
            this.SetText(sb3.ToString());
        }


         private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtOutput.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtOutput.Text= text;
                this.txtOutput.SelectionStart = this.txtOutput.Text.Length;
                this.txtOutput.ScrollToCaret();
                
            }
        }

        // Used to call the main Import procedure on it's own thread 
        private void ImportBooksHelper(object obj)
         {
             DataTable dt = (DataTable)obj;
             ImportWorkbooks(dt);
         }
        
        // Used to call the main Export procedure on it's own thread 
         private void ExportBooksHelper(object obj)
         {
             DataTable dt = (DataTable)obj;
             ExportWorkbooks(dt);
         }
#endregion
      
        public Form1()
        {
            InitializeComponent();

        }

#region Helper Functions
        
        // Build string used for TabCmd Login
        public string BuildLoginString(string TabCmdLocation, string UserName, string Password, string Server)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\"");
            sb.Append(TabCmdLocation);
            sb.Append("\"");
            sb.Append(" login  ");
            sb.Append("-u " + UserName);
            sb.Append(" -p " + Password);
            sb.Append(" -s " + Server);
            return sb.ToString();
        }

        // Build string used for TabCmd GET
        public string BuildGETString(string TabCmdLocation, string Workbook, string WorkbookURL, string Destination, string ProjectPath)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("\"");
            sb.Append(TabCmdLocation);
            sb.Append("\"");
            sb.Append(" GET ");
            //sb.Append("\"");
            sb.Append("/workbooks/");
            sb.Append(WorkbookURL);
            sb.Append(".twbx");
            //sb.Append("\"");
            sb.Append(" -f ");
            sb.Append("\"");
            sb.Append(Destination + @"\" + ProjectPath);
            sb.Append(@"\" + Workbook);
            sb.Append(".twbx");
            sb.Append("\"");
            return sb.ToString();

        }

        // Build string to TabCmd CreateProject
        public string CreateServerProjectsString(string Project, string TabCmdLocation)
        {


            StringBuilder sb = new StringBuilder();
            sb.Append("\"");
            sb.Append(TabCmdLocation);
            sb.Append("\"");
            sb.Append(" CreateProject  -n ");
            sb.Append("\"");
            sb.Append(Project);
            sb.Append("\" -d ");
            sb.Append("\"");
            sb.Append("\"");
            return sb.ToString();


        }

        // Build string to TabCmd Publish
        public string BuildPublishString(string TabCmdLocation, string Name, string UID, string Password, string Project)
        {

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("\"");
            sb1.Append(TabCmdLocation);
            sb1.Append("\"");
            sb1.Append(" PUBLISH ");
            sb1.Append("\"");
            sb1.Append(Name);
            sb1.Append("\" -o -r ");
            sb1.Append("\"");
            sb1.Append(Project);
            sb1.Append("\"");


            if (!string.IsNullOrEmpty(UID) && !string.IsNullOrEmpty(Password))
            {
                sb1.Append(" --db-user ");
                sb1.Append("\"");
                sb1.Append(UID);
                sb1.Append("\"");
                sb1.Append(" --db-password ");
                sb1.Append("\"");
                sb1.Append(Password);
                sb1.Append("\"");

            }




            return sb1.ToString();

        }

        // Deal with Cmd-line output 
        private void cmd_DataReceived(object sender, DataReceivedEventArgs e)
        {
            //MessageBox.Show("Output from other process");
            try
            {

                sb3.AppendLine(e.Data.ToString());

                this.demoThread = new Thread(new ThreadStart(this.SafeTextUpdate));
                this.demoThread.Start();
                Console.WriteLine(e.Data.ToString());

            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);


            }
            
        }
        
        // Deal with Cmd-Line output on errors
        private void cmd_Error(object sender, DataReceivedEventArgs e)
        {
            try
            {

                sb3.AppendLine(e.Data.ToString());
                this.demoThread = new Thread(new ThreadStart(this.SafeTextUpdate));
                this.demoThread.Start();
                Console.WriteLine(e.Data.ToString());

            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }

        // Read temp folder to get list of projects & twbxs that can be published
        public DataTable GetWorkbooks()
        {
            string[] Folders;
            try
            {
                DataTable _dtable = new WorkbookInfo.WorkbooksToImportDataTable();
                Folders = System.IO.Directory.GetDirectories(txtLocalFolder.Text, "*");
                foreach (string folder in Folders)
                {
                    string[] Files = System.IO.Directory.GetFiles(folder);
                    foreach (string file in Files)
                    {
                        DataRow dr = _dtable.NewRow();
                        dr["Name"] = file.ToString();
                        Regex regex = new Regex(@"[^\\]+(?=\\[^\\]+$)");
                        MatchCollection matches = regex.Matches(file);
                        dr["Project"] = matches[0].Value.ToString();
                        dr["Owner"] = "Unpublished";
                        _dtable.Rows.Add(dr);
                    }

                }
                return _dtable;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }




        }

        // TabCmd GET workbooks on the server
        public void ExportWorkbooks(DataTable dtable2)
        {

            ProcessStartInfo cmdStartInfo = new ProcessStartInfo();
            cmdStartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            cmdStartInfo.RedirectStandardOutput = true;
            cmdStartInfo.RedirectStandardError = true;
            cmdStartInfo.RedirectStandardInput = true;
            cmdStartInfo.UseShellExecute = false;
            cmdStartInfo.CreateNoWindow = true;

            Process cmdProcess = new Process();
            cmdProcess.StartInfo = cmdStartInfo;
            cmdProcess.ErrorDataReceived += cmd_Error;
            cmdProcess.OutputDataReceived += cmd_DataReceived;
            cmdProcess.EnableRaisingEvents = true;
            cmdProcess.Start();
            cmdProcess.BeginOutputReadLine();
            cmdProcess.BeginErrorReadLine();

            //Login
            cmdProcess.StandardInput.WriteLine(BuildLoginString(m_TabCmd, m_ExportUserName, m_ExportPassword, m_ExportServer));     //Execute ping bing.com


            foreach (DataRow dr in dtable2.Rows)
            {
                //  Check to see if the Project folder exists on the filesystem for this object, else create it
                CheckProjectFolder(txtLocalFolder.Text, dr["project_name"].ToString());
                //  Export Workbook
                cmdProcess.StandardInput.WriteLine(BuildGETString(m_TabCmd, dr["name"].ToString(), dr["workbook_url"].ToString(), m_TempFolder, dr["project_name"].ToString()));

            }

            cmdProcess.StandardInput.WriteLine("exit");                  //Execute exit.

            cmdProcess.EnableRaisingEvents = false;


        }

        // TabCmd Publish workbooks to a server
        public void ImportWorkbooks(DataTable dt)
        {

            ProcessStartInfo cmdStartInfo = new ProcessStartInfo();
            cmdStartInfo.FileName = @"C:\Windows\System32\cmd.exe";
            cmdStartInfo.RedirectStandardOutput = true;
            cmdStartInfo.RedirectStandardError = true;
            cmdStartInfo.RedirectStandardInput = true;
            cmdStartInfo.UseShellExecute = false;
            cmdStartInfo.CreateNoWindow = true;

            Process cmdProcess = new Process();
            cmdProcess.StartInfo = cmdStartInfo;
            cmdProcess.ErrorDataReceived += cmd_Error;
            cmdProcess.OutputDataReceived += cmd_DataReceived;
            cmdProcess.EnableRaisingEvents = true;
            cmdProcess.Start();
            cmdProcess.BeginOutputReadLine();
            cmdProcess.BeginErrorReadLine();

            //Login
         
            cmdProcess.StandardInput.WriteLine(BuildLoginString(m_TabCmd, m_ImportUserName, m_ImportPassword, m_ImportServer));


            // Create Projects First
            // Get Distinct Project across all rows

            DataView view = new DataView(dt);
            DataTable distinctValues = view.ToTable(true, "Project");
            foreach (DataRow dr in distinctValues.Rows)
            {
                // There is no way to test for the existence of a Project, so just 
                // create it and ignore 406 errors which indicate said project
                // already exists.

                cmdProcess.StandardInput.WriteLine(CreateServerProjectsString(dr["Project"].ToString(), m_TabCmd));
            }

            // Import Workbooks
            foreach (DataRow dr in dt.Rows)
            {

                cmdProcess.StandardInput.WriteLine(BuildPublishString(txtTabCmd.Text, dr["Name"].ToString(), dr["UID"].ToString(), dr["Password"].ToString(), dr["Project"].ToString()));
            }




            cmdProcess.StandardInput.WriteLine("exit");                  //Execute exit.

            cmdProcess.EnableRaisingEvents = false;

          
        }

        public void CheckProjectFolder(string txtLocalFolder, string ProjectPath)
        {

            string activeDir = @m_TempFolder;
            //Create a new subfolder under the current active folder
            string newPath = System.IO.Path.Combine(activeDir, ProjectPath);

            if (System.IO.Directory.Exists(newPath) == false)
            {
                try
                {
                    System.IO.Directory.CreateDirectory(newPath);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                }


            }
            ;
        }

# endregion      

#region Respond to UI activity
        private void button4_Click(object sender, EventArgs e)
        {

            txtOutput.Clear();
            //Begin Export Workbook  

                ThreadPool.QueueUserWorkItem(ExportBooksHelper, dataGridView2.DataSource);

            }
     
        private void btnLoadImport_Click(object sender, EventArgs e)
        {
            //Enumerate folders
            
            dtable = GetWorkbooks();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dtable;
            dataGridView1.Refresh();
            dataGridView1.Columns[0].Width = 280;


        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count <= dataGridView1.Rows.Count )
            {

                foreach (DataGridViewRow dgvrCurrent in dataGridView1.SelectedRows)
                {
                    this.dataGridView1.Rows.RemoveAt(dgvrCurrent.Index);
                }

            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
             txtOutput.Clear();
            ThreadPool.QueueUserWorkItem(ImportBooksHelper, dtable);

        }

        private void btnDelete2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(this.dataGridView2.Rows.Count.ToString());
            if (this.dataGridView2.SelectedRows.Count <= dataGridView2.Rows.Count)
            {

                foreach (DataGridViewRow dgvrCurrent in dataGridView2.SelectedRows)
                {
                    this.dataGridView2.Rows.RemoveAt(dgvrCurrent.Index);
                    
                  //  MessageBox.Show(this.dataGridView2.Rows.Count.ToString());
                }
                dtable2.AcceptChanges();

            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {

            // Show Open File dialog to locate TabCmd
            DialogResult result = openFileDialog1.ShowDialog();
            txtTabCmd.Text = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show Browser Dialog to locate "temp" folder that we copy from/to
            DialogResult result = folderBrowserDialog1.ShowDialog();
            txtLocalFolder.Text = folderBrowserDialog1.SelectedPath;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnLoadExport_Click(object sender, EventArgs e)
        {
            // Load workbooks on server that can be exported

            try
            {
                // Pull data from workgroups database in postgreSQL & show in datagrid
                DataTable m_dt = this._workbooksTableAdapter.GetData();
                dtable2 = m_dt;
                dataGridView2.DataSource = dtable2;
                dataGridView2.Refresh();
                dataGridView2.Columns[0].Width = 150;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Assign setup values needed by procs which will be running on another thread
            m_ExportServer = txtExportFromServer.Text;
            m_ExportUserName = txtExportUserName.Text;
            m_ExportPassword = txtExportPassword.Text;
            m_ImportServer = txtImportToServer.Text;
            m_ImportUserName = txtImportUserName.Text;
            m_ImportPassword = txtImportPassword.Text;
            m_TabCmd = txtTabCmd.Text;
            m_TempFolder = txtLocalFolder.Text;

         

        }

        

        #endregion



    }
}
