using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_168
{
    class Pez: SpriteTexto
    {
        protected string nombre, especie, imagenDerecha, imagenIzquierda;
        protected bool haciaLaDerecha;

        public string GetNombre() { return nombre; }
        public string GetEspecie() { return especie; }

        public void SetNombre(string nombre) { this.nombre = nombre; }
        public void SetEspecie(string especie) { this.especie = especie; }



        public Pez(string nombre, string especie, int x, int y)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.x = (byte)x;
            this.y = (byte)y;
            haciaLaDerecha = true;
            imagenDerecha = "><(((º>";
            imagenIzquierda = "<º)))><";
            velocidad = 1;
        }

        public Pez(int x, int y) : this("", "", x, y) { }

        public Pez(string imagenDerecha, string imagenIzquierda, byte velocidad) :
            this("", "", 20, 8)
        {
            this.imagenDerecha = imagenDerecha;
            this.imagenIzquierda = imagenIzquierda;
            this.velocidad = velocidad;
        }

        public override void Mover()
        {
            if (haciaLaDerecha)
            {
                x += velocidad;
                if (x > 50) haciaLaDerecha = false;
            }
            else
            {
                x -= velocidad;
                if (x < 10) haciaLaDerecha = true;
            }
        }

        public override void Dibujar()
        {
            Console.SetCursorPosition(x, y);
            if (haciaLaDerecha) Console.Write(imagenDerecha);
            else Console.Write(imagenIzquierda);
        }
    }   
}
