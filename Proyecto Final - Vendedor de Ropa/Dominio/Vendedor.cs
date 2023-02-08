using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vendedor
    {
        private string _nombre;
        private string _apellido;
        private int _codigoVendedor;
        private string _codigoPrenda;
        private Tienda _tienda;

        private Cotizacion _cotizacion;

        public Vendedor(Tienda tienda,string nombre="Nicolas", string apellido="Quintana")
        {
            _nombre = nombre;
            _apellido = apellido;
            _codigoVendedor = GenerarCodigo();
            _tienda = tienda;
        }

        public int CodigoVendedor { get => _codigoVendedor; set => _codigoVendedor = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public Cotizacion Cotizacion { get => _cotizacion; set => _cotizacion = value; }
        public string CodigoPrenda { get => _codigoPrenda; set => _codigoPrenda = value; }

        private int GenerarCodigo()
        {
            int random = new Random().Next();
            return random;
        }
        public double CrearCotizacion(double precioUnitario, int cantUnidades, string calidad,
            string prendaTipo, bool chupin, bool mao, bool corta)
        {
            _cotizacion = new Cotizacion(this, cantUnidades, _tienda);
            _cotizacion.CrearPrenda(prendaTipo,calidad,precioUnitario,mao,corta,chupin);
            double resultado = _cotizacion.CalcularCotizacion();

            if (resultado >= 0)
                _cotizacion.AlmacenarCotizacion();

            return resultado;
        }
    }
}
