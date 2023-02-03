using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Vendedor
    {
        private string nombre;
        private string apellido;
        private int codigoVendedor;

        public Vendedor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoVendedor = GenerarCodigo();
        }
        public int GenerarCodigo()
        {
            return int.MaxValue;
        }

        public void CrearCotización()
        {

        }
    }
}
