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

        private Tienda _tienda;
        private Vendedor _vendedor;

        private int _cantUnidades;
        private string _prenda;
        private Camisa _camisa;
        private Pantalon _pantalon;

        private double _resultado;

        public DateTime FechaHora { get => _fechaHora;}
        public int CantUnidades 
        {
            get => _cantUnidades; 
            set 
            {
                if (value <= 0)
                    _cantUnidades = int.MinValue;
                else
                    _cantUnidades = value; 
            } 
        }
        public double Resultado { get => _resultado;}
        public string Prenda { get => _prenda; set => _prenda = value; }
        public Tienda Tienda { get => _tienda; set => _tienda = value; }
        public Vendedor Vendedor { get => _vendedor; set => _vendedor = value; }

        public Cotizacion(Vendedor vendedor, int cantUnidades, Tienda tienda)
        {
            // Crear identificación.
            _fechaHora = DateTime.Now;
            _resultado = double.NaN;
            _vendedor = vendedor;
            CantUnidades = cantUnidades;
            _tienda = tienda;
        }

        public void AlmacenarCotizacion()
        {
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
            if (_cantUnidades < _tienda.ListadoPrendas[_vendedor.CodigoPrenda] && _cantUnidades != int.MinValue)
            {
                if (_camisa != null)
                    return CalcularCotizacion(_camisa);
                else if (_pantalon != null)
                    return CalcularCotizacion(_pantalon);
                else
                    return -3; // Resultado para manejar el error (no se crearon los objetos).
            }
            else if (_cantUnidades == int.MinValue)
            {
                return -1; // Resultado para manejar el error (cantidad es 0 o menor).
            }
            else
                return -2; // Resultado para manejar el error (stock insuficiente).
        }

        private double CalcularCotizacion(Camisa prenda)
        {
            if (prenda.PrecioUnitario.ToString() == "NaN")
            {
                return -1;
            }
            else
            {
                _resultado = prenda.PrecioUnitario;

                if (prenda.Manga == TipoManga.corta)
                    _resultado -= _resultado * 0.1;
                if (prenda.Cuello == TipoCuello.mao)
                    _resultado += _resultado * 0.03;

                _resultado = CalcularCalidad(prenda.Calidad);

                return _resultado;
            }
        }

        private double CalcularCotizacion(Pantalon prenda)
        {
            if (prenda.PrecioUnitario.ToString() == "NaN")
            {
                return -1;
            }
            else
            {
                _resultado = prenda.PrecioUnitario;

                if (prenda.Modelo == TipoPantalon.chupin)
                {
                    _resultado -= _resultado * 0.12;
                }

                _resultado = CalcularCalidad(prenda.Calidad);

                return _resultado;
            }
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
