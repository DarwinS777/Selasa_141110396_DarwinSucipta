﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volleyball_Problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        long mod = 1000000007;

        private long kombinasi(long a, long b)
        {
            if (a < b)
                return 0;
            long hasil = 1;
            hasil *= faktorial(a);
            hasil %= mod;
            hasil *= InverseEuler(faktorial(a - b));
            hasil %= mod;
            hasil *= InverseEuler(faktorial(b));
            hasil %= mod;
            return hasil;
        }

        private long faktorial(long a)
        {
            long hasil = 1;
            for (int i = 1; i <= a; i++)
            {
                hasil *= i;
                hasil %= mod;
            }
            return hasil;
        }

        private long PMod(long b, long c)
        {
            long hasil = 1;
            while (c > 0)
            {
                if (c % 2 == 1)
                {
                    hasil = (hasil * b) % mod;
                }
                b = (b * b) % mod;
                c /= 2;
            }
            return hasil % mod;
        }

        private long InverseEuler(long a)
        {
            return PMod(a, mod - 2);
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            long a, b, hasil;
            a = Convert.ToInt64(Txt1.Text);
            b = Convert.ToInt64(Txt2.Text);
            if (a < b)
            {
                long temp = a;
                a = b;
                b = temp;
            }

            if ((a > 25 && a - b != 2) || (a - b < 2) || (a < 25))
            {
                hasil = 0;
            }
            else
            {
                hasil = kombinasi(Math.Min(a + b - 1, 47), Math.Min(a - 1, 24));
                hasil *= PMod(2, a - 25);
                hasil %= mod;
            }
            TxtHasil.Text = hasil.ToString();
        }
    }
}