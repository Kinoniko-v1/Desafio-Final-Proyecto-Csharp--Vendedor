using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Prenda
    {
        internal enum TipoCalidad {Standard, Premium };
        protected TipoCalidad calidad;
        protected float precioUnitario;
        protected int cantStock;

        internal Prenda(TipoCalidad calidad, float precioUnitario, int cantStock)
        {
            this.calidad = calidad;
            this.precioUnitario = precioUnitario;
            this.cantStock = cantStock;
        }

        internal TipoCalidad Calidad { get => calidad; set => calidad = value; }
        internal float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        internal int CantStock { get => cantStock; set => cantStock = value; }
    }
}
