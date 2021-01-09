using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudy_Game
{
    class CPlayer
    {
        //public int iSun = 0;
        //public int iMoon = 0;
        //public int iStar = 0;

        //public int iCount = 0;  //몇회 진행중?

        //public int iTotal = 0;  //해,달,별 더한 값


        //값들을 더해서 계산
        public int ValueSum(int iSun, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }

        //결과를 string 형태로 반환하여 화면에 보여주기 용도
        public string iText(int iCount, int iSun, int iMoon, int iStar, int iTotal)
        {
            return string.Format("{0}회) 해:{1}, 달{2}, 별{3} => 합계는 {4} 입니다.", iCount, iSun, iMoon, iStar, iTotal);
        }


        //플레이어1과 플레이어2를 비교
        public string PlayerPair(int iCount, int P1CardSum, int P2CardSum)
        {
            int SumCheck = P1CardSum - P2CardSum;

            if(SumCheck > 0)    //p1이 10이고 p2가 8이면 10-8 =>2. 0보다 크게나옴(양수)
            {
                return string.Format("{0}회차: 플레이어1이 플레이어2보다 {1}만큼 더 큽니다",iCount, SumCheck);
            }
            else if(SumCheck < 0 )
            {
                return string.Format("{0}회차: 플레이어2가 플레이어1보다 {1}만큼 더 큽니다", iCount, Math.Abs(SumCheck)); //SumCheck * -1
            }
            else
            {
                return string.Format("{0}회차: 플레이어1과 플레이어2의 값이 같습니다",iCount);
            }
        }

        
        //결과
        public string PlayerResult(int P1CardSum, int P2CardSum)
        {
            string strResult = string.Empty;  

            if (P1CardSum > P2CardSum)
            {
                strResult = "★플레이어1이 이겼습니다";
            }
            else if (P1CardSum < P2CardSum)
            {
                strResult = "★플레이어2이 이겼습니다";
            }
            else
            {
                strResult = "★플레이어1과 2가 비겼습니다";
            }

            return strResult;   //return 잊지말고 꼭
        }
    }
}
