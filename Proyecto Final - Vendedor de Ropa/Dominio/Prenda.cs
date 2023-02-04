﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.TiposDePrenda;

namespace Dominio
{
    public abstract class Prenda
    {
        protected TipoCalidad calidad;
        protected double precioUnitario;
        protected int cantStock;

        internal Prenda(TipoCalidad calidad, double precioUnitario)
        {
            this.calidad = calidad;
            this.precioUnitario = precioUnitario;
        }

        internal TipoCalidad Calidad { get => calidad; set => calidad = value; }
        internal double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        internal int CantStock { get => cantStock; set => cantStock = value; }
    }
}
