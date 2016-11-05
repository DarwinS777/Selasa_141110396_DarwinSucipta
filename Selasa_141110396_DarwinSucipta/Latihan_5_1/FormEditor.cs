using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;

namespace Latihan_5_1
{
    public partial class FormEditor : Form
    {
        Form1 form1 = (Form1)Form1.ActiveForm;

        public FormEditor()
        {
            InitializeComponent();
            Color colour = new Color();
            PropertyInfo[] p = colour.GetType().GetProperties();

            CBBgColor.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo c in p)
            {
                if (c.PropertyType == typeof(System.Drawing.Color))
                {
                    CBBgColor.Items.Add(c.Name);
                }
            }

            this.CBBgColor.DrawItem += new DrawItemEventHandler(CBBgColor_DrawItem);
        }

        private void CBBgColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.CBBgColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            CBBgColor.Text = form1.RichTextBoxBackColor;

            treeView1.ExpandAll();
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0];
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode == treeView1.Nodes[0].Nodes[0])
            {
                tabControl1.SelectedIndex = 0;
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            form1.RichTextBoxBackColor = CBBgColor.Text;
            this.Dispose();
            form1.ShowRichTextBox();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            form1.ShowRichTextBox();
        }

        private void FormEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            form1.ShowRichTextBox();
        }
    }
}
