using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Function(int r, int l, int n)
        {
            Byte bitR = Convert.ToByte(r);
            Byte bitL = Convert.ToByte(l + n % 256);

            return Convert.ToInt32(bitR ^ bitL);
        }

        private void CipherButton_Click(object sender, EventArgs e)
        {
            AnswerTB.Text = null;
            int r = Convert.ToInt32(RValueTB.Value);
            int l = Convert.ToInt32(LValueTB.Value);
            int n = 6;
            AnswerTB.Text = $"R = {r}, L = {l}, n = {n}\n";
            for (int i = 1; i <= n; i++)
            {
                l = r ^ ((l + i) % 256);
                
                AnswerTB.Text += $"Раунд #{i}:\n";
                AnswerTB.Text += $"R = {l}, L = {r ^ ((l + i) % 256)}\n";
            }
        }

        private void DecipherButton_Click(object sender, EventArgs e)
        {
            AnswerTB.Text = null;
            int r = Convert.ToInt32(RValueTB.Value);
            int l = Convert.ToInt32(LValueTB.Value);
            int n = 6;
            for (int i = n; i != 1; i--)
            {
                
                AnswerTB.Text += $"\nРаунд #{i}\nR = {r}, L = {l}, n = {n}";
            }
        }
    }
}
