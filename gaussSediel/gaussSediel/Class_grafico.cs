using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace gaussSediel
{
    class Class_grafico
    {
        Pen lapiznegro = new Pen(Color.White);
        Pen lapizrojo = new Pen(Color.Red,2);
        Graphics dibujo;
        int valorx, valory, i;

        public void p_valor_x(int valor)
        {
            valorx = valor;
        }
        public void p_valor_y(int valor)
        {
            valory = valor;
        }
        public void plano (PictureBox Gplano)
        {
            int x = Gplano.Width/2;
            int y = Gplano.Height/2;

            dibujo = Gplano.CreateGraphics();
            dibujo.TranslateTransform(x, y);
            dibujo.ScaleTransform(1, -1);

            dibujo.DrawLine(lapiznegro, x * -1, 0, x * 1, 0);
            dibujo.DrawLine(lapiznegro, y * -1, 0, y * 1, 0);
        }
        public void plano_coordenadas(PictureBox Gplano)
        {
            Gplano.Refresh();
            plano(Gplano);

            int x = Gplano.Width / 2;
            int y = Gplano.Height / 2;

            dibujo = Gplano.CreateGraphics();
            dibujo.TranslateTransform(x, y);
            dibujo.ScaleTransform(2, -2);

            for (i = -x; i < x; i = i + 5)
            {
                dibujo.DrawLine(lapiznegro, 7, i, -7, i);
                dibujo.DrawLine(lapiznegro, i, 5, i, -5);
            }
            dibujo.DrawLine(lapizrojo, valorx, 0, 0, valory);
        }
    }
}
