using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeat_study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            tboxResult.Text = string.Empty;

            StringBuilder sb = new StringBuilder();   // 자주 변경되는 string을 다룰때 효율적

            int iResult = 0;
            for (int i = 0; i < 10; i++)
            {
                iResult += 1;

                sb.Append(string.Format("1에서 {0}까지 더하면 {1} \r\n",i,iResult));
            }

            tboxResult.Text = sb.ToString();

        }

        private void btnforeach_Click(object sender, EventArgs e)
        {
            tboxResult.Text = string.Empty;

            StringBuilder sb = new StringBuilder();

            string[] strArray = {"나연","지효","정연","사나","모모","미나","채영","다현","쯔위"};

            int i = 0;
            
            // 배열의 요소를 하나씩 가져옴
            foreach (var oValue in strArray)
            {
                i++;
                sb.Append(string.Format("{0} 선생님은 {1}반 입니다.\r\n", oValue,i));
                
            }
            tboxResult.Text = sb.ToString();
        }
    }
}
