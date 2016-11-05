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

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richTextBox1.Font = new Font("Times New Roman", 12.0f);
            richTextBox1.Height = this.Height;
            richTextBox1.Width = this.Width;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color colour = new Color();
            PropertyInfo[] p = colour.GetType().GetProperties();
            InstalledFontCollection font = new InstalledFontCollection();

            for (double i = 8; i <= 72; i++)
                FontSize.Items.Add(i);

            foreach (FontFamily fontfamily in font.Families)
                FontFamily.Items.Add(fontfamily.Name);

            Warna.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            foreach (PropertyInfo x in p)
            {
                if (x.PropertyType == typeof(System.Drawing.Color))
                    Warna.Items.Add(x.Name);
            }

            this.Warna.ComboBox.DrawItem += new DrawItemEventHandler(Warna_DrawItem);

            Warna.SelectedIndex = 8;
            FontSize.Text = richTextBox1.Font.Size.ToString();
            FontFamily.Text = richTextBox1.Font.Name;

            UpdateSize();
            UpdateFont();
        }

        private void Warna_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);

                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.Warna.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void Bold_Click(object sender, EventArgs e)
        {
            Bold.Checked = !Bold.Checked;

            int a = richTextBox1.SelectionStart;
            int b = richTextBox1.SelectionLength + a;
            if (b - a != 0)
            {
                for (int i = a; i < b; i++)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = 1;
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
                }
                richTextBox1.SelectionStart = a;
                richTextBox1.SelectionLength = b - a;
            }
            else
            {
                FontStyle bold = richTextBox1.SelectionFont.Style;
                bold ^= FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, bold);
            }
        }

        private void Italic_Click(object sender, EventArgs e)
        {
            Italic.Checked = !Italic.Checked;

            int a = richTextBox1.SelectionStart;
            int b = richTextBox1.SelectionLength + a;
            if (b - a != 0)
            {
                for (int i = a; i < b; i++)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = 1;
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style ^ FontStyle.Italic);
                }
                richTextBox1.SelectionStart = a;
                richTextBox1.SelectionLength = b - a;
            }
            else
            {
                FontStyle italic = richTextBox1.SelectionFont.Style;
                italic ^= FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, italic);
            }
        }

        private void Underline_Click(object sender, EventArgs e)
        {
            Underline.Checked = !Underline.Checked;

            int a = richTextBox1.SelectionStart;
            int b = richTextBox1.SelectionLength + a;
            if (b - a != 0)
            {
                for (int i = a; i < b; i++)
                {
                    richTextBox1.SelectionStart = i;
                    richTextBox1.SelectionLength = 1;
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style ^ FontStyle.Underline);
                }
                richTextBox1.SelectionStart = a;
                richTextBox1.SelectionLength = b - a;
            }
            else
            {
                FontStyle underline = richTextBox1.SelectionFont.Style;
                underline ^= FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size, underline);
            }
        }

        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FontSize.Focused == false)
                return;
            UpdateSize();
        }

        private void FontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FontFamily.Focused == false)
                return;
            UpdateFont();
        }

        private void Warna_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Warna.Focused == false)
                return;
            UpdateColor();
        }

        private void UpdateSize()
        {
            try
            {
                float size = (FontSize.Text == "") ? 12 : Convert.ToInt32(FontSize.Text);
                int a = richTextBox1.SelectionStart;
                int b = richTextBox1.SelectionLength + a;
                if (b - a != 0)
                {
                    for (int i = a; i < b; i++)
                    {
                        richTextBox1.SelectionStart = i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, size, richTextBox1.SelectionFont.Style);
                    }
                    richTextBox1.SelectionStart = a;
                    richTextBox1.SelectionLength = b - a;
                }
                else
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, size, richTextBox1.SelectionFont.Style);
            }
            catch
            {
                return;
            }
        }

        private void UpdateFont()
        {
            int a = richTextBox1.SelectionStart;
            int b = richTextBox1.SelectionLength + a;
            try
            {
                if (b - a != 0)
                {
                    string fnt = FontFamily.Text;
                    for (int i = a; i < b; i++)
                    {
                        richTextBox1.SelectionStart = i;
                        richTextBox1.SelectionLength = 1;
                        richTextBox1.SelectionFont = new Font(fnt, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                    }
                    richTextBox1.SelectionStart = a;
                    richTextBox1.SelectionLength = b - a;
                }
                else
                    richTextBox1.SelectionFont = new Font(FontFamily.Text, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            }
            catch
            {
                return;
            }
        }

        private void UpdateColor()
        {
            try
            {
                richTextBox1.SelectionColor = Color.FromName(Warna.Text);
            }
            catch
            {
                return;
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            Bold.Checked = Italic.Checked = Underline.Checked = false;

            if (richTextBox1.SelectionFont == null)
            {
                FontSize.Text = "";
                FontFamily.Text = "";
            }
            else
            {
                FontFamily.Text = richTextBox1.SelectionFont.Name;
                FontSize.Text = richTextBox1.SelectionFont.Size.ToString();
                if (richTextBox1.SelectionFont.Bold)
                    Bold.Checked = true;
                if (richTextBox1.SelectionFont.Italic)
                    Italic.Checked = true;
                if (richTextBox1.SelectionFont.Underline)
                    Underline.Checked = true;
            }

            if (richTextBox1.SelectionColor.Name == "0")
                Warna.Text = "";
            else
                Warna.Text = richTextBox1.SelectionColor.Name;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            richTextBox1.Height = this.Height;
            richTextBox1.Width = this.Width;
        }
    }
}
