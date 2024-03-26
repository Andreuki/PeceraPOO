using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_168
{
    sealed class Burbuja : SpriteTexto
    {
        public Burbuja(int x, int y)
        {
            this.x = (byte)x;
            this.y = (byte)y;
            velocidad = 1;
        }
        public override void Mover()
        {
            y -= velocidad;
            if (y <= 2) y = 20;
        }

        public override void Dibujar()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("o");
        }
    }
}
