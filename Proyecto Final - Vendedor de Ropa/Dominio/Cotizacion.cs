using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.TiposDePrenda;

namespace Dominio
{
    public class Cotizacion
    {
        private DateTime _fechaHora;

        private int _codigoVendedor;
        private Tienda _tienda;

        private int _cantUnidades;
        private Camisa _camisa;
        private Pantalon _pantalon;
        private string _prendaCod;
        private string _prenda;

        private double _resultado;

        public DateTime FechaHora { get => _fechaHora;}
        public int CodigoVendedor { get => _codigoVendedor; set => _codigoVendedor = value; }
        public int CantUnidades { get => _cantUnidades; set =>_cantUnidades = value; }
        public double Resultado { get => _resultado;}
        public string PrendaCod {set => _prendaCod = value; }
        public string Prenda { get => _prenda; set => _prenda = value; }
        public Tienda Tienda { get => _tienda; set => _tienda = value; }

        public Cotizacion()
        {
            _fechaHora = DateTime.Now;
            _resultado = double.NaN;
        }
        public Cotizacion(int codigoVendedor, int cantUnidades, Tienda tienda)
        {
            // Crear identificación.
            _fechaHora = DateTime.Now;
            _resultado = double.NaN;
            _codigoVendedor = codigoVendedor;
            _cantUnidades = cantUnidades;
            _tienda = tienda;
        }

        public void AlmacenarCotizacion()
        {
            //Se llama a este método desde esta clase porque debe ser la encarga de validar el resultado,
            //si aún no se ha calculado un resutlado, no debe dejar que se almacene.
            if (_resultado != double.NaN)
            {
                ConexionBD.Almacenar(this);
            }
        }

        public void CrearPrenda(string prenda, string calidad, double precioUnitario, bool mao, bool corta, bool chupin)
        {
            TipoCalidad calidadRopa = calidad == "standard" ? TipoCalidad.Standard : TipoCalidad.Premium;

            if (prenda == "camisa")
            {
                _camisa = new Camisa(calidadRopa, precioUnitario, mao, corta);
                _prenda = $"{prenda} {calidad} {_camisa.Manga.ToString()} {_camisa.Cuello.ToString()}";
            }
            else if (prenda == "pantalon")
            {
                _pantalon = new Pantalon(calidadRopa, precioUnitario, chupin);
                _prenda = $"{prenda} {calidad} {_pantalon.Modelo.ToString()}";
            }
        }

        public double CalcularCotizacion()
        {
            double resultado;

            if(_cantUnidades < _tienda.ListadoPrendas[_prendaCod])
            {
                if (_camisa != null)
                    resultado = CalcularCotizacion(_camisa);
                else if (_pantalon != null)
                    resultado = CalcularCotizacion(_pantalon);
                else
                    resultado = -3;
            }
            else
            {
                resultado = -2;
            }
            return resultado;
        }

        private double CalcularCotizacion(Camisa prenda)
        {
            _resultado = prenda.PrecioUnitario;

            if (prenda.Manga == TipoManga.corta)
                _resultado -= _resultado * 0.1;
            if (prenda.Cuello == TipoCuello.mao)
                _resultado += _resultado * 0.03;

            _resultado = CalcularCalidad(prenda.Calidad);

            return _resultado;
        }

        private double CalcularCotizacion(Pantalon prenda)
        {
            _resultado = prenda.PrecioUnitario;

            if (prenda.Modelo == TipoPantalon.chupin)
            {
                _resultado -= _resultado * 0.12;
            }

            _resultado = CalcularCalidad(prenda.Calidad);

            return _resultado;
        }

        private double CalcularCalidad(TipoCalidad calidad)
        {
            if (calidad == TipoCalidad.Premium)
            {
                _resultado += (_resultado * 0.3);
            }
            _resultado *= _cantUnidades;

            return _resultado;
        }
    }
}
