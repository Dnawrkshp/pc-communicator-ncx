namespace PCCommunicator
{
    partial class Init
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
            this.listProcess = new MetroFramework.Controls.MetroListView();
            this.butAttach = new MetroFramework.Controls.MetroButton();
            this.butRefresh = new MetroFramework.Controls.MetroButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProcess
            // 
            this.listProcess.AllowSorting = true;
            this.listProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listProcess.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listProcess.FullRowSelect = true;
            this.listProcess.GridLines = true;
            this.listProcess.HideSelection = false;
            this.listProcess.LabelWrap = false;
            this.listProcess.Location = new System.Drawing.Point(0, 0);
            this.listProcess.MultiSelect = false;
            this.listProcess.Name = "listProcess";
            this.listProcess.OwnerDraw = true;
            this.listProcess.Size = new System.Drawing.Size(525, 390);
            this.listProcess.TabIndex = 3;
            this.listProcess.UseCompatibleStateImageBehavior = false;
            this.listProcess.UseSelectable = true;
            this.listProcess.View = System.Windows.Forms.View.Details;
            this.listProcess.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listProcess_DrawItem);
            this.listProcess.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listProcess_DrawSubItem);
            // 
            // butAttach
            // 
            this.butAttach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butAttach.Location = new System.Drawing.Point(0, 0);
            this.butAttach.Name = "butAttach";
            this.butAttach.Size = new System.Drawing.Size(262, 33);
            this.butAttach.TabIndex = 4;
            this.butAttach.Text = "Attach";
            this.butAttach.Theme = MetroFramework.MetroThemeStyle.Light;
            this.butAttach.UseSelectable = true;
            this.butAttach.Click += new System.EventHandler(this.butAttach_Click);
            // 
            // butRefresh
            // 
            this.butRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butRefresh.Location = new System.Drawing.Point(0, 0);
            this.butRefresh.Name = "butRefresh";
            this.butRefresh.Size = new System.Drawing.Size(259, 33);
            this.butRefresh.TabIndex = 5;
            this.butRefresh.Text = "Refresh";
            this.butRefresh.UseSelectable = true;
            this.butRefresh.Click += new System.EventHandler(this.butRefresh_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listProcess);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(525, 427);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 6;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.butAttach);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.butRefresh);
            this.splitContainer2.Size = new System.Drawing.Size(525, 33);
            this.splitContainer2.SplitterDistance = 262;
            this.splitContainer2.TabIndex = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "PID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Window";
            this.columnHeader3.Width = 300;
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 427);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Init";
            this.Text = " Attach Process";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listProcess;
        private MetroFramework.Controls.MetroButton butAttach;
        private MetroFramework.Controls.MetroButton butRefresh;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}