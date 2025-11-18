using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizeSoft
{
    public partial class ProgressDialogForm : Form
    {
        string title;

        public ProgressDialogForm(string title)
        {
            this.title = title;
            InitializeComponent();
        }

        public void SetProgressMax(int maxNum)
        {
            this.progressBar.Minimum = 0;
            this.progressBar.Maximum = maxNum;
        }

        public void IncrementProgressValue()
        {
            ++this.progressBar.Value;
        }

        public void SetProcessName(string processName)
        {
            this.processNameLabel.Text = processName;
            this.processNameLabel.Refresh();
        }

        public void SetItemName(string itemName)
        {
            this.itemLabel.Text = itemName;
            this.itemLabel.Refresh();
        }

        private void ProgressDialogForm_Load(object sender, EventArgs e)
        {
            this.Text = this.title;
            this.processNameLabel.Text = this.title;
        }
    }
}
