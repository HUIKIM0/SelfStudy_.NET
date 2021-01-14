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
        public Rectangle _rtCircleBtn1;   //바퀴
        public Rectangle _rtSquareBtn1;   //몸통



        public COneCycle(string sName)  //생성자
        {
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke, 3);  //굵기는 3

            //★한칸에 30pexel로 계산
            _rtCircleBtn1 = new Rectangle(120, 150, 120, 120);  //바퀴 그려주기
            _rtSquareBtn1 = new Rectangle(150, 30, 60, 120);    //몸통 그려주기

        }

        public Pen fPenInfo()    //반환하는 형식 Pen형식
        {
            return _Pen;
        }
    }
}
