using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.TiposDePrenda;

namespace Dominio
{
    public class Camisa : Prenda
    {
        private TipoManga manga;
        private TipoCuello cuello;

        public Camisa(TipoCalidad calidad, double precioUnitario, bool esCorta, bool esMao)
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

        internal TipoManga Manga { get => manga; set => manga = value; }
        internal TipoCuello Cuello { get => cuello; set => cuello = value; }
    }
}
