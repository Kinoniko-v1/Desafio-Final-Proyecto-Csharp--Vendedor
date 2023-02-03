using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Cotizacion
    {
        private int identificacion;
        private DateTime fechaHora;
        private int codigoVendedor;
        private Prenda prenda;
        private int cantDeUnidades;
        private float resultado;
        
        public void AlmacenarCotizacion()
        {
            
        }

        public float CalcularCotizacion(Camisa prenda)
        {
            float precioInicial = prenda.PrecioUnitario;

            if (prenda.Manga == Camisa.TipoManga.corta && prenda.Cuello == Camisa.TipoCuello.mao)
            {
                    resultado -= resultado * 0.1f;
                    resultado += resultado * 0.03f;
            }
            else
            {
                if (prenda.Manga == Camisa.TipoManga.corta)
                    resultado -= resultado * 0.1f;
                else if (prenda.Cuello == Camisa.TipoCuello.mao)
                    resultado += resultado * 0.03f;
            }

            resultado = CalcularCotizacion(prenda.Calidad);

            return resultado;
        }

        public float CalcularCotizacion(Pantalon prenda)
        {
            resultado = prenda.PrecioUnitario;

            if (prenda.Modelo == Pantalon.TipoPantalon.chupin)
                resultado -= resultado * 0.12f;

            resultado = CalcularCotizacion(prenda.Calidad);

            return resultado;
        }

        private float CalcularCotizacion(Prenda.TipoCalidad calidad)
        {
            if (calidad == Prenda.TipoCalidad.Premium)
                resultado += resultado * 0.3f;

            return resultado;
        }
    }
}
