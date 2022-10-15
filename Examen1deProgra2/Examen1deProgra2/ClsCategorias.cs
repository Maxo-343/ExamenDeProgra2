using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1deProgra2
{


    internal class ClsCategorias
    {

        List<int> categorias = new List<int>();

        public void ListadoCategorioas()
        {
            categorias.Add(1);
            categorias.Add(2);
            categorias.Add(3);

        }



        public void Promocion()
        {

        }
        public void ListadoCategorias()
        {

        }
        public bool ExisteCategoria(int num)
        {
            if (categorias.Contains(num))
            {
                Console.WriteLine($"La categoria {num}");
                return true;
            }
            else
                return true;
        }
    }



}