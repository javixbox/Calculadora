using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private Calculadora calc = new Calculadora(0,0);

        public Form1()
        {
            InitializeComponent();
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            resultado.Clear();
            resultado.AppendText("0");
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if(resultado.Text != "Err"){
                String res = resultado.Text;
                if(res.Length==1)
                {
                    res = "0";
                }
                else if(res.Length==2 && res.Substring(0,1)=="-")
                {
                    res = "0";
                }
                else
                {
                     res = res.Substring(0,res.Length-1);
                }
                resultado.Clear();
                resultado.AppendText(res);
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                if (resultado.Text == "0")
                {
                    resultado.Clear();
                }
                if (resultado.Text.Length == 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {
                    resultado.AppendText("1");
                }
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                if (resultado.Text == "0")
                {
                    resultado.Clear();
                }
                if (resultado.Text.Length == 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {

                    resultado.AppendText("2");
                }
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                if (resultado.Text == "0")
                {
                    resultado.Clear();
                }
                if (resultado.Text.Length == 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {
                    resultado.AppendText("3");
                }
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                if (resultado.Text == "0")
                {
                    resultado.Clear();
                }
                if (resultado.Text.Length == 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {
                    resultado.AppendText("4");
                }
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                if (resultado.Text == "0")
                {
                    resultado.Clear();
                }
                if (resultado.Text.Length == 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {
                    resultado.AppendText("5");
                }
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                if (resultado.Text == "0")
                {
                    resultado.Clear();
                }
                if (resultado.Text.Length == 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {
                    resultado.AppendText("6");
                }
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                if (resultado.Text == "0")
                {
                    resultado.Clear();
                }
                if (resultado.Text.Length == 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {
                    resultado.AppendText("7");
                }
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                if (resultado.Text == "0")
                {
                    resultado.Clear();
                }
                if (resultado.Text.Length == 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {
                    resultado.AppendText("8");
                }
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                if (resultado.Text == "0")
                {
                    resultado.Clear();
                }
                if (resultado.Text.Length == 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {
                    resultado.AppendText("9");
                }
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                if (resultado.Text == "0")
                {
                    resultado.Clear();
                }
                if (resultado.Text.Length == 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {
                    resultado.AppendText("0");
                }
            }
        }

        private void bSigno_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                int num = int.Parse(resultado.Text);
                num = -num;
                resultado.Clear();
                resultado.AppendText("" + num);
            }
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                calc.setOp1(int.Parse(resultado.Text));
                calc.setOper('+');
                resultado.Clear();
                resultado.AppendText("0");
            }
        }

        private void bIgual_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                calc.setOp2(int.Parse(resultado.Text));
                calc.Calcular();
                if (calc.getResultado().Length > 9)
                {
                    resultado.Clear();
                    resultado.AppendText("Err");
                }
                else
                {
                    resultado.Clear();
                    resultado.AppendText(calc.getResultado());
                }
                calc = new Calculadora(0, 0);
            }
        }

        private void bRestar_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                calc.setOp1(int.Parse(resultado.Text));
                calc.setOper('-');
                resultado.Clear();
                resultado.AppendText("0");
            }
        }

        private void bMultiplicar_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                calc.setOp1(int.Parse(resultado.Text));
                calc.setOper('*');
                resultado.Clear();
                resultado.AppendText("0");
            }
        }

        private void bDividir_Click(object sender, EventArgs e)
        {
            if (resultado.Text != "Err")
            {
                calc.setOp1(int.Parse(resultado.Text));
                calc.setOper('/');
                resultado.Clear();
                resultado.AppendText("0");
            }
        }
    }
}
