using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.TiposDePrenda;


namespace Dominio
{
    public class Tienda
    {
        private string nombre;
        private string direccion;
        public List<Prenda> listadoPrendas;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Tienda(string nombre = "MayorPrendista", string direccion = "Av. Siempre Vida 321")
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }
        public void InstanciarPrenda(string prenda, string calidad, double precioUnitario, bool mao, bool corta, bool chupin)
        {
            TipoCalidad calidadRopa = calidad == "standard" ? TipoCalidad.Standard : TipoCalidad.Premium;

            if (prenda == "camisa")
            {
                 new Camisa(calidadRopa, precioUnitario, mao, corta);
            }
            else if (prenda == "pantalon")
            {
                 new Pantalon(calidadRopa, precioUnitario, chupin);
                //_pantalon = new Pantalon(calidadRopa, precioUnitario, chupin);
            }
        }
    }
}
