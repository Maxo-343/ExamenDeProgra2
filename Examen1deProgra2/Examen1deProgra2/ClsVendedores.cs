using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1deProgra2
{
    internal class ClsVendedores
    {
        public string nombre { get; set; }

        public ClsVendedores() { }


        private static Dictionary<int, string> listaVendedores = new Dictionary<int, string>()
        {
            {1, "Juan"},
            {2, "Oscar"}
        };

        public void ListadoVendedores()
        {
            foreach (var item in listaVendedores)
            {
                Console.WriteLine($"Codigo Vendedor {item.Key} nombre {item.Value}");
            }
        }

        public static string ConsultaVendedor(int codVendedor)
        {
            if (listaVendedores.TryGetValue(codVendedor, out string resultado))
            {
                return "El nombre del vendedor es" + resultado;
            }
            else
            {
                return "El vendedor no existe";
            }

        }
    }
}