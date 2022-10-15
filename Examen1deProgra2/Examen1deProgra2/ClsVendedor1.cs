using Examen1deProgra2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1deProgra2
{
    internal class ClsVendedor1 : ClsVendedores, ClsInterfaces.Ivendedor1
    {
        public ClsVendedor1(string nombre)
        {
            nombre = "Juan";
        }

        public void VentasContado()
        {
            Console.WriteLine($"Con {nombre}, puede comprar de Contado");
        }
    }
}