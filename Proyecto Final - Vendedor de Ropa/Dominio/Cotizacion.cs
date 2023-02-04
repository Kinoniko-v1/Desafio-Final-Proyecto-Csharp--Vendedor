using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.TiposDePrenda;

namespace Dominio
{
    public class Cotizacion
    {
        private int _identificacion;
        private DateTime _fechaHora;

        private int _codigoVendedor;
        private int _cantUnidades;
        private Camisa _camisa;
        private Pantalon _pantalon;

        private double _resultado;

        public Cotizacion(int codigoVendedor, int cantUnidades)
        {
            // Crear identificación.
            _fechaHora = DateTime.Now;
            _codigoVendedor = codigoVendedor;
            _cantUnidades = cantUnidades;
        }

        public void AlmacenarCotizacion()
        {

        }

        public void CrearPrenda(string prenda, string calidad, double precioUnitario, bool mao, bool corta, bool chupin)
        {
            TipoCalidad calidadRopa;

            if (calidad == "standard")
                calidadRopa = TipoCalidad.Premium;
            else
                calidadRopa = TipoCalidad.Standard;


            if (prenda == "camisa")
            {
                _camisa = new Camisa(calidadRopa, precioUnitario, mao, corta);
            }
            else if (prenda == "pantalon")
            {
                _pantalon = new Pantalon(calidadRopa, precioUnitario, chupin);
            }
        }

        public double CalcularCotizacion()
        {
            double resultado;

            if (_camisa != null)
                resultado = CalcularCotizacion(_camisa);
            else if (_pantalon != null)
                resultado = CalcularCotizacion(_pantalon);
            else
                resultado = double.MaxValue;

            return resultado;
        }

        private double CalcularCotizacion(Camisa prenda)
        {
            if (prenda.Manga == TipoManga.corta && prenda.Cuello == TipoCuello.mao)
            {
                _resultado -= _resultado * 0.1;
                _resultado += _resultado * 0.03;
            }
            else
            {
                if (prenda.Manga == TipoManga.corta)
                    _resultado -= _resultado * 0.1;
                else if (prenda.Cuello == TipoCuello.mao)
                    _resultado += _resultado * 0.03;
            }

            _resultado = CalcularCalidad(prenda.Calidad);

            return _resultado;
        }

        private double CalcularCotizacion(Pantalon prenda)
        {
            _resultado = prenda.PrecioUnitario;

            if (prenda.Modelo == TipoPantalon.chupin)
                _resultado -= _resultado * 0.12;

            _resultado = CalcularCalidad(prenda.Calidad);

            return _resultado;
        }

        private double CalcularCalidad(TipoCalidad calidad)
        {
            if (calidad == TipoCalidad.Premium)
                _resultado += _resultado * 0.3;
            return _resultado;
        }
    }
}
