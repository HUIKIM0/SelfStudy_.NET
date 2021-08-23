using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_discount
{
    //내부 변수들은 _

    /* 변수 */
    partial class cData
    {

        private double _total = 0.0;
        public double Total 
        {
            get => _total;
            set
            {
                _total = _total + value;
            }
        }


        private string _strErrorName = string.Empty;
        public string StrErrorName
        {
            get => _strErrorName;
            //set => _strErrorName = value;   에러메시지를 외부에서 못적게
        }


        private string _strItem = string.Empty;

        public string StrItem
        {
            //get
            //{
            //    return strItem;
            //}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _strErrorName = "물건이 선택되지 않았습니다";

                }
                else   
                {
                    _strItem = value;     //물건이 선택되었으면 값 넣어줌
                }

            }

        }


        private int _iRate = 0;    //할인율
        public int IRate 
        {
            //get
            //{
            //   return _iRate;
            //}
            set
            {
                if (value > 20)
                {
                    _strErrorName = "사장님만 가능한 할인 입니다";
                }
                else
                {
                    _iRate = value;
                }
                
            }
        }


        private int _iCount = 0;   //개수

        public int ICount 
        {
            //get
            //{
            //   return _iCount;
            //}
            set
            {
                if(value>5)
                {
                    _strErrorName = "개별 물품은 5개 이상 살 수 없습니다";
                }
                else if(value==0)
                {
                    _strErrorName = "물건 개수가 0개 입니다";
                }
                else
                {
                    _iCount = value;
                }
                
            }
        }


       
     
    }

    /* 할인율 계산 */
    partial class cData
    {
        public double fItemPrice()
        {
            int iItemPrice = 0;  
            double dPrice = 0;   

            if (string.IsNullOrEmpty(_strErrorName))  //에러메시지가 없으면 정상 값들을 받았다는 뜻
            {
                //Enum(string) 값이 가지고 있는 숫자값(int)이 뭔지 받아올 수 있음  Enum.Parse(typeof() , string형태)
                //EnumClass의 EnumItem은 물 = 600 /  할인_3 = 3 이런식인데, 가격인 숫자만 가져오고 싶어서
                iItemPrice = (int)Enum.Parse(typeof(EnumItem), _strItem);

                //전체가격 - 할인들어가는 금액(원가 * 할인퍼센트 / 100)
                dPrice = iItemPrice - Math.Round((double)iItemPrice * (double)_iRate / 100, 2);
            }

            return dPrice * _iCount;  //할인된가격 * 물건개수
        }
    }




    /* 문자열 */
    partial class cData
    {
        public string fResult(double dPrice)
        {
            if(_iRate == 0)
            {
                return string.Format("{0} X {1} : {2}원", _strItem, _iCount, dPrice);
            }
            else
            {
                return string.Format("{0} X {1} : {2}원 (할인율 : {3})", _strItem, _iCount, dPrice, _iRate);
            }

            
        }

        //초기화
        public void fDataReset()
        {
            _strErrorName = string.Empty;
            _strItem = string.Empty;
            _iRate = 0;
            _iCount = 0;

        }
    }
}
