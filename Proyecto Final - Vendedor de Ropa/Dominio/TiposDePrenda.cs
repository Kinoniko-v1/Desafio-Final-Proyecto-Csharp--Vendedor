using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class TiposDePrenda
    {
        public enum TipoPrenda { pantalon, camisa};
        public enum TipoCalidad { Standard, Premium };
        public enum TipoManga { larga, corta };
        public enum TipoCuello { comun, mao };
        public enum TipoPantalon { comun, chupin };
    }
}
