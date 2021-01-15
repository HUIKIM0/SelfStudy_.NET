using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace inheritance_study
{
    class CCycle : CBase
    {

        /* class CBase
           strName  이름
           _Pen     펜
        */
        public Rectangle _rtCircleBtn2;   //바퀴1
        public Rectangle _rtCircleBtn22;  //바퀴2
        public Rectangle _rtSquareBtn2;   //몸통

        public CCycle(string sName)
        {
            strName = sName;   //이름
            _Pen = new Pen(Color.Black, 3);  //굵기는 3

            //★한칸에 30pexel로 계산
            _rtCircleBtn2 = new Rectangle(30, 150, 120, 120);  //바퀴 그려주기
            _rtCircleBtn22 = new Rectangle(210, 150, 120, 120);
            _rtSquareBtn2 = new Rectangle(60, 90, 240, 60);    //몸통 그려주기
        }

        public Pen fPenInfo()    //반환하는 형식 Pen형식
        {
            return _Pen;
        }
    }
}
