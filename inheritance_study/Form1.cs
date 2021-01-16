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
        //class
        COneCycle _COC;    
        CCycle _CC;
        CCar _CCar;

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = "-";
            _COC = new COneCycle("외발 자전거");  //생성자가 public COneCycle(string sName)
            _CC = new CCycle("자전거");
            _CCar = new CCar("자동차");
        }


        //Form1.Designer에서 this.KeyDown += 해준거
        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Q)
            {
                fMoving(-5);
            }
            else if(e.KeyCode == Keys.W)
            {
                fMoving(5);
            }
        }



        private void btnOneCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCOneCycleDraw();
        }


        //COneCycle에 대한 그림을 그려줌 
        private void fCOneCycleDraw()
        {
            lblName.Text = _COC.strName;

            Graphics g = pMain.CreateGraphics();   //panel에 그릴거야

            Pen p = _COC.fPenInfo(Color.Pink,2);   //COneCycle의 펜

            g.DrawRectangle(p, _COC._rtSquare1);
            g.DrawEllipse(p, _COC._rtCircle1);
        }


        private void btnCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCCycleDraw();

        }

        //CCycle에 대한 그림을 그려줌
        private void fCCycleDraw()
        {
            lblName.Text = _CC.strName;

            Graphics g = pMain.CreateGraphics();   //panel에 그릴거야

            Pen p = _CC.fPenInfo(Color.Purple,8);   //COneCycle의 펜

            g.DrawRectangle(p, _CC._rtSquare1);
            g.DrawEllipse(p, _CC._rtCircle1);
            g.DrawEllipse(p, _CC._rtCircle2);

        }


        private void btnCar_Click(object sender, EventArgs e)
        {
            fClearPanel();
            fCCarDraw();
        }

        //CCar에 대한 그림을 그려줌
        private void fCCarDraw()
        {
            lblName.Text = _CCar.strName;

            Graphics g = pMain.CreateGraphics();   //panel에 그릴거야

            Pen p = _CCar.fPenInfo(Color.Orange,5);   //COneCycle의 펜

            g.DrawRectangle(p, _CCar._rtSquare1);
            g.DrawRectangle(p, _CCar._rtSquare2);
            g.DrawEllipse(p, _CCar._rtCircle1);
            g.DrawEllipse(p, _CCar._rtCircle2);

        }


        //Panel 지우고 다시 그리게 하게끔
        private void fClearPanel()
        {
            pMain.Invalidate();
            Refresh();
        }



        private void btnRight_Click(object sender, EventArgs e)
        {
            fMoving(5);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            fMoving(-5);
        }


        private void fMoving(int iMove)
        {
            fClearPanel();

            switch (lblName.Text)
            {
                case "외발 자전거":
                    _COC.fMove(iMove);
                    fCOneCycleDraw();
                    break;

                case "자전거":
                    _CC.fMove(iMove);
                    fCCycleDraw();
                    break;

                case "자동차":
                    fCCarDraw();
                    _CCar.fMove(iMove);
                    break;

                default:
                    break;
            }
        }
    }
}
