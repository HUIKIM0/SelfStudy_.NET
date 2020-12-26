using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfStudy_.NET
{
    public partial class DataType : Form
    {
        public DataType()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            short sNumber = short.Parse(tboxNumber.Text);  //tboxNumber에 적힌 Text 내용을 short 타입으로 변환
        }
    }
}
