using static Dominio.TiposDePrenda;

namespace Dominio
{
    internal class Camisa : Prenda
    {
        private TipoManga manga;
        private TipoCuello cuello;

        internal Camisa(TipoCalidad calidad, double precioUnitario, bool esCorta, bool esMao)
            : base(calidad, precioUnitario)
        {
            if (esMao)
                this.cuello = TipoCuello.mao;
            else
                this.cuello = TipoCuello.comun;

            if (esCorta)
                this.manga = TipoManga.corta;
            else
                this.manga = TipoManga.larga;
        }

        internal TipoManga Manga { get => manga;}
        internal TipoCuello Cuello { get => cuello;}
    }
}
