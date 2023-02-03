using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Camisa : Prenda
    {
        internal enum TipoManga { larga, corta};
        internal enum TipoCuello { comun, mao};

        private TipoManga manga;
        private TipoCuello cuello;

        public Camisa(TipoCalidad calidad, float precioUnitario, int cantStock, TipoManga manga, TipoCuello cuello)
            : base(calidad, precioUnitario, cantStock)
        {
            this.manga = manga;
            this.cuello = cuello;
        }

        internal TipoManga Manga { get => manga; set => manga = value; }
        internal TipoCuello Cuello { get => cuello; set => cuello = value; }
    }
}
