using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudy_Game
{
    class CPlayer
    {
        public int iSun = 0;
        public int iMoon = 0;
        public int iStar = 0;

        public int iCount = 0;  //몇회 진행중?

        public int iTotal = 0;  //해,달,별 더한 값


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
}
