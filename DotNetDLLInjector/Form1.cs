using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DLLInjectorYt
{
    public partial class Form1 : Form
    {
        private int _currentPid;

        public Form1()
        {
            InitializeComponent();
            new Thread(DoLoadProcesses).Start();
        }

        private void btn_cliked(object sender, EventArgs e)
        {
            Button source = (Button) sender;

            if (source == btnInject)
                new Thread(DoInject).Start();
            else if (source == btnRevert)
                new Thread(DoRevertInjection).Start();
            else if (source == btnProcess)
                new Thread(DoLoadProcesses).Start();
            else if (source == btnModules)
            {
                new Thread(DoLoadModules).Start();
            }
        }


        private void btnDialog_Click(object sender, EventArgs e)
        {
            //ofd.InitialDirectory = System.Reflection.Assembly.GetEntryAssembly().Location;
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDLLName.Text = ofd.SafeFileName;
                txtDLLPath.Text = ofd.FileName;
            }
        }


        private void lbl_MouseClicked(object sender, MouseEventArgs e)
        {
            Label label = (Label) sender;
            Label pid = (Label) tableProcess.GetControlFromPosition(0, (int) label.Tag);
            txtPID.Text = pid.Text;
            _currentPid = Convert.ToInt32(pid.Text);
            DoLoadModules(Convert.ToInt32(pid.Text));
        }

        void DoRevertInjection()
        {
            Injector.Detach();
        }

        void DoInject()
        {
            Process proc = null;
            try
            {
                proc = Process.GetProcessById(Convert.ToInt32(txtPID.Text));
            }
            catch (Exception ex)
            {
                try
                {
                    proc = Process.GetProcessesByName(txtPID.Text)[0];
                }
                catch (Exception exx)
                {
                }
            }

            if (proc == null)
                return;
            Injector.Inject(txtDLLPath.Text, proc);
        }

        void DoLoadProcesses()
        {
            TruncateProcessTable();
            int rowsInTable = tableProcess.RowCount - 1;
            bool retVal;
            Process[] processes = Process.GetProcesses();
            StringBuilder sb = new StringBuilder();
            int row = 1;
            List<Tuple<int, string, string>> processesSorted = new List<Tuple<int, string, string>>();

            foreach (var process in processes)
            {
                try
                {
                    Injector.IsWow64Process(process.Handle, out retVal);
                    if (process.Id.ToString().Length == 0)
                    {
                        continue;
                    }

                    processesSorted.Add(new Tuple<int, string, string>(process.Id, process.ProcessName,
                        retVal ? "x32" : "x64"));
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine("");
                }
            }

            processesSorted.Sort((first, second) => first.Item1 - second.Item1);

            OnProcessesReady(tableProcess, processesSorted);
        }

        private void TruncateProcessTable()
        {
            ExecuteOnUiThread(tableProcess, () =>
            {
                tableProcess.Controls.Clear();
                lblPID.AutoSize = true;
                lblPID.BackColor = System.Drawing.SystemColors.Info;
                lblPID.Dock = System.Windows.Forms.DockStyle.Fill;
                lblPID.Location = new System.Drawing.Point(1, 1);
                lblPID.Margin = new System.Windows.Forms.Padding(0);
                lblPID.Name = "lblPID";
                lblPID.Size = new System.Drawing.Size(25, 13);
                lblPID.TabIndex = 0;
                lblPID.Text = "PID";

                lblProcName.AutoSize = true;
                lblProcName.BackColor = System.Drawing.SystemColors.Info;
                lblProcName.Dock = System.Windows.Forms.DockStyle.Fill;
                lblProcName.Location = new System.Drawing.Point(27, 1);
                lblProcName.Margin = new System.Windows.Forms.Padding(0);
                lblProcName.Name = "lblProcName";
                lblProcName.Size = new System.Drawing.Size(76, 13);
                lblProcName.TabIndex = 1;
                lblProcName.Text = "Process Name";

                lblArch.AutoSize = true;
                lblArch.BackColor = System.Drawing.SystemColors.Info;
                lblArch.Dock = System.Windows.Forms.DockStyle.Fill;
                lblArch.Location = new System.Drawing.Point(104, 1);
                lblArch.Margin = new System.Windows.Forms.Padding(0);
                lblArch.Name = "lblArch";
                lblArch.Size = new System.Drawing.Size(557, 13);
                lblArch.TabIndex = 2;
                lblArch.Text = "Architecture";

                tableProcess.Controls.Add(lblPID, 0, 0);
                tableProcess.Controls.Add(lblProcName, 1, 0);
                tableProcess.Controls.Add(lblArch, 2, 0);
            });
        }

        void TruncateModulesTable()
        {
            ExecuteOnUiThread(tableModules, () =>
            {
                tableModules.Controls.Clear();
                lblModuleName.AutoSize = true;
                lblModuleName.BackColor = System.Drawing.Color.Coral;
                lblModuleName.Dock = System.Windows.Forms.DockStyle.Fill;
                lblModuleName.Location = new System.Drawing.Point(1, 1);
                lblModuleName.Margin = new System.Windows.Forms.Padding(0);
                lblModuleName.Name = "lblModuleName";
                lblModuleName.Size = new System.Drawing.Size(73, 13);
                lblModuleName.TabIndex = 0;
                lblModuleName.Text = "Module Name";
                // 
                // lblModulePath
                // 
                lblModulePath.AutoSize = true;
                lblModulePath.BackColor = System.Drawing.Color.Coral;
                lblModulePath.Dock = System.Windows.Forms.DockStyle.Fill;
                lblModulePath.Location = new System.Drawing.Point(75, 1);
                lblModulePath.Margin = new System.Windows.Forms.Padding(0);
                lblModulePath.Name = "lblModulePath";
                lblModulePath.Size = new System.Drawing.Size(586, 13);
                lblModulePath.TabIndex = 1;
                lblModulePath.Text = "Path";

                tableModules.Controls.Add(lblModuleName, 0, 0);
                tableModules.Controls.Add(lblModulePath, 1, 0);
            });
        }

        private void DoLoadModules(int pid)
        {
            TruncateModulesTable();
            Process p = Process.GetProcessById(pid);
            ProcessModuleCollection modules = p.Modules;
            int row = 1;
            foreach (ProcessModule processModule in modules)
            {
                Label labelName = new Label();
                labelName.Text = processModule.ModuleName;
                Label labelModulePath = new Label();
                labelModulePath.Dock = System.Windows.Forms.DockStyle.Fill;
                labelName.Dock = System.Windows.Forms.DockStyle.Fill;
                labelModulePath.Text = processModule.FileName;

                var rowCopy = row;
                ExecuteOnUiThread(tableModules, () =>
                {
                    tableModules.Controls.Add(labelName, 0, rowCopy);
                    tableModules.Controls.Add(labelModulePath, 1, rowCopy);
                });

                row++;
            }
        }

        private void DoLoadModules()
        {
            if (_currentPid > 0)
                DoLoadModules(_currentPid);
        }

        delegate void AddRowToTableCallback(TableLayoutPanel table, Label label, int col, int row);

        delegate void ClearTableCallback(TableLayoutPanel table);

        delegate void OnProcessesReadyCallback(TableLayoutPanel table, List<Tuple<int, string, string>> processes);

        internal delegate void ExecuteOnUiThreadProc();

        delegate void ExecuteOnUiThreadCallback(Control control, ExecuteOnUiThreadProc proc);

        internal void ExecuteOnUiThread(Control control, ExecuteOnUiThreadProc proc)
        {
            if (control.InvokeRequired)
            {
                ExecuteOnUiThreadCallback callback = new ExecuteOnUiThreadCallback(ExecuteOnUiThread);
                Invoke(callback, new object[] {control, proc});
            }
            else
            {
                proc();
            }
        }

        internal void OnProcessesReady(TableLayoutPanel table, List<Tuple<int, string, string>> processes)
        {
            if (table.InvokeRequired)
            {
                OnProcessesReadyCallback callback = new OnProcessesReadyCallback(OnProcessesReady);
                Invoke(callback, new object[] {table, processes});
            }
            else
            {
                int rowsInTable = tableProcess.RowCount - 1;
                int row = 1;
                foreach (var process in processes)
                {
                    try
                    {
                        Label pid, name = null, arch = null;
                        if (row < rowsInTable)
                        {
                            pid = (Label) tableProcess.GetControlFromPosition(0, row);
                            name = (Label) tableProcess.GetControlFromPosition(1, row);
                            arch = (Label) tableProcess.GetControlFromPosition(2, row);
                        }
                        else
                        {
                            //Do not exist , create them
                            pid = new Label();
                            pid.Tag = row;
                            tableProcess.Controls.Add(pid, 0, row);

                            name = new Label();
                            name.Tag = row;

                            tableProcess.Controls.Add(name, 1, row);
                            arch = new Label();
                            arch.Tag = row;
                            tableProcess.Controls.Add(arch, 2, row);

                            arch.Dock = System.Windows.Forms.DockStyle.Fill;

                            pid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseClicked);
                            name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseClicked);
                            arch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_MouseClicked);
                        }

                        pid.Text = process.Item1.ToString();
                        name.Text = process.Item2;
                        arch.Text = process.Item3;

                        row++;
                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debug.WriteLine("");
                    }
                }
            }
        }

        internal void AddRowToTable(TableLayoutPanel table, Label label, int col, int row)
        {
            if (table.InvokeRequired)
            {
                AddRowToTableCallback callback = new AddRowToTableCallback(AddRowToTable);
                this.Invoke(callback, new object[] {table, label, col, row});
            }
            else
            {
                table.Controls.Add(label, col, row);
            }
        }

        internal void ClearTable(TableLayoutPanel table)
        {
            if (table.InvokeRequired)
            {
                ClearTableCallback callback = new ClearTableCallback(ClearTable);
                table.Invoke(callback, new object[] {table});
            }
            else
            {
                table.Controls.Clear();
            }
        }
    }
}