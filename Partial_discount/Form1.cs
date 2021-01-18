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

            foreach (EnumItem Eitem in ei)
            {
                cboxItem.Items.Add(Eitem.ToString());
            }

            foreach (EnumRate Eitem in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(Eitem.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _Data.StrItem = cboxItem.Text;
            _Data.iRate = int.Parse(cboxRate.Text);
            _Data.iCount = (int)numCount.Value;  //NumericUpDown는 Value
        }
    }
}
