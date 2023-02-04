using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vendedor
    {
        private string nombre;
        private string apellido;
        private int codigoVendedor;

        public Vendedor(string nombre="Nicolas", string apellido="Quintana")
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.codigoVendedor = GenerarCodigo();
        }

        public int CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }

        public int GenerarCodigo()
        {
            int random = new Random().Next();
            return random;
        }

    }
}
