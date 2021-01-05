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
    }
}
