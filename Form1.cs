using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_ISP_2_20_Laykov_PR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


         private void PYSK_Click(object sender, EventArgs e)
        {

            if (textB1.Text == string.Empty)
            return;
            if (textB2.Text == string.Empty)
            return; // чтобы кнопка не работала, если не введено никаких значений
            
            



            double X = double.Parse(textB1.Text);
            double Y = double.Parse(textB2.Text);


            double E = Math.E;
            double EX = Math.Pow(E, X); // e^x

            double E_x = Math.Pow(E, -X);
            double hx = EX - E_x;
            double Shx = hx / 2.0; //sh(x)

            double X2 = Math.Pow(X, 2); // x^2
            
            
            double XY = X / Y;
            double b = 0;
            double FX = 0;

            if (radiosh.Checked)
            {
                FX = Shx;
            }
            else if (radiox.Checked)
            {
                FX = X2;
            }
            else if (radioe.Checked)
            {
                FX = EX;
            }


            if (X == 0)
            {
                double Fxd = Math.Pow(FX, 2);
                b = Math.Pow(Fxd + Y, 3);
            }
            else if (Y == 0)
            {
                b = 0;
            }

            else if (XY > 0)
            {
                double LN = Math.Log(FX);
                double powfx = Math.Pow(FX, 2);
                double perv = Math.Pow(powfx + Y, 3);
                b = LN + perv;
            }
            else if (XY < 0)
            {
                double abspow = Math.Log(Math.Abs(FX / Y));
                double powich = Math.Pow(FX + Y, 3);
                b = abspow + powich;
            }

            string name = "Проверочная работа №2 студента группы ИСП-2-20 Лайкова Е.И.";
            string xyyy = string.Format("X = {0}, Y = {1}", X, Y);
            string bform = string.Format("G = {0:F3}", b);
            richTextB.Text = name + "\n" + xyyy + "\n" + bform ;
        }

        private void textB1_KeyPress(object sender, KeyPressEventArgs e)
        {
          if 
                (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
          else 
                e.Handled = true;
            
        }

        private void textB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if
                (Char.IsNumber(e.KeyChar) | (e.KeyChar == Convert.ToChar(",")) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
    }
}
