using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                // 타입.Parse()
                short sNumeber = short.Parse(tboxNumber.Text);   //tboxNumber에 적힌 Text값을 short로

                lblShort.Text = sNumeber.ToString();
                lblException.Text = "-";

            }
            catch(Exception ex)    //예외처리
            {
                lblException.Text = ex.ToString(); 
            }
             
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int iNumeber = int.Parse(tboxNumber.Text);   

                lblInt.Text = iNumeber.ToString();
                lblException.Text = "-";

            }
            catch (Exception ex)    //예외처리
            {
                lblException.Text = ex.ToString();
            }

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                int dNumeber = int.Parse(tboxNumber.Text);  

                lblDouble.Text = dNumeber.ToString();
                lblException.Text = "-";

            }
            catch (Exception ex)    //예외처리
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            short sNumber = 0;
            int iNumber = 0;
            double dNumber = 0;

            tboxNumber.Text = "-";

            if(short.TryParse(tboxNumber.Text, out sNumber))    // tboxNumber의 Text가 short 타입에 해당하면 short로 반환됨
            {
                lblShort.Text = sNumber.ToString();
            }
            else if(int.TryParse(tboxNumber.Text, out iNumber))
            {
                lblInt.Text = iNumber.ToString();
            }
            else if(double.TryParse(tboxNumber.Text, out dNumber))
            {
                lblDouble.Text = dNumber.ToString();
            }
            else
            {
                lblException.Text = "변환할 수 없습니다";
            }
        }
    }
}
