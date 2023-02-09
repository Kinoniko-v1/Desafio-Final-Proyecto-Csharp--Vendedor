using static Dominio.TiposDePrenda;

namespace Dominio
{
    internal class Pantalon : Prenda
    {
        private TipoPantalon modelo;

        internal Pantalon(TipoCalidad calidad, double precioUnitario, bool esChupin) 
            : base(calidad, precioUnitario)
        {
            if (esChupin)
                this.modelo = TipoPantalon.chupin;
            else
                this.modelo = TipoPantalon.comun;
        }

        internal TipoPantalon Modelo { get => modelo;}
    }
}
