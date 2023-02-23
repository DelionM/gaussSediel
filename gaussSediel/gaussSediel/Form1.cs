using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gaussSediel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            op1_txt.Focus();
        }
        Class_grafico obj_grafico = new Class_grafico();
        int x1, x2, x3, y1, y2, y3, z1, z2, z3, res1, res2, res3;
        Graphics g, h;
        char[] op1 = new char[15];
        char[] op2 = new char[15];
        char[] op3 = new char[15];
        String Ope1, Ope2, Ope3;
        double op1x, op1y, op1z, op2x, op2y, op2z, op3x, op3y, op3z;
        double op1r, op2r, op3r;
        int auxiliar, auxiliar2, i = 0, auxiliar3 = 0;

        private void txt_z1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtErrorZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            limpiar()
;        }

  

        Pen p, q;
        double X = 0, Y = 0, Z = 0, aux1, aux2, aux3, Ea_X, Ea_Y, Ea_Z, ErrorMinimo;
        int i = 0, Contador = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dibuja()
        {
            int X2 = Convert.ToInt16(X);
            int Y2 = Convert.ToInt16(Y);
            obj_grafico.p_valor_x(X2);
            obj_grafico.p_valor_y(Y2);
            obj_grafico.plano_coordenadas(Gplano);
        }

        private void ObtainVals()
        {
            x1 = op1x;
            x2 = op2x;
            x3 = op3x;
            y1 = op1y;
            y2 = op2y;
            y3 = op3y;
            z1 = op1z;
            z2 = op2z;
            z3 = op3z;
            ErrorMinimo = Convert.ToDouble(txtErrorMinimo.Text);
            res1 = op1r;
            res2 = op2r;
            res3 = op3r;
        }
        private void Iteracion()
        {
            aux1 = X;
            aux2 = Y;
            aux3 = Z;
            if (i == 0)
            {
                i = 1;
                X = res1 / x1;
                Y = (res2 + (-1 * x2 * X)) / y2;
                Z = (res3 + (-1 * x3 * X) + (-1 * y3 * Y)) / z3;
            }
            else
            {
                X = (res1 + (-1 * y1 * Y) + (-1 * z1 * Z)) / x1;
                Y = (res2 + (-1 * x2 * X) + (-1 * z2 * Z)) / y2;
                Z = (res3 + (-1 * x3 * X) + (-1 * y3 * Y)) / z3;
            }
        }
        private void CalculeError()
        {
            Ea_X = (X - aux1) / X;
            Ea_Y = (Y - aux2) / Y;
            Ea_Z = (Z - aux3) / Z;
        }
        private void TryPrintResult()
        {
            txt_ValX.Text = X.ToString();
            txt_ValY.Text = Y.ToString();
            txt_ValZ.Text = Z.ToString();
            txtErrorX.Text = Ea_X.ToString();
            txtErrorY.Text = Ea_Y.ToString();
            txtErrorZ.Text = Ea_Z.ToString();
            txtIteraciones.Text = Contador.ToString();
        }
        private void calcularVariables()
        {
            Ope1 = txt_x1.Text;
            Ope2 = txt_x2.Text;
            Ope3 = txt_x3.Text;
            op1 = Ope1.ToCharArray();
            op2 = Ope2.ToCharArray();
            op3 = Ope3.ToCharArray();
            auxiliar2 = 1;
            Conversor(op1);
            //MessageBox.Show("X corresponde a " + op1x + " mientras que Y corresponder a " + op1y + " mientras que Z corresponde a " + op1z + " mientras que el resultado es + " + op1r);
            auxiliar2 = 2;
            Conversor(op2);
            //MessageBox.Show("X corresponde a " + op2x + " mientras que Y corresponde a " + op2y + " mientras que Z corresponde a " + op2z + " mientras que el resultado es + " + op2r);
            auxiliar2 = 3;
            Conversor(op3);
            //MessageBox.Show("X corresponde a " + op3x + " mientras que Y corresponder a " + op3y + " mientras que Z corresponde a " + op3z + " mientras que el resultado es " + op3r);
        }
        private void Conversor(char[] a)
        {
            i = 0;
            while (i < a.Length)
            {
                switch (a[i])
                {
                    case 'x':
                        auxiliar = 0;
                        if (auxiliar2 == 1)
                        {
                            op1x = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op1x = op1x * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 2)
                        {
                            op2x = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op2x = op2x * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 3)
                        {
                            op3x = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op3x = op3x * checkNegative();
                            auxiliar3 = 0;
                        }
                        break;
                    case 'X':
                        auxiliar = 0;
                        if (auxiliar2 == 1)
                        {
                            op1x = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op1x = op1x * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 2)
                        {
                            op2x = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op2x = op2x * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 3)
                        {
                            op3x = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op3x = op3x * checkNegative();
                            auxiliar3 = 0;
                        }
                        break;
                    case 'y':
                        if (auxiliar2 == 1)
                        {
                            op1y = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op1y = op1y * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 2)
                        {
                            op2y = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op2y = op2y * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 3)
                        {
                            op3y = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op3y = op3y * checkNegative();
                            auxiliar3 = 0;
                        }
                        break;
                    case 'Y':
                        if (auxiliar2 == 1)
                        {
                            op1y = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op1y = op1y * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 2)
                        {
                            op2y = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op2y = op2y * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 3)
                        {
                            op3y = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op3y = op3y * checkNegative();
                            auxiliar3 = 0;
                        }
                        break;
                    case 'z':
                        if (auxiliar2 == 1)
                        {
                            op1z = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op1z = op1z * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 2)
                        {
                            op2z = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op2z = op2z * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 3)
                        {
                            op3z = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op3z = op3z * checkNegative();
                            auxiliar3 = 0;
                        }
                        break;
                    case 'Z':
                        if (auxiliar2 == 1)
                        {
                            op1z = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op1z = op1z * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 2)
                        {
                            op2z = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op2z = op2z * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 3)
                        {
                            op3z = Convert.ToDouble(ObtainTotal(a, auxiliar, i));
                            auxiliar = i + 1;
                            op3z = op3z * checkNegative();
                            auxiliar3 = 0;
                        }
                        break;
                    case '=':
                        if (auxiliar2 == 1)
                        {
                            op1r = Convert.ToDouble(ObtainRes(a, i + 1, a.Length));
                            auxiliar = i + 1;
                            op1r = op1r * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 2)
                        {
                            op2r = Convert.ToDouble(ObtainTotal(a, i + 1, a.Length));
                            auxiliar = i + 1;
                            op2r = op2r * checkNegative();
                            auxiliar3 = 0;
                        }
                        else if (auxiliar2 == 3)
                        {
                            op3r = Convert.ToDouble(ObtainTotal(a, i + 1, a.Length));
                            auxiliar = i + 1;
                            op3r = op3r * checkNegative();
                            auxiliar3 = 0;
                        }
                        break;
                }
                i++;
            }
        }
        private int checkNegative()
        {
            if (auxiliar3 == 0)
            {
                return 1;
            }
            else if (auxiliar3 == 1)
            {
                return -1;
            }
            return 1;
        }
        private string ObtainTotal(char[] b, int c, int d)
        {
            string num = "";
            while (c < d)
            {
                if (b[c] == '+')
                {
                    //do nothing
                    auxiliar3 = 0;
                }
                else if (b[c] == '-')
                {
                    auxiliar3 = 1;
                }
                else
                {
                    num = num + b[c].ToString();
                }
                c++;
            }
            return num;
        }
        private string ObtainRes(char[] e, int f, int g)
        {
            string res = "";
            while (f < g)
            {
                if (e[f] == '+')
                {
                    //do nothing
                    auxiliar3 = 0;
                }
                else if (e[f] == '-')
                {
                    auxiliar3 = 1;
                }
                else
                {
                    res = res + e[f].ToString();
                }
                f++;
            }
            return res;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try {
                calcularVariables();
                while (i != 2)
                {
                    Contador++;
                    if (i == 0)
                    {
                        ObtainVals();
                        Iteracion();
                        CalculeError();
                    }
                    else
                    {
                        Iteracion();
                        CalculeError();
                    }
                    if (Ea_X <= ErrorMinimo && Ea_Y <= ErrorMinimo && Ea_Z <= ErrorMinimo)
                    {
                        i = 2;
                    }
                }
                TryPrintResult();
                i = 0;
                dibuja();
            }
            catch
            {
                MessageBox.Show("Por Favor Ingresa Todos Los Datos Correspondientes", "Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void limpiar()
        {
            txtErrorMinimo.Clear();
            txtErrorX.Clear();
            txtErrorY.Clear();
            txtErrorZ.Clear();
            txtIteraciones.Clear();
            txt_res1.Clear();
            txt_res2.Clear();
            txt_res3.Clear();
            txt_ValX.Clear();
            txt_ValY.Clear();
            txt_ValZ.Clear();
            txt_x1.Clear();
            txt_x2.Clear();
            txt_x3.Clear();
            txt_y1.Clear();
            txt_y2.Clear();
            txt_y3.Clear();
            txt_z1.Clear();
            txt_z2.Clear();
            txt_z3.Clear();
            
        }
    }
}
