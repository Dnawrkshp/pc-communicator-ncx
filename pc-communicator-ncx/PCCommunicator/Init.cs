using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using NetCheatX.Core.UI;
using NetCheatX.Core;

namespace PCCommunicator
{
    public partial class Init : XForm
    {
        // Save our ICommunicator and our MemMan for later access
        private Communicator _communicator;
        private MemMan _manager;

        public Init(Communicator com, MemMan man)
        {
            InitializeComponent();

            // Define our private variables
            _communicator = com;
            _manager = man;

            // Refresh list of processes
            butRefresh_Click(null, null);

            splitContainer1_Resize(null, null);
        }

        private void butAttach_Click(object sender, EventArgs e)
        {
            if (listProcess.SelectedIndices.Count == 0)
                return;

            ListViewItem selItem = listProcess.SelectedItems[0];

            // Get Process ID and attach
            int pid = Convert.ToInt32(selItem.SubItems[0].Text, 16);
            bool attach = _manager.Attach(pid);

            // Update ICommuncator's Ready property and, if atached, update lastPID
            if (attach)
            {
                _communicator.lastPID = pid;
                _manager.ContinueProcess();
            }
            _communicator.Ready = attach;
        }

        private void butRefresh_Click(object sender, EventArgs e)
        {
            //_communicator.SetProcessState(Types.ProcessState.Running);

            //listProcess.BeginUpdate();

            listProcess.Items.Clear();

            Process[] procs = Process.GetProcesses();
            procs = procs.OrderBy(a => a.Id).ToArray();
            foreach (Process proc in procs)
            {
                try
                {
                    if (proc.MainWindowTitle != "")
                    {

                    }
                    ListViewItem lvi = new ListViewItem(new string[] { proc.Id.ToString("X8"), proc.ProcessName, proc.MainWindowTitle });
                    listProcess.Items.Add(lvi);
                }
                catch { }
            }

            //listProcess.EndUpdate();
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            int w = (splitContainer1.Panel1.Width - listProcess.Columns[0].Width - 25) / 2;
            listProcess.Columns[1].Width = w;
            listProcess.Columns[2].Width = w;
        }

        private void listProcess_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Rectangle rect = new Rectangle(
                e.Item.SubItems[e.ColumnIndex].Bounds.X,
                e.Item.SubItems[e.ColumnIndex].Bounds.Y,
                listProcess.Columns[e.ColumnIndex].Width,
                e.Item.SubItems[e.ColumnIndex].Bounds.Height);

            e.DrawBackground();
            if (e.ItemState == (ListViewItemStates.Selected | ListViewItemStates.Focused) || e.ItemState == (ListViewItemStates.Selected | ListViewItemStates.Focused | ListViewItemStates.Hot))
                e.Graphics.FillRectangle(Brushes.LightBlue, rect);

            e.Graphics.Clip = new Region(rect);
            e.Graphics.DrawString(e.Item.SubItems[e.ColumnIndex].Text,
                e.Item.SubItems[e.ColumnIndex].Font,
                new SolidBrush(e.Item.SubItems[e.ColumnIndex].ForeColor),
                rect);
        }

        private void listProcess_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

        }
    }
}
