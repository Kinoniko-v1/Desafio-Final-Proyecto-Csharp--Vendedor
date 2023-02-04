using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Tienda
    {
        private string nombre;
        private string direccion;
        private List<Prenda> prendas;

        public Tienda(string nombre="MayorPrendista", string direccion="Av. Siempre Vida 321")
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }
    }
}
