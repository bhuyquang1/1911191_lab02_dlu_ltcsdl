using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911191_Lab02_Bai01
{
    public partial class frmTB : Form
    {
        public frmTB()
        {
            InitializeComponent();
        }
        public void SetText(string s)
        {
            this.lblTB.Text = s;
        }
    }
}
