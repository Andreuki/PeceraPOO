using System;
using System.Threading;
/*A partir de la última versión "oficial" del simulador de pecera (ejercicio 157), realiza los siguientes cambios:

Existirá una clase base "SpriteTexto", abstracta, con un método Dibujar y un método Mover, ambos abstractos. De ella heredará la clase Pez.
En la clase Pez, el método Nada pasará a llamarse Mover.
Existirá una nueva clase "Burbuja", sellada, que también heredará de "SpriteTexto". 
Una burbuja tendrá como "imagen" una letra O y se moverá hacia arriba (hasta llegar a la parte superior de la pantalla, momento en el que volverá a aparecer por debajo).
Añade dos burbujas al simulador.
Andrea Peñalver hernández
 */
namespace ejercicio_168
{
    class SimuladorDePecera
    {
        static void Main(string[] args)
        {
            SpriteTexto[] elementosPecera = new SpriteTexto[6];
            elementosPecera[0] = new Pez(15, 15);
            elementosPecera[1] = new PezMenor(5, 5);
            elementosPecera[2] = new PezMasGrande(20, 10);
            elementosPecera[3] = new Pez("><>", "<><", 2);
            elementosPecera[4] = new Burbuja(10, 20);
            elementosPecera[5] = new Burbuja(50, 10);


            bool salir = false;
            do
            {
                // Dibujado de pantalla
                Console.Clear();
                foreach (SpriteTexto p in elementosPecera)
                    p.Dibujar();

                // Comprobación de teclas
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey();
                    if (tecla.Key == ConsoleKey.Escape)
                        salir = true;
                }
                // Movimiento de elementos
                foreach (SpriteTexto p in elementosPecera)
                    p.Mover();
            }
            while (!salir);
        }
    }
}
