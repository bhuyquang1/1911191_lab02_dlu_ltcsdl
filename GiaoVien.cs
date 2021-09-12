using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911191_Lab02_Bai01
{
    public class GiaoVien
    {
        public string maSo { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh;
        public DanhSachMonHoc dsMonHoc;
        public string gioiTinh;
        public string[] ngoaiNgu;
        public string soDT;
        public string eMail;
        public GiaoVien()
        {
            dsMonHoc = new DanhSachMonHoc();
            ngoaiNgu = new string[10];
        }
        public GiaoVien(string ma, string ten, DateTime ngs, DanhSachMonHoc ds, string gt,
            string []nn, string sdt, string mail)
        {
            maSo = ma;
            hoTen = ten;
            ngaySinh = ngs;
            dsMonHoc = ds;
            gioiTinh = gt;
            ngoaiNgu = nn;
            soDT = sdt;
            eMail = mail;
        }
        public override string ToString()
        {
            string sInfo = "Mã số: " + maSo + "\nHọ tên: " + hoTen + "\nNgày sinh: "
                + ngaySinh.ToString() + "\nGiới tính: " + gioiTinh
                + "\nSố điện thoại: " + soDT
                + "\nMail: " + eMail + "\n";
            string sNN = "Ngoại ngữ: ";
            foreach (string t in ngoaiNgu)
            {
                sNN += t + ";";
            }
            string sMD = "Môn dạy: ";
            foreach (MonHoc mh in dsMonHoc.ds)
                sMD += mh + ";";
            return sInfo + "\n" + sNN + "\n" + sMD;
        }
    }
}
