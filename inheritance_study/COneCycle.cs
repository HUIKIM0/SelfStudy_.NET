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
        public Rectangle _rtCircle1;   //바퀴
        public Rectangle _rtSquare1;   //몸통

        //부모Class인 CBase에는 이름(strName)과 펜(_Pen)이 있음

        public COneCycle(string sName)  //생성자
        {
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke, 3);  //굵기는 3

            //★한칸에 30pexel로 계산
            _rtCircle1 = new Rectangle(120, 150, 120, 120);

        }
    }
}
