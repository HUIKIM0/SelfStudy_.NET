
using System.Drawing;

namespace inheritance_study
{
    class CCar : CCycle
    {
        /* class CBase
           strName  이름
           _Pen     펜

           class CCycle
           _rtCircle1 바퀴
           _rtCircle2 바퀴
           __rtSquare1 몸통
        */

        public Rectangle _rtSquare2; //위로 올라갈 몸통

        public CCar(string sName) : base(sName)
        {
            strName = sName;
            _Pen = new Pen(Color.Blue, 3);

            _rtCircle1 = new Rectangle(60, 180, 90, 90);  //바퀴 그려주기
            _rtCircle2 = new Rectangle(210, 180, 90, 90);
            _rtSquare1 = new Rectangle(90, 30, 180, 90);    //몸통 그려주기
            _rtSquare2 = new Rectangle(30,120,300,60);    


        }

        public new void fMove(int iMove)
        {
            fMove_rtCircle1(iMove);
            fMove_rtCircle2(iMove);
            fMove_rtSquare1(iMove);
            fMove_rtSuare2(iMove);
        }

        
        protected void fMove_rtSuare2(int iMove)
        {

                Point oPoint = _rtSquare2.Location;

                oPoint.X = oPoint.X + iMove;

                _rtSquare2.Location = oPoint;
            
        }
    }
}
