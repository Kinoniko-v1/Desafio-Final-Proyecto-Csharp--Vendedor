using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public class Presentador
    {
        private Tienda _tienda;
        private Vendedor _vendedor;

        private Cotizacion _cotizacion;
        private Prenda _prenda;

        private readonly IView _View;

        public Presentador(IView view)
        {
            _vendedor = new Vendedor();
            _tienda = new Tienda();
            _View = view;
        }
        public void MostrarHistorial()
        {
            // Acceder a la base de datos
            // Devolver el resultado a la vista
        }
        public void Cotizar(double precioUnitario,int cantUnidades,string calidad, 
            string prendaTipo,bool chupin, bool mao, bool corta)
        {
            // -Crear un objeto de la clase Prenda y Cotizacion.
            // -Realizar la Cotización.
            // -Almacenar la Cotización.
            // -Devuelve el Resultado a la vista.

            _cotizacion = new Cotizacion(_vendedor.CodigoVendedor,cantUnidades);
            _cotizacion.CrearPrenda(prendaTipo,calidad,precioUnitario,mao,corta,chupin);

            double resultado =_cotizacion.CalcularCotizacion();

            _View.MostrarResultado(resultado.ToString());
        }
    }
}
