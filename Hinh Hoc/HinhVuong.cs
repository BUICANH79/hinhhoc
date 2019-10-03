using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_Hoc 
{
    class HinhVuong : HinhCN
    {
        public double chuvi;
        public double dientich;

        public double Canh
        {
            get { return ChieuDai; }
            set { ChieuDai = value; }
        }

        public HinhVuong() { }

        public HinhVuong(double canh)
        {
            ChieuDai = canh;
        }

        public void ChuVi() 
        {
            chuvi = Dai * 4;
        }
        public  void DienTich() 
        {
            dientich = Dai * Dai;
        }
    }
}
