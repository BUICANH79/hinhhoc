using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btnok_Click(object sender, RoutedEventArgs e)
        {
            HinhCn hcn = new HinhCn(4, 3);

            hcn.ChuVi();
            hcn.DienTich();
            MessageBox.Show("Chu vi hinh chu nhat: " + hcn.chuvi.ToString()
                            + "\nDien Tich hinh chu nhat: " + hcn.dientich.ToString());

            HinhVuong hv = new HinhVuong(3);
            hv.ChuVi();
            hv.DienTich();
            MessageBox.Show("Chu vi hinh vuong: " + hv.chuvi.ToString()
                            + "\nDien Tich hinh vuong: " + hv.dientich.ToString());
            HinhTron ht = new HinhTron(3);
            ht.ChuVi();
            ht.DienTich();
            MessageBox.Show("Chu vi hinh tron: " + ht.chuvi.ToString()
                            + "\nDien Tich hinh tron: " + ht.dientich.ToString());


            List<HinhVuong> hinhvuongList = new List<HinhVuong>();
            hinhvuongList.Add(new HinhVuong());

            foreach (HinhVuong hvuong in hinhvuongList)
            {
                lst2.Items.Add(hv.Canh);
                lst3.Items.Add(hv.chuvi);
                lst4.Items.Add(hv.dientich);
            }


            /* 
             HinhVuong[] hinhvuongList = new HinhVuong[3];
             hinhvuongList[0] = new HinhVuong();
             // Nhập tên sinh viên thứ hai
             hinhvuongList[1] = new HinhVuong();
             // Nhập tên sinh viên thứ ba
             hinhvuongList[2] = new HinhVuong();
             //Hiển thị thông tin các sinh viên trong ListBox
             // với thuộc tính Name là lst
             for (int i = 0; i < 3; i++)
             {
                 lst.Items.Add(hinhvuongList[i].Canh);
                 lst.Items.Add(hinhvuongList[i].chuvi);
                 lst.Items.Add(hinhvuongList[i].dientich);
             }

     */
            //Hinhtron
            List<HinhTron> hinhtronList = new List<HinhTron>();
            hinhtronList.Add(new HinhTron());
            foreach (HinhTron st in hinhtronList)
            {
                lst2.Items.Add(ht.Bankinh);
                lst3.Items.Add(ht.chuvi);
                lst4.Items.Add(ht.dientich);

                lst.Items.Add("1");
                lst.Items.Add("2");
            }

        }
    }
}