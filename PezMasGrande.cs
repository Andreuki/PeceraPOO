using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_168
{
    class PezMasGrande:Pez
    {
        public PezMasGrande(string nombre, string especie, int x, int y) :
           base(nombre, especie, x, y)
        {
            imagenDerecha = "></////////]º>";
            imagenIzquierda = "<º[\\\\\\\\\\\\\\><";
        }

        public PezMasGrande(int x, int y) : this("", "", x, y) { }
    }
}
