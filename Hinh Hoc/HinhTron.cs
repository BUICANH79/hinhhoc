using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_Hoc
{
    class HinhTron : HinhHoc
    {
        const double pi = 3.14;
        private double r;

        public double chuvi;
        public double dientich;

        public double BanKinh
        {
            get { return r; }
            set { r = value; }
        }

        public HinhTron(){}
        public HinhTron(double r) 
        {
            this.r = r;
        }
        public void ChuVi()
        {
            chuvi = r * 2 * pi;
        }

        public void DienTich()
        {
            dientich = 2 * pi * (r * r);
        }

    }
}
