using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            short sNumeber = short.Parse(tboxNumber.Text);   //tboxNumber에 적힌 Text값을 short로

            lblShort.Text = sNumeber.ToString(); 
        }
    }
}
