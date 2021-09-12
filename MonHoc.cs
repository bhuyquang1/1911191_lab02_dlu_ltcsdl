using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1911191_Lab02_Bai01
{
    public class MonHoc
    {
        public int id { get; set; }
        public string tenMH { get; set; }
        public int soTC { get; set; }
        public MonHoc()
        {

        }
        public MonHoc(string ten)
        {
            this.tenMH = ten;
        }
        public MonHoc(int id, string ten, int tc)
        {
            this.id = id;
            this.tenMH = ten;
            this.soTC = tc;
        }
        public override string ToString()
        {
            return tenMH;
        }
    }
}
