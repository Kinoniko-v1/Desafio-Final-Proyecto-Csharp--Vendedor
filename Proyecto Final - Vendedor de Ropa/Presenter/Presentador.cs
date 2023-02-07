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
            ConexionBD.CrearTablaStock();
            ConexionBD.GuardarStock();

            _vendedor = new Vendedor();
            _tienda = new Tienda();
            _View = view;
            _cotizacion = new Cotizacion();
        }
        public string MostrarHistorial()
        {
            // Acceder a la base de datos
            // Devolver el resultado a la vista

            string msj = ConexionBD.CrearTablaHistorial();
            _View.ManejarErrores(msj);
            return ConexionBD.LeerHistorial();
            
        }
        public void Cotizar(double precioUnitario, int cantUnidades, string calidad,
            string prendaTipo, bool chupin, bool mao, bool corta)
        {
            if(_cotizacion == null)
                _cotizacion = new Cotizacion(_vendedor.CodigoVendedor, cantUnidades, _tienda);
            else
            {
                _cotizacion.CodigoVendedor = _vendedor.CodigoVendedor;
                _cotizacion.CantUnidades = cantUnidades;
                _cotizacion.Tienda = _tienda;
            }

            _cotizacion.CrearPrenda(prendaTipo,calidad,precioUnitario,mao,corta,chupin);

            double resultado =_cotizacion.CalcularCotizacion();

            if (resultado >= 0)
            {
                _cotizacion.AlmacenarCotizacion();
            }
            else if(resultado < 0)
            {
                _View.ManejarErrores(resultado.ToString());
                resultado = 0;
            }

            _View.MostrarResultado(resultado.ToString());
        }
        public void Actualizar(ref string nombreTienda, ref string direccionTienda, ref string vendedorInfo)
        {
            nombreTienda = _tienda.Nombre;
            direccionTienda = _tienda.Direccion;
            vendedorInfo = $"{_vendedor.Nombre} {_vendedor.Apellido} | {_vendedor.CodigoVendedor}";
        }
        public void Actualizar(string prenda,string calidad, bool corta, bool mao,bool chupin)
        {
            string tipoPrenda = "";
            if(prenda == "camisa")
            {
                tipoPrenda += "C" + calidad.ToUpper()[0];
                if (corta)
                    tipoPrenda += "C";
                else
                    tipoPrenda += "L";
                if (mao)
                    tipoPrenda += "M";
                else
                    tipoPrenda += "C";
            }
            else if(prenda == "pantalon")
            {
                tipoPrenda += "P" + calidad.ToUpper()[0];
                if (chupin)
                    tipoPrenda += "Ch";
                else
                    tipoPrenda += "Cm";
            }

            if(_tienda.ListadoPrendas.Count == 0) 
            {
                _View.ManejarErrores("stock");
            }
            else
            {
                _View.ActualizarStock(_tienda.ListadoPrendas[tipoPrenda]);
                _cotizacion.PrendaCod = tipoPrenda;
            }
        }
    }
}
