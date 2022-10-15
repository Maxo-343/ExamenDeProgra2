using System;

namespace Examen1deProgra2
{
    public class ClsArticulo
    {
        static private int i, opcion, x;
        protected int[] Codigo { get; set; } = new int[5];
        protected string[] Nombre { get; set; } = new string[5];
        protected int[] Precio { get; set; } = new int[5];
        public ClsArticulo(int[] Codigo, string[] Nombre, int[] Precio)
        {
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Precio = Precio;
        }

        public ClsArticulo()
        {

        }



        //ClsArticulo producto = new ClsArticulo();

        public void AgregarArticulo()
        {
            int num = 1;
            for (i = 0; i < 1; i++)
            {
                Console.WriteLine($"Digite el codigo del Articulo numero {num}");
                Codigo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el nombre del Articulo");
                Nombre[i] = Console.ReadLine();
                Console.WriteLine("Digite el precio del Articulo");
                Precio[i] = int.Parse(Console.ReadLine());
                num++;

            }
            Console.WriteLine("Presione Enter para continuar");
            Console.ReadKey();

        }

        public void RemoverArticulo()
        {

            ListaArticulos();

            Console.WriteLine("Digite el Numero del articulo que desea borrar");
            opcion = int.Parse(Console.ReadLine());
            for (x = 0; x < 1; x++)
            {
                if (Codigo[i] == opcion)
                {
                    Codigo[i] = 0;
                    Nombre[i] = "";
                    Precio[i] = 0;
                }
            }
            Console.WriteLine("El elemento ha sido borrado");


        }

        public void ListaArticulos()
        {
            for (x = 0; x < 1; x++)
            {
                Console.WriteLine($"Codigo {Codigo[x]} Nombre {Nombre[x]} Precio {Precio[x]}");

            }


        }
    }
}
