using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int K, B;
            if (vScrollBar1.Value > vScrollBar2.Value)
            {
                Kecil.Text = vScrollBar2.Value + "";
                Besar.Text = vScrollBar1.Value + "";
            }
            else
            {
                Kecil.Text = vScrollBar1.Value + "";
                Besar.Text = vScrollBar2.Value + "";
            }

            K = int.Parse(Kecil.Text);
            B = int.Parse(Besar.Text);

            value1.Text = vScrollBar1.Value + "";
            value2.Text = vScrollBar2.Value + "";

            dateTimePicker1.MinDate = new DateTime(DateTime.Today.Year - B, DateTime.Today.Month, DateTime.Today.Day);
            dateTimePicker1.MaxDate = new DateTime(DateTime.Today.Year - K, DateTime.Today.Month, DateTime.Today.Day);
        }
    }
}
