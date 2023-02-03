using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Pantalon : Prenda
    {
        internal enum TipoPantalon { comun, chupin};
        private TipoPantalon modelo;

        public Pantalon(TipoCalidad calidad, float precioUnitario, int cantStock, TipoPantalon modelo) 
            : base(calidad, precioUnitario, cantStock)
        {
            this.modelo = modelo;
        }

        internal TipoPantalon Modelo { get => modelo; set => modelo = value; }
    }
}
