using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_168
{
     abstract class SpriteTexto
    {
        protected byte x, y, velocidad;

        public int GetX() { return Convert.ToInt32(x); }
        public int GetY() { return Convert.ToInt32(y); }

        public void SetX(int x) { this.x = (byte)x; }
        public void SetY(int y) { this.y = (byte)y; }

        public abstract void Dibujar();
        public abstract void Mover();
    }
}
