using Examen1deProgra2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1deProgra2
{
    internal class ClsVendedor2 : ClsVendedores, ClsInterfaces.Ivendedor2
    {
        public ClsVendedor2(string nombre)
        {
            nombre = "Oscar";
        }

        public string VentasCredito()
        {
            return $"Con {nombre}, puede comprar a credito";

        }
    }
}
