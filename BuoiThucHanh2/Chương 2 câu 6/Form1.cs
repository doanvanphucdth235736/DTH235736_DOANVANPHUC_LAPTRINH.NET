using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chương_2_câu_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int tong = a - b;

                MessageBox.Show(tong.ToString());
            }
            catch
            {
                MessageBox.Show("Vui long nhap so nguyen hop le!");
            }
        }


        private void btnHieu_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int tong = a - b;

                MessageBox.Show(tong.ToString());
            }
            catch
            {
                MessageBox.Show("Vui long nhap so nguyen hop le!");
            }
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int tong = a * b;

                MessageBox.Show(tong.ToString());
            }
            catch
            {
                MessageBox.Show("Vui long nhap so nguyen hop le!");
            }
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int tong = a / b;

                MessageBox.Show(tong.ToString());
            }
            catch
            {
                MessageBox.Show("Vui long nhap so nguyen hop le!");
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int tong = a + b;

                MessageBox.Show(tong.ToString());
            }
            catch
            {
                MessageBox.Show("Vui long nhap so nguyen hop le!");
            }
        }
    }
}
