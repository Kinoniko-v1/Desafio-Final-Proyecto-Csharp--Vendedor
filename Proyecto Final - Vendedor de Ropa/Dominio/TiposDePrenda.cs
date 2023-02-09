using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    static internal class TiposDePrenda
    {
        internal enum TipoPrenda { pantalon, camisa};
        internal enum TipoCalidad { Standard, Premium };
        internal enum TipoManga { larga, corta };
        internal enum TipoCuello { comun, mao };
        internal enum TipoPantalon { comun, chupin };
    }
}
