using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.TiposDePrenda;

namespace Dominio
{
    public class Pantalon : Prenda
    {
        private TipoPantalon modelo;

        public Pantalon(TipoCalidad calidad, double precioUnitario, bool esChupin) 
            : base(calidad, precioUnitario)
        {
            if (esChupin)
                this.modelo = TipoPantalon.chupin;
            else
                this.modelo = TipoPantalon.comun;
        }

        internal TipoPantalon Modelo { get => modelo; set => modelo = value; }
    }
}
