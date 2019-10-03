using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_Hoc
{
    class HinhCN : HinhHoc
    {
        protected double ChieuDai;
        private double ChieuRong;

        public double chuvi;
        public double dientich;
        public double Dai
        {
            get {return ChieuDai; }
            set { ChieuDai = value; }
        }

        public double Rong
        {
            get { return ChieuRong; }
            set { ChieuRong = value; }
        }

        public HinhCN(double dai, double rong)
        {
            ChieuDai = dai;
            ChieuRong = rong;
        }

        public HinhCN() { }

        public void  ChuVi() 
        {
            chuvi = (ChieuDai + ChieuRong) * 2;
        }

        public void DienTich() 
        {
            dientich = ChieuDai * ChieuRong;
        }
    }
}
