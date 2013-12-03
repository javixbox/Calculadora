using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Calculadora
    {
        private double operando1;
        private double operando2;
        private String resultado;
        private char operacion;

        public Calculadora(int op1, int op2)
        {
            operando1 = op1;
            operando2 = op2;
            operacion = ' ';
        }

        public void Calcular()
        {
            if(operacion == '+')
            {
                resultado = ""+(operando1 + operando2);
            }
            else if (operacion == '-')
            {
                resultado = ""+(operando1 - operando2);
            }
            else if (operacion == '*')
            {
                resultado = ""+(operando1 * operando2);
            }
            else if (operacion == '/')
            {
                if (operando2 == 0)
                {
                    resultado = "Err";
                }
                else
                {
                    resultado = "" + (operando1 / operando2);
                }
            }
            else
            {
                resultado = ""+operando1;
            }
        }

        public void setOp1(int op1)
        {
            operando1 = op1;
        }

        public void setOp2(int op2)
        {
            operando2 = op2;
        }

        public void setOper(char oper)
        {
            operacion = oper;
        }

        public String getResultado()
        {
            return resultado;
        }
    }
}
