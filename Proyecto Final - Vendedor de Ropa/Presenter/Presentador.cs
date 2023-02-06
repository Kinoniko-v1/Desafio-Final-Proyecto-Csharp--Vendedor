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

        private readonly IView _View;

        public Presentador(IView view)
        {
            _vendedor = new Vendedor();
            _tienda = new Tienda();
            _View = view;

            //ConexionBD.CrearStock();
        }
        public string MostrarHistorial()
        {
            // Acceder a la base de datos
            // Devolver el resultado a la vista

            string msj = ConexionBD.CrearTablaHistorial();
            _View.ModTitle(msj);
            return ConexionBD.LeerHistorial();
            
        }
        public void Cotizar(double precioUnitario,int cantUnidades,string calidad, 
            string prendaTipo,bool chupin, bool mao, bool corta)
        {

            _cotizacion = new Cotizacion(_vendedor.CodigoVendedor,cantUnidades);
            // Refactorizar la creación de prendas. Crearla en la clase Tienda.

            _cotizacion.CrearPrenda(prendaTipo,calidad,precioUnitario,mao,corta,chupin);
            //_tienda.InstanciarPrenda(prendaTipo, calidad, precioUnitario, mao, corta, chupin);

            double resultado =_cotizacion.CalcularCotizacion();
            _cotizacion.AlmacenarCotizacion();

            _View.MostrarResultado(resultado.ToString());
        }
        public void Actualizar(ref string nombreTienda, ref string direccionTienda, ref string vendedorInfo)
        {
            nombreTienda = _tienda.Nombre;
            direccionTienda = _tienda.Direccion;
            vendedorInfo = $"{_vendedor.Nombre} {_vendedor.Apellido} | {_vendedor.CodigoVendedor}";
        }
    }
}
