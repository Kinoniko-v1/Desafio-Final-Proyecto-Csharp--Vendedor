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
        private Dictionary<string, int> listadoPrendas = new Dictionary<string, int>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public Dictionary<string, int> ListadoPrendas { get => listadoPrendas;}

        public Tienda(string nombre = "MayorPrendista", string direccion = "Av. Siempre Vida 321")
        {
            this.nombre = nombre;
            this.direccion = direccion;

            if(listadoPrendas.Count == 0)
            {
                listadoPrendas = ConexionBD.LeerStock();
            }
        }

        private void GuardarStock()
        {
            listadoPrendas.Add("PSCh",750);
            listadoPrendas.Add("PSCm",250);
            listadoPrendas.Add("PPCh",750);
            listadoPrendas.Add("PPCm",250);
            
            listadoPrendas.Add("CSCC",150);
            listadoPrendas.Add("CSCM",100);
            listadoPrendas.Add("CSLC",175);
            listadoPrendas.Add("CSLM",75);
            
            listadoPrendas.Add("CPCC",150);
            listadoPrendas.Add("CPCM",100);
            listadoPrendas.Add("CPLC",175);
            listadoPrendas.Add("CPLM",75);
        }
    }
}
