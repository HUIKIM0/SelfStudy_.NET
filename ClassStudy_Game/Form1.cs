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
        public int ValueSum(int iSun, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }

        //결과를 string 형태로 반환하여 화면에 보여주기 용도
        public string iText()
        {
            return string.Format("{0}회) 해:{1}, 달{2}, 별{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iTotal);
        }

    }



    public partial class Form1 : Form
    {

        //structPlayer _strPlayer1;   //구조체 사용 1번 Player
        //structPlayer _strPlayer2;   //구조체 사용 2번 Player

        CPlayer _clPlayer1 = new CPlayer();
        CPlayer _clPlayer2 = new CPlayer();


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
                _clPlayer1.iSun = iNumber;
            }
            else
            {
                _clPlayer2.iSun = iNumber;
            }

            Result();
            CheckedChange();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _clPlayer1.iMoon = iNumber;
            }
            else
            {
                _clPlayer2.iMoon = iNumber;
            }

            Result();
            CheckedChange();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _clPlayer1.iStar = iNumber;
            }
            else
            {
                _clPlayer2.iStar = iNumber;
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

        

        private void Result()
        {
            string strResult = string.Empty;  //빈 string공간

            int iCount = 0;   

            if (rdoPlayer1.Checked)
            {
                _clPlayer1.iCount++;

                _clPlayer1.iTotal = _clPlayer1.ValueSum(_clPlayer1.iSun, _clPlayer1.iMoon, _clPlayer1.iStar);  

                strResult = _clPlayer1.iText();   
                lboxResult1.Items.Add(strResult);

            }
            else
            {
                _clPlayer2.iCount++;

                _clPlayer2.iTotal = _clPlayer2.ValueSum(_clPlayer2.iSun, _clPlayer2.iMoon, _clPlayer2.iStar);

                strResult = _clPlayer2.iText();
                lboxResult2.Items.Add(strResult);
            }

            if(_clPlayer1.iCount >=5 && _clPlayer2.iCount >=5)
            {
                if (_clPlayer1.iTotal > _clPlayer2.iTotal)
                {
                    MessageBox.Show("플레이어1이 이겼습니다");
                }
                else if(_clPlayer1.iTotal < _clPlayer2.iTotal)
                {
                    MessageBox.Show("플레이어2이 이겼습니다");
                }
                else
                {
                    MessageBox.Show("플레이어1과 2가 비겼습니다");
                }
            }
        }


    }
}
