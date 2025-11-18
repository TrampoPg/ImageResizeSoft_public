using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageResizeSoft
{
    public partial class UC_ApplyTypeSelector: UserControl
    {
        public UC_ApplyTypeSelector()
        {
            InitializeComponent();
        }
        public void Init(bool isAll)
        {
            if (isAll)
            {
                this.radioIsAll.Checked = true;
                this.radioIsChecked.Checked = false;
            }
            else
            {
                this.radioIsAll.Checked = false;
                this.radioIsChecked.Checked = true;
            }
        }
        public bool IsAll()
        {
            return this.radioIsAll.Checked;
        }
    }
}
