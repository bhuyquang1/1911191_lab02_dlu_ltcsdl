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
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            this.cbMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtNgayDK.Value = DateTime.Now;
            this.rbNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
                s += int.Parse(lblTHA.Text.Split('.')[0]);
            if (chkTinHocB.Checked)
                s += int.Parse(lblTHB.Text.Split('.')[0]);
            if (chkTiengAnhA.Checked)
                s += int.Parse(lblAVA.Text.Split('.')[0]);
            if (chkTiengAnhB.Checked)
                s += int.Parse(lblAVB.Text.Split('.')[0]);
            this.txtTongTien.Text = s + ".000 đ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
