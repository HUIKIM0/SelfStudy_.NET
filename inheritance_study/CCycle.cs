using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace inheritance_study
{
    class CCycle : COneCycle
    {

        /*
           class COneCycle
           strName 이름(CBase)
           _Pen    펜(CBase)
           
           Rectangle _rtCircle1   바퀴
           Rectangle _rtSquare1  몸통 
        */

        public Rectangle _rtCircle2;  //바퀴2 


        public CCycle(string sName) : base(sName)
        {
            strName = sName;   //이름
            _Pen = new Pen(Color.Black, 3);  //굵기는 3

            //★한칸에 30pexel로 계산
            _rtCircle1 = new Rectangle(30, 150, 120, 120);  //바퀴 그려주기
            _rtCircle2 = new Rectangle(210, 150, 120, 120);
            _rtSquare1 = new Rectangle(60, 90, 240, 60);    //몸통 그려주기
        }



        // ****************움직이게 하기***************
        public override void fMove(int iMove)
        {
            base.fMove;  //COneCycle(부모)에 있는 fMove

            fMove_rtCircle2(iMove);   
        }



        protected void fMove_rtCircle2(int iMove)
        {
            //Point를 이용. _rtCircle1의 현재 좌표값을 가져옴
            Point oPoint = _rtCircle2.Location;

            //X좌표 = X좌표+움직이는 값 만큼
            oPoint.X = oPoint.X + iMove;

            _rtCircle2.Location = oPoint;
        }


    }
}
