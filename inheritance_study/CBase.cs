using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace inheritance_study
{
    class CBase
    {
        public string strName;  //이름
        protected Pen _Pen;        //using System.Drawing의 Pen


        public CBase()  //생성자 (class랑 이름이 같아야)
        {
            _Pen = new Pen(Color.Aqua);  
            
        }
    }
}
