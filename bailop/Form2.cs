using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bailop
{
    public partial class Form2 : Form
    {
        double KQ;
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string pheptinh = txtPhepTinh.Text;
            switch (pheptinh)
            {
            }
        }
        private void Cong_click()
        {

        }
        private void Tru_click()
        {

        }
        private void Nhan_click()
        {

        }
        private void Chia_click()
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                float a = int.Parse(txta.Text);
                float b = int.Parse(txtb.Text);
                float kq = a + b;
                txtKetQua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                float a = int.Parse(txta.Text);
                float b = int.Parse(txtb.Text);
                float kq = a - b;
                txtKetQua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                float a = int.Parse(txta.Text);
                float b = int.Parse(txtb.Text);
                float kq = a * b;
                txtKetQua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                float a = int.Parse(txta.Text);
                float b = int.Parse(txtb.Text);
                float kq = a / b;
                txtKetQua.Text = kq.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("bạn có muốn thoát ứng dụng", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            ;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double soA = double.Parse(txta.Text);
            double soB = double.Parse(txtb.Text);
          
            if (soA != 0)
            {
                KQ = soB / soA;
                txtKQ.Text = "Phương trình có 1 nghiệm duy nhất là : " + KQ;
            }
            if (soA == 0 && soB != 0)
            {
                txtKQ.Text = "Phương trình vô nghiệm";
            }
            if (soA == 0 && soB == 0)
            {
                txtKQ.Text = "Phương trình có nghiệm ứng với mọi x";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (KQ % 2 != 0)
            {

                txtKQCL.Text = "Đây là số lẻ";
            }
            else
            {
                txtKQCL.Text = "Đây là số chẳn";
            }
        }
       
    }
}
