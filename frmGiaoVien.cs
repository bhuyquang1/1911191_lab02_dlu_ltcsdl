using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1911191_Lab02_Bai01
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienHe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
            this.llbLH.Links.Add(0, lienHe.Length, lienHe);
            this.cbMaSo.SelectedItem = this.cbMaSo.Items[0];
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDSMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMHD.Items.Add(lbDSMH.SelectedItems[i]);
                this.lbDSMH.Items.Remove(lbDSMH.SelectedItems[i]);
                i--;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMHD.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDSMH.Items.Add(lbMHD.SelectedItems[i]);
                this.lbMHD.Items.Remove(lbMHD.SelectedItems[i]);
                i--;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            this.cbMaSo.Text = "";
            this.txtTen.Text = "";
            this.txtMail.Text = "";
            this.mtSoDT.Text = "";
            this.rbNam.Checked = true;
            for (int i = 0; i < clbNgoaiNgu.Items.Count - 1; i++)
            {
                clbNgoaiNgu.SetItemChecked(i, false);
            }
            foreach (object o in this.lbMHD.Items)
            {
                this.lbDSMH.Items.Add(o);
            }
            this.lbMHD.Items.Clear();
        }

        private void llbLH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTB frm = new frmTB();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }
        public GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rbNu.Checked) gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.maSo = this.cbMaSo.Text;
            gv.gioiTinh = gt;
            gv.hoTen = this.txtTen.Text;
            gv.ngaySinh = this.dtNgaySinh.Value;
            gv.eMail = this.txtMail.Text;
            gv.soDT = this.mtSoDT.Text;

            string ngoaingu = "";
            for (int i = 0; i < clbNgoaiNgu.Items.Count - 1; i++)
            {
                if (clbNgoaiNgu.GetItemChecked(i))
                {
                    ngoaingu += clbNgoaiNgu.Items[i] + "; ";
                }
            }
            gv.ngoaiNgu = ngoaingu.Split(';');
            DanhSachMonHoc mh = new DanhSachMonHoc();
            foreach (object o in lbMHD.Items)
            {
                mh.Them(new MonHoc(o.ToString()));
            }
            gv.dsMonHoc = mh;
            return gv;
        }
    }
}
