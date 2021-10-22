using System;

namespace Terreno
{
    class Program
    {
        static void Main(string[] args)
        {
            TerrenoRectangular miterreno = new TerrenoRectangular();
            miterreno.obtenerArea();
            miterreno.obtenerPrecio();

        }

    }

    class TerrenoRectangular
    {
        //Atributos
        double largo, ancho, area, precio, pTotal;


        //Metodos

        public void obtenerArea()
        {
            Console.WriteLine("Digite el largo del terreno: ");
            largo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite el ancho del terreno: ");
            ancho = Int32.Parse(Console.ReadLine());

            area = largo * ancho;


            Console.WriteLine("El area total es: " + area + "m²");
        }

        public void obtenerPrecio()
        {
            Console.WriteLine("Digite el precio por m²: ");

            precio = Int32.Parse(Console.ReadLine());
            pTotal = area * precio;
            Console.WriteLine("El precio total del terreno es: " + pTotal);
        }

    }

}
