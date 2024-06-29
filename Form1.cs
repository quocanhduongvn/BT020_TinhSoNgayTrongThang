using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT020_TinhSoNgayTrongThang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbResuilt.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool nam_nhuan(decimal year)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void btnTinh_Click(object sender, EventArgs e)
        {
            
            decimal soNgay = 0;
            decimal year = numericUpDownYear.Value;
            decimal month = numericUpDownMonth.Value;
            
            if (numericUpDownMonth.Value == 2)
            { 
                

                if (nam_nhuan(year))
                {
                    soNgay = 29;
                  
                }
                else
                {
                    soNgay = 28;
  
                }
            }else if (month ==4| month==6| month==9 | month == 11)
            {
                soNgay = 30;
            }
            else
            {
                soNgay = 31;

            }
            string resuilt = $"Số Ngày Của Tháng {month} Trong Năm {year} là {soNgay}";
            tbResuilt.Text = resuilt;


        }
    }
}
