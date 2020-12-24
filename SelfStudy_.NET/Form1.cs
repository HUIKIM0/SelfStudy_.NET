using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfStudy_.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string strText = lblText.Text;  //Sample, Test, Text

            //lblContain의 텍스트에 변화를 준다
            lblContain.Text = strText.Contains("Text").ToString(); //Text라는 글씨는 lblText에 있으므로 True
            lblEquals.Text = strText.Equals("Text").ToString();
            lblLength.Text = strText.Length.ToString();
            lblReplace.Text = strText.Replace("Text", "Good");


            string[] strSplit = strText.Split(',');  //0~2. 3개
            lblSplit1.Text = strSplit[0];   //Sample
            lblSplit2.Text = strSplit[1];   // Text
            lblSplit3.Text = strSplit[2];   // Text

            lblSubstring.Text = strText.Substring(3,5);  //3번째부터 시작 5글자 가져온다
            lblToLower.Text = strText.ToLower();
            lblToUpper.Text = strText.ToUpper();
            lblTrim.Text = strText.Trim(); // 공백제거
            
        }

    }
}
