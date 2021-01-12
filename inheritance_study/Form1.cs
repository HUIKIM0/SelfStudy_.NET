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
            CBase cb = new CBase();   //class CBase



            //Graphics g = pMain.CreateGraphics();   //panel에 그릴거야
            //Pen p = new Pen(Color.Aqua);           //펜 생성

            //g.DrawRectangle(p, 50, 50, 100, 150);    //펜,x좌표,y좌표,넓이,높이


        }
    }
}
