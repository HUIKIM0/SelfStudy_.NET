using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partial_discount
{
    public partial class Form1 : Form
    {
        cData _Data = new cData();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*namespace가 같아서 EnumItem 불러오기 OK
            EnumItem을 type형태로 가져옴. SysArray형식
            but EnumItem[]은 배열형태 -> EnumItem배열 형태로 형변환을 해야함*/
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));

            //물건
            foreach (EnumItem Eitem in ei)
            {
                cboxItem.Items.Add(Eitem.ToString());
            }

            //할인율
            foreach (EnumRate Eitem in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(Eitem.ToString());
            }
        }

        //담기 버튼을 누르면 물건이름 할인율 개수 값이!
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Data.fDataReset();  //초기화 시키고 시작

            _Data.StrItem = cboxItem.Text;
            _Data.IRate = (int)Enum.Parse(typeof(EnumRate), cboxRate.Text);   //EnumRate의 할인_3 = 3에서 3만 가져오고 싶어서
            _Data.ICount = (int)numCount.Value;    //NumericUpDown은 Value

            if(!string.IsNullOrEmpty(_Data.StrErrorName))  //strErrorName가 lsNullOrEmpty가 아니면 !
            {
                tboxErrorMsg.Text = _Data.StrErrorName;
                return;  //수식 계산 안하고 넘긴다. 메세지박스에만 적고 넘긴다
            }

            double dPrice = _Data.fItemPrice(); 
            lboxItem.Items.Add(_Data.fResult(dPrice));

            _Data.Total = dPrice;  //dPrice(할인적용된 최종가격)가 value
            tboxResult.Text = _Data.Total.ToString()+"원";
        }
    }
}
