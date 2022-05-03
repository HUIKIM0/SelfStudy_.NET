using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_discount
{
    public enum EnumItem
    {
        물 = 600,
        음료수 = 2300,
        고기 = 12000,
        과일 = 5000,
        냉동식품 = 7800,
        즉석식품 = 1200,
        라면 = 4800,
    }

    public enum EnumRate
    {
        할인_3 = 3,
        할인_5 = 5,
        할인_10 = 10,
        할인_20 = 20,
        사장할인_80 = 80,

    }

    // class 밖에 Enum사용 -> namespace만 같으면 쉽게 접근해서 쓰게
/*    class EnumClass
    {

    }*/

}
