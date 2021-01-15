using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace inheritance_study
{
    class COneCycle : CBase  
    {
        /* class CBase
           strName  이름
           _Pen     펜
        */
        public Rectangle _rtCircle1;   //바퀴
        public Rectangle _rtSquare1;   //몸통



        public COneCycle(string sName)  //생성자
        {
            strName = sName;   //이름
            _Pen = new Pen(Color.WhiteSmoke, 3);  //굵기는 3

            //★한칸에 30pexel로 계산
            _rtCircle1 = new Rectangle(120, 150, 120, 120);  //바퀴 그려주기
            _rtSquare1 = new Rectangle(150, 30, 60, 120);    //몸통 그려주기

        }

        public Pen fPenInfo()    //반환하는 형식 Pen형식
        {
            return _Pen;
        }


        public void fMove(int iMove)
        {
            fMove_rtCircle1(iMove);
            fMove_rtSquare1(iMove);
        }

        protected void fMove_rtCircle1(int iMove)
        {
            //Point를 이용. _rtCircle1의 현재 좌표값을 가져옴
            Point oPoint = _rtCircle1.Location;

            //X좌표 = X좌표+움직이는 값 만큼
            oPoint.X = oPoint.X + iMove;

            _rtCircle1.Location = oPoint;
        }

        protected void fMove_rtSquare1(int iMove)
        {
            Point oPoint = _rtSquare1.Location;

            oPoint.X = oPoint.X + iMove;

            _rtSquare1.Location = oPoint;
        }
    }
}
