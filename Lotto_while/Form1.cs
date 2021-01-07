using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnrottoResult_Click(object sender, EventArgs e)
        {
            //1 ~ 45 6개의 번호

            int[] iArray = new int[6];
            int ArrayCount = 0;

            StringBuilder sb = new StringBuilder();  
            Random rd = new Random();

            while (Array.IndexOf(iArray,0) != -1)  //IndexOf는 찾는 값이 없으면 -1를 반환
            {
                // 반환값이 -1이 아니다 => 0이 존재한다. 계속진행
                int iNumber = rd.Next(1, 46); // 랜덤 범위 1 <= x < 46

                if (true)
                {
                    if (Array.IndexOf(iArray,iNumber) == -1)   //iArray안에 랜덤으로 찾은값(iNumber)가 존재하지 않으면(-1)
                    {
                        iArray[ArrayCount] = iNumber;
                        //sb.Append(string.Format("{0}. ", iNumber));

                        ArrayCount++;


                    }

                }

            }

            //배열 sort
            Array.Sort(iArray);

            foreach (int s in iArray)
            {
                sb.Append(string.Format("{0}. ",s));  // StringBuilder sb에 정렬된 배열값들 추가
            }


            lblrottoResult.Text = sb.ToString();  // string 형태로 바꿔서 출력
            lboxrottoResult.Items.Add(sb.ToString());  //ListBox 값 넣기

        }

        private void btnchoiceResult_Click(object sender, EventArgs e)
        {
            // 1~ 100 숫자를 입력 -> 몇번만에 찾아냈는지?

            Random rd = new Random();

            int iNumber = int.Parse(tboxNumber.Text);  //입력받은 text를 정수로 int.Parse

            if(iNumber < 1 || iNumber > 100)
            {
                MessageBox.Show("1~100사이의 값을 입력해주세요");
                return;
            }
            
            int iCheckNumber = 0;  //랜덤 수
            int iCount = 0; // 몇회만에?

            do
            {
                iCheckNumber = rd.Next(1, 101); // 랜덤 범위 1 <= x < 101
                iCount++;

            } while (iNumber != iCheckNumber);  //못찾아내면 또 수행

            lblfindResult.Text = string.Format("입력하신 {0} 숫자를 {1}회 만에 찾으셨습니다.", iNumber, iCount);
        }
    }
}
