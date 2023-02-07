using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter
{
    public interface IView
    {
        void MostrarResultado(string resultado);
        void ActualizarStock(int stock);
        void ActualizarDatosUsuario();
        void ManejarErrores(string msj);
    }
}
