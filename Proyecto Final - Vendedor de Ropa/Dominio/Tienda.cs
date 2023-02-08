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
        private string _nombre;
        private string _direccion;
        private Vendedor vendedor;
        private Dictionary<string, int> listadoPrendas = new Dictionary<string, int>();

        private List<Prenda> prendas = new List<Prenda>();

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public Dictionary<string, int> ListadoPrendas { get => listadoPrendas;}

        public Tienda(string nombre = "MayorPrendista", string direccion = "Av. Siempre Vida 321")
        {
            _nombre = nombre;
            _direccion = direccion;

            if(listadoPrendas.Count == 0)
            {
                listadoPrendas = ConexionBD.LeerStock();
            }
        }
        /*
        private void GuardarStock()
        {
            prendas.Add(new Pantalon(TipoCalidad.Standard, TipoPantalon.chupin));
            prendas.Add(new Pantalon(TipoCalidad.Standard, TipoPantalon.comun));
            prendas.Add(new Pantalon(TipoCalidad.Premium, TipoPantalon.chupin));
            prendas.Add(new Pantalon(TipoCalidad.Premium, TipoPantalon.comun));

            prendas.Add(new Camisa());
            prendas.Add(new Camisa());
            prendas.Add(new Camisa());
            prendas.Add(new Camisa());

            prendas.Add(new Camisa());
            prendas.Add(new Camisa());
            prendas.Add(new Camisa());
            prendas.Add(new Camisa());
        }
        */
    }
}
