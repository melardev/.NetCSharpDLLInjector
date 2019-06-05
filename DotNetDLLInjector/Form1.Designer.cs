namespace DLLInjectorYt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInject = new System.Windows.Forms.Button();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.txtDLLPath = new System.Windows.Forms.TextBox();
            this.txtDLLName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDialog = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tableProcess = new System.Windows.Forms.TableLayoutPanel();
            this.lblPID = new System.Windows.Forms.Label();
            this.lblProcName = new System.Windows.Forms.Label();
            this.lblArch = new System.Windows.Forms.Label();
            this.splitProcess = new System.Windows.Forms.SplitContainer();
            this.tableModules = new System.Windows.Forms.TableLayoutPanel();
            this.lblModuleName = new System.Windows.Forms.Label();
            this.lblModulePath = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.btnRevert = new System.Windows.Forms.Button();
            this.tableProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitProcess)).BeginInit();
            this.splitProcess.Panel1.SuspendLayout();
            this.splitProcess.Panel2.SuspendLayout();
            this.splitProcess.SuspendLayout();
            this.tableModules.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInject
            // 
            this.btnInject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInject.Image = global::DLLInjectorYt.Res.inject;
            this.btnInject.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnInject.Location = new System.Drawing.Point(35, 143);
            this.btnInject.Name = "btnInject";
            this.btnInject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInject.Size = new System.Drawing.Size(114, 39);
            this.btnInject.TabIndex = 0;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.btn_cliked);
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(21, 38);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(148, 20);
            this.txtPID.TabIndex = 1;
            this.txtPID.Text = "Hooked";
            // 
            // txtDLLPath
            // 
            this.txtDLLPath.Location = new System.Drawing.Point(21, 88);
            this.txtDLLPath.Name = "txtDLLPath";
            this.txtDLLPath.Size = new System.Drawing.Size(217, 20);
            this.txtDLLPath.TabIndex = 2;
            this.txtDLLPath.Text = "D:\\workspace\\VS2015\\Hooks\\Release\\Hooker.dll";
            this.txtDLLPath.DoubleClick += new System.EventHandler(this.btnDialog_Click);
            // 
            // txtDLLName
            // 
            this.txtDLLName.Enabled = false;
            this.txtDLLName.Location = new System.Drawing.Point(21, 115);
            this.txtDLLName.Name = "txtDLLName";
            this.txtDLLName.Size = new System.Drawing.Size(100, 20);
            this.txtDLLName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Process Name or PID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DLL Name";
            // 
            // btnDialog
            // 
            this.btnDialog.Location = new System.Drawing.Point(244, 84);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(32, 23);
            this.btnDialog.TabIndex = 7;
            this.btnDialog.Text = "...";
            this.btnDialog.UseVisualStyleBackColor = true;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "ofd";
            // 
            // tableProcess
            // 
            this.tableProcess.AutoScroll = true;
            this.tableProcess.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableProcess.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableProcess.ColumnCount = 3;
            this.tableProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableProcess.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableProcess.Controls.Add(this.lblPID, 0, 0);
            this.tableProcess.Controls.Add(this.lblProcName, 1, 0);
            this.tableProcess.Controls.Add(this.lblArch, 2, 0);
            this.tableProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableProcess.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tableProcess.Location = new System.Drawing.Point(0, 0);
            this.tableProcess.Name = "tableProcess";
            this.tableProcess.RowCount = 2;
            this.tableProcess.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableProcess.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableProcess.Size = new System.Drawing.Size(662, 212);
            this.tableProcess.TabIndex = 8;
            
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.BackColor = System.Drawing.SystemColors.Info;
            this.lblPID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPID.Location = new System.Drawing.Point(1, 1);
            this.lblPID.Margin = new System.Windows.Forms.Padding(0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(25, 13);
            this.lblPID.TabIndex = 0;
            this.lblPID.Text = "PID";
            // 
            // lblProcName
            // 
            this.lblProcName.AutoSize = true;
            this.lblProcName.BackColor = System.Drawing.SystemColors.Info;
            this.lblProcName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcName.Location = new System.Drawing.Point(27, 1);
            this.lblProcName.Margin = new System.Windows.Forms.Padding(0);
            this.lblProcName.Name = "lblProcName";
            this.lblProcName.Size = new System.Drawing.Size(76, 13);
            this.lblProcName.TabIndex = 1;
            this.lblProcName.Text = "Process Name";
            // 
            // lblArch
            // 
            this.lblArch.AutoSize = true;
            this.lblArch.BackColor = System.Drawing.SystemColors.Info;
            this.lblArch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArch.Location = new System.Drawing.Point(104, 1);
            this.lblArch.Margin = new System.Windows.Forms.Padding(0);
            this.lblArch.Name = "lblArch";
            this.lblArch.Size = new System.Drawing.Size(557, 13);
            this.lblArch.TabIndex = 2;
            this.lblArch.Text = "Architecture";
            // 
            // splitProcess
            // 
            this.splitProcess.Location = new System.Drawing.Point(282, 12);
            this.splitProcess.Name = "splitProcess";
            this.splitProcess.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitProcess.Panel1
            // 
            this.splitProcess.Panel1.Controls.Add(this.tableProcess);
            // 
            // splitProcess.Panel2
            // 
            this.splitProcess.Panel2.Controls.Add(this.tableModules);
            this.splitProcess.Size = new System.Drawing.Size(662, 424);
            this.splitProcess.SplitterDistance = 212;
            this.splitProcess.TabIndex = 9;
            // 
            // tableModules
            // 
            this.tableModules.AutoScroll = true;
            this.tableModules.BackColor = System.Drawing.Color.Honeydew;
            this.tableModules.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableModules.ColumnCount = 2;
            this.tableModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableModules.Controls.Add(this.lblModuleName, 0, 0);
            this.tableModules.Controls.Add(this.lblModulePath, 1, 0);
            this.tableModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableModules.Location = new System.Drawing.Point(0, 0);
            this.tableModules.Name = "tableModules";
            this.tableModules.RowCount = 2;
            this.tableModules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableModules.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableModules.Size = new System.Drawing.Size(662, 208);
            this.tableModules.TabIndex = 0;
            // 
            // lblModuleName
            // 
            this.lblModuleName.AutoSize = true;
            this.lblModuleName.BackColor = System.Drawing.Color.Coral;
            this.lblModuleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModuleName.Location = new System.Drawing.Point(1, 1);
            this.lblModuleName.Margin = new System.Windows.Forms.Padding(0);
            this.lblModuleName.Name = "lblModuleName";
            this.lblModuleName.Size = new System.Drawing.Size(73, 13);
            this.lblModuleName.TabIndex = 0;
            this.lblModuleName.Text = "Module Name";
            // 
            // lblModulePath
            // 
            this.lblModulePath.AutoSize = true;
            this.lblModulePath.BackColor = System.Drawing.Color.Coral;
            this.lblModulePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModulePath.Location = new System.Drawing.Point(75, 1);
            this.lblModulePath.Margin = new System.Windows.Forms.Padding(0);
            this.lblModulePath.Name = "lblModulePath";
            this.lblModulePath.Size = new System.Drawing.Size(586, 13);
            this.lblModulePath.TabIndex = 1;
            this.lblModulePath.Text = "Path";
            // 
            // btnProcess
            // 
            this.btnProcess.BackgroundImage = global::DLLInjectorYt.Res.refresh;
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcess.Location = new System.Drawing.Point(232, 143);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(44, 39);
            this.btnProcess.TabIndex = 10;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btn_cliked);
            // 
            // btnModules
            // 
            this.btnModules.BackgroundImage = global::DLLInjectorYt.Res.refresh;
            this.btnModules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModules.Location = new System.Drawing.Point(232, 313);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(44, 39);
            this.btnModules.TabIndex = 11;
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btn_cliked);
            // 
            // btnRevert
            // 
            this.btnRevert.Location = new System.Drawing.Point(39, 201);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(110, 23);
            this.btnRevert.TabIndex = 12;
            this.btnRevert.Text = "revert last Injection";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btn_cliked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 440);
            this.Controls.Add(this.btnRevert);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.splitProcess);
            this.Controls.Add(this.btnDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDLLName);
            this.Controls.Add(this.txtDLLPath);
            this.Controls.Add(this.txtPID);
            this.Controls.Add(this.btnInject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableProcess.ResumeLayout(false);
            this.tableProcess.PerformLayout();
            this.splitProcess.Panel1.ResumeLayout(false);
            this.splitProcess.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitProcess)).EndInit();
            this.splitProcess.ResumeLayout(false);
            this.tableModules.ResumeLayout(false);
            this.tableModules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.TextBox txtDLLPath;
        private System.Windows.Forms.TextBox txtDLLName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TableLayoutPanel tableProcess;
        private System.Windows.Forms.SplitContainer splitProcess;
        private System.Windows.Forms.TableLayoutPanel tableModules;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.Label lblProcName;
        private System.Windows.Forms.Label lblArch;
        private System.Windows.Forms.Label lblModuleName;
        private System.Windows.Forms.Label lblModulePath;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnRevert;
    }
}

