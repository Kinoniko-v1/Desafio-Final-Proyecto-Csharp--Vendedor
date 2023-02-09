using Dominio;

namespace Presenter
{
    public class Presentador
    {
        private Tienda _tienda;
        private Vendedor _vendedor;

        private readonly IView _View;

        public Presentador(IView view)
        {
            ConexionBD.CrearTablaStock();
            ConexionBD.GuardarStock();

            _tienda = new Tienda();
            _vendedor = new Vendedor(_tienda);
            _View = view;
        }
        public string MostrarHistorial()
        {
            // Acceder a la base de datos
            // Devolver el resultado a la vista

            string msj = ConexionBD.CrearTablaHistorial();
            _View.ManejarErrores(msj);
            return ConexionBD.LeerHistorial();
            
        }
        public void Cotizar(double precioUnitario, int cantUnidades, string calidad,
            string prendaTipo, bool chupin, bool mao, bool corta)
        {

            double resultado =_vendedor.CrearCotizacion(precioUnitario,cantUnidades,calidad,prendaTipo,chupin,
                mao,corta);
            
            if (resultado < 0 | resultado == double.NaN)
            {
                _View.ManejarErrores(resultado.ToString());
                resultado = 0;
            }

            _View.MostrarResultado(resultado.ToString());
        }
        // Actualiza datos del usuario en la interfaz.
        public void Actualizar(ref string nombreTienda, ref string direccionTienda, ref string vendedorInfo)
        {
            nombreTienda = _tienda.Nombre;
            direccionTienda = _tienda.Direccion;
            vendedorInfo = $"{_vendedor.Nombre} {_vendedor.Apellido} | {_vendedor.CodigoVendedor}";
        }
        // Actualiza el stock de las prendas.
        public void Actualizar(string prenda,string calidad, bool corta, bool mao,bool chupin)
        {
            string prendaCodigo = "";
            if(prenda == "camisa")
            {
                prendaCodigo += "C" + calidad.ToUpper()[0];
                if (corta)
                    prendaCodigo += "C";
                else
                    prendaCodigo += "L";
                if (mao)
                    prendaCodigo += "M";
                else
                    prendaCodigo += "C";
            }
            else if(prenda == "pantalon")
            {
                prendaCodigo += "P" + calidad.ToUpper()[0];
                if (chupin)
                    prendaCodigo += "Ch";
                else
                    prendaCodigo += "Cm";
            }

            if(_tienda.ListadoPrendas.Count == 0) 
            {
                _View.ManejarErrores("stock");
            }
            else
            {
                _vendedor.CodigoPrenda = prendaCodigo;
                _View.ActualizarStock(_tienda.ListadoPrendas[prendaCodigo]);
            }
        }
    }
}
