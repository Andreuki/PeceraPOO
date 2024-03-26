using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_168
{
    class PezMenor: Pez
    {
        public PezMenor(string nombre, string especie, int x, int y) : base(nombre, especie, x, y)
        {
            imagenDerecha = "><=>";
            imagenIzquierda = "<=><";
        }

        public PezMenor(int x, int y) : this("", "", x, y) { }
    }

}
