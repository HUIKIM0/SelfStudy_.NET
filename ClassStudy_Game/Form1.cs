using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//같은 프로젝트에 있는 친구들 끼리는 namespace가 똑같다
namespace ClassStudy_Game
{


    //struct -> 필드를 초기화 할 수 없음
    struct structPlayer
    {

        public int iSun;
        public int iMoon;
        public int iStar;

        public int iCount;  //몇회 진행중?

        public int iTotal;  //해,달,별 더한 값


        //값들을 더해서 계산
        //public int ValueSum(int iSun, int iMoon, int iStar)
        //{
        //    return iSun + iMoon + iStar;
        //}

        ////결과를 string 형태로 반환하여 화면에 보여주기 용도
        //public string iText()
        //{
        //    return string.Format("{0}회) 해:{1}, 달{2}, 별{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iTotal);
        //}

    }



    public partial class Form1 : Form
    {

        structPlayer _strPlayer1;   //구조체 사용 1번 Player
        structPlayer _strPlayer2;   //구조체 사용 2번 Player

        //CPlayer _clPlayer1 = new CPlayer();
        //CPlayer _clPlayer2 = new CPlayer();


        Random _rd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _strPlayer1.iSun = iNumber;
            }
            else
            {
                _strPlayer2.iSun = iNumber;
            }

            Result();
            CheckedChange();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _strPlayer1.iMoon = iNumber;
            }
            else
            {
                _strPlayer2.iMoon = iNumber;
            }

            Result();
            CheckedChange();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _strPlayer1.iStar = iNumber;
            }
            else
            {
                _strPlayer2.iStar = iNumber;
            }

            Result();
            CheckedChange();
        }

        private void pboxNone_Click(object sender, EventArgs e)
        {
            //아무것도 안 하고 한턴을 넘긴다

            CheckedChange();
        }



        private void CheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }


        CPlayer cp = new CPlayer();  //class

        private void Result()
        {
            string strResult = string.Empty;  //빈 string공간

            int iCount = 0;   

            //플레이어1이 카드 선택
            if (rdoPlayer1.Checked)
            {
                _strPlayer1.iCount++;

                //int인자를 3개 가진 class로 가서 수식만 계산해서 return해줌
                _strPlayer1.iTotal = cp.ValueSum(_strPlayer1.iSun, _strPlayer1.iMoon, _strPlayer1.iStar);  

                strResult = cp.iText(_strPlayer1.iCount, _strPlayer1.iSun, _strPlayer1.iMoon, _strPlayer1.iStar, _strPlayer1.iTotal);   
                lboxResult1.Items.Add(strResult);

            }
            //플레이어2가 카드 선택
            else
            {
                _strPlayer2.iCount++;

                _strPlayer2.iTotal = cp.ValueSum(_strPlayer2.iSun, _strPlayer2.iMoon, _strPlayer2.iStar);

                strResult = cp.iText(_strPlayer2.iCount, _strPlayer2.iSun, _strPlayer2.iMoon, _strPlayer2.iStar, _strPlayer2.iTotal);
                lboxResult2.Items.Add(strResult);
            }

          
            if(_strPlayer1.iCount == _strPlayer2.iCount)
            {
                lboxNow.Items.Add(cp.PlayerPair(_strPlayer2.iCount, _strPlayer1.iTotal, _strPlayer2.iTotal));

                if(_strPlayer2.iCount >= 5)  //5회를 다 돌았다
                {
                    lboxNow.Items.Add(cp.PlayerResult(_strPlayer1.iTotal,_strPlayer2.iTotal));
                }
            }

        }


    }
}
