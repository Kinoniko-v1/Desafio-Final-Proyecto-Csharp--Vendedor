using Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form, IView
    {
        private readonly Presentador _Presentador;

        private double _precioUnitario;
        private int _cantidad;
        private string _prenda = "camisa";
        private string _calidad;
        private bool _checkedMao;
        private bool _checkedCorta;
        private bool _checkedChupin;

        public Form1()
        {
            InitializeComponent();
            _Presentador = new Presentador(this);
            ActualizarDatosUsuario();
            Text = "Realize su operación...";
        }
        public void ModTitle(string msj)
        {
            if (msj != null)
                Text = msj;
            else
                Text = "Error msj is null";
        }
        public void ActualizarDatosUsuario()
        {
            string nombreT = nombreTienda.Text;
            string direccionT = direccionTienda.Text;
            string infoVendedor = vendedorInfo.Text;

            _Presentador.Actualizar(ref nombreT, ref direccionT, ref infoVendedor);

            nombreTienda.Text = nombreT;
            direccionTienda.Text = direccionT;
            vendedorInfo.Text = infoVendedor;
        }

        public void MostrarResultado(string resultado)
        {
            resultadoCotizacion.Text = resultado;
            if (resultado != "-1")
                Text = "¡Cotización realizada con éxito!";
            else
                Text = "Cotización fallida, cantidad ingresada superior al stock disponible.";
        }
        public void LeerInput()
        {

        }
        private void Historial_Click(object sender, EventArgs e)
        {
            VerHistorial historial = new VerHistorial(_Presentador.MostrarHistorial());
            historial.Show();
        }
        private void Cotizar_Click(object sender, EventArgs e)
        {
            // Asignar campos para pasarlos al presentador. Antes Validar.
            _checkedMao = checkMao.Checked;
            _checkedCorta = checkCorta.Checked;
            _checkedChupin = checkChupin.Checked;

            if (botonStandard.Checked)
                _calidad = botonStandard.Text.ToLower();
            else if (botonPremium.Checked)
                _calidad = botonPremium.Text.ToLower();


            _cantidad = Convert.ToInt32(cantidadInput.Text);
            _precioUnitario = Convert.ToDouble(precioUnitarioInput.Text);

            _Presentador.Cotizar(_precioUnitario,_cantidad,_calidad,_prenda,_checkedChupin,_checkedCorta,_checkedMao);
        }

        #region Switch de Enabled
        private void botonCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (botonCamisa.Checked)
            {
                checkChupin.Enabled = false;
                checkCorta.Enabled = true;
                checkMao.Enabled = true;
                _prenda = "camisa";
            }
        }

        private void botonPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (botonPantalon.Checked)
            {
                checkChupin.Enabled = true;
                checkCorta.Enabled = false;
                checkMao.Enabled = false;
                _prenda = "pantalon";
            }
        }
        #endregion
    }
}
