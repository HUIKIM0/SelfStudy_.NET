using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ArrayTest();
            ArrayClassTest();
        }


        private void ArrayTest()
        {
            //int iDay1, iDay2, iDay3;
            //iDay1 = 10;
            //iDay2 = 30;
            //iDay3 = 25;

            //string strT1 = "가,나,다,라,마,바,사";
            //string[] strT1Split = strT1.Split(',');


            int[] iArrayDay = { 1, 2, 3, 4, 5 };

            int[] iArrayDay2 = new int[5] { 1, 2, 3, 4, 5 };

            int[] iArrayDay3 = new int[5];
            iArrayDay3[0] = 10;
            iArrayDay3[1] = 20;
            iArrayDay3[2] = 30;
            iArrayDay3[3] = 40;
            iArrayDay3[4] = 50;

            int[,] iArrayDay4 = new int[2, 4] { { 1, 2, 3, 4 }, { 10, 20, 30, 40 } };
        }

        private void ArrayClassTest()
        {
            int[] iTest = { 10, 20, 30, 40, 50 };
            int i = iTest.Length;

            Array.Clear(iTest,2,2);  //2번째부터 2개를 0으로
            Array.Resize(ref iTest, 10);  // 배열을 늘림

            int iWhare = Array.IndexOf(iTest, 50);  //50이 어디에 있나
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] iTest = { 10, 23, 31, 29, 51, 62, 70 };

            lblArrayCount.Text = String.Format("전체 자료 수:{0}",iTest.Length.ToString());

            dgDay["colDay1", 0].Value = iTest[0];
            dgDay["colDay2", 0].Value = iTest[1];
            dgDay["colDay3", 0].Value = iTest[2];
            dgDay["colDay4", 0].Value = iTest[3];
            dgDay["colDay5", 0].Value = iTest[4];
            dgDay["colDay6", 0].Value = iTest[5];
            dgDay["colDay7", 0].Value = iTest[6];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();  // 버튼을 아무리 눌러도 계속 생성되지X 초기화

            int[,] iTest2 = { { 13, 20, 49, 39, 51, 33, 48 }, { 40, 32, 50, 61, 65, 59, 50 } };

            lblArrayCount.Text = String.Format("전체 자료 수:{0}", iTest2.Length.ToString());

            dgDay.Rows.Add();

            dgDay["colDay1", 0].Value = iTest2[0,0];
            dgDay["colDay2", 0].Value = iTest2[0,1];
            dgDay["colDay3", 0].Value = iTest2[0,2];
            dgDay["colDay4", 0].Value = iTest2[0,3];
            dgDay["colDay5", 0].Value = iTest2[0,4];
            dgDay["colDay6", 0].Value = iTest2[0,5];
            dgDay["colDay7", 0].Value = iTest2[0,6];

            dgDay["colDay1", 1].Value = iTest2[1,0];
            dgDay["colDay2", 1].Value = iTest2[1,1];
            dgDay["colDay3", 1].Value = iTest2[1,2];
            dgDay["colDay4", 1].Value = iTest2[1,3];
            dgDay["colDay5", 1].Value = iTest2[1,4];
            dgDay["colDay6", 1].Value = iTest2[1,5];
            dgDay["colDay7", 1].Value = iTest2[1,6];
        }
    }
}
