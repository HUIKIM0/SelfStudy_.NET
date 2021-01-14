using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritance_study
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            COneCycle COC = new COneCycle("외발 자전거");
            lblName.Text = COC.strName;

            Graphics g = pMain.CreateGraphics();   //panel에 그릴거야
            Pen p = COC.fPenInfo();
            g.DrawRectangle(p, COC._rtSquareBtn1);
            g.DrawEllipse(p, COC._rtCircleBtn1);


        }
    }
}
