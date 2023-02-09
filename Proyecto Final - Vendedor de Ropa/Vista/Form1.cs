using Presenter;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form, IView
    {
        private readonly Presentador _Presentador;

        private double _precioUnitario;
        private int _cantidad;
        private string _prenda = "camisa";
        private string _calidad = "standard";
        private bool _checkedMao = false;
        private bool _checkedCorta = false;
        private bool _checkedChupin = false;

        public Form1()
        {
            InitializeComponent();
            _Presentador = new Presentador(this);
            ActualizarDatosUsuario();
            Text = "Realize su operación...";
        }
        #region MétodosInterfaz
        public void ManejarErrores(string msj)
        {
            if (msj != null)
            {
                if (msj == "-1")
                    MessageBox.Show("Sólo se aceptan número mayores a 0.");
                else if (msj == "-2")
                    MessageBox.Show("No se puede Cotizar unidades por encima del Stock de la prenda.");
                else if(msj == "stock")
                    MessageBox.Show("No se encontró registro de stock.");
                else if(msj == "ingreso")
                    MessageBox.Show("Error: algún/os campo/s no se han ingresado correctamente.");

            }
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
        public void ActualizarStock(int stock)
        {
            stockDisponible.Text = Convert.ToString(stock);
        }
        public void MostrarResultado(string resultado)
        {
            resultadoCotizacion.Text = resultado;
            if (Convert.ToDouble(resultado) > 0)
                Text = "¡Cotización realizada con éxito!";
            else
                Text = "Cotización fallida. Por favor, realice la operación nuevamente.";
        }
        #endregion

        #region MétodosFormulario
        private void Historial_Click(object sender, EventArgs e)
        {
            VerHistorial historial = new VerHistorial(_Presentador.MostrarHistorial());
            historial.Show();
        }
        private void Cotizar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos() && ComprobarBotones())
                _Presentador.Cotizar(_precioUnitario, _cantidad, _calidad, _prenda, _checkedChupin, _checkedCorta, _checkedMao);
            else
                ManejarErrores("ingreso");
        }

        private void botonCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (botonCamisa.Checked)
            {
                checkChupin.Enabled = false;
                checkCorta.Enabled = true;
                checkMao.Enabled = true;
                _prenda = "camisa";
            }
            ComprobarBotones();
            _Presentador.Actualizar(_prenda, _calidad, _checkedCorta, _checkedMao, _checkedChupin);
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
            ComprobarBotones();
            _Presentador.Actualizar(_prenda,_calidad,_checkedCorta,_checkedMao,_checkedChupin);
        }

        private void botonStandard_CheckedChanged(object sender, EventArgs e)
        {
            ComprobarBotones();
            _Presentador.Actualizar(_prenda, _calidad, _checkedCorta, _checkedMao, _checkedChupin);
        }

        private void botonPremium_CheckedChanged(object sender, EventArgs e)
        {
            ComprobarBotones();
            _Presentador.Actualizar(_prenda, _calidad, _checkedCorta, _checkedMao, _checkedChupin);
        }
        private void checkCorta_CheckedChanged(object sender, EventArgs e)
        {
            ComprobarBotones();
            _Presentador.Actualizar(_prenda, _calidad, _checkedCorta, _checkedMao, _checkedChupin);
        }

        private void checkMao_CheckedChanged(object sender, EventArgs e)
        {
            ComprobarBotones();
            _Presentador.Actualizar(_prenda, _calidad, _checkedCorta, _checkedMao, _checkedChupin);
        }

        private void checkChupin_CheckedChanged(object sender, EventArgs e)
        {
            ComprobarBotones();
            _Presentador.Actualizar(_prenda, _calidad, _checkedCorta, _checkedMao, _checkedChupin);
        }
        #endregion

        #region MétodosValidaciones
        private bool ComprobarBotones()
        {
            bool comprobacion = true;

            // Comprobacion de botones
            // Los tipo check se guardan como booleanos. Los tipo radio se guardan como string
            _checkedMao = checkMao.Checked;
            _checkedCorta = checkCorta.Checked;
            _checkedChupin = checkChupin.Checked;

            if (botonStandard.Checked | botonPremium.Checked)
            {
                if (botonStandard.Checked)
                {
                    _calidad = botonStandard.Text.ToLower();
                    botonStandard.BackColor = Color.Transparent;
                }
                else if (botonPremium.Checked)
                {
                    _calidad = botonPremium.Text.ToLower();
                    botonPremium.BackColor = Color.Transparent;
                }
            }
            else
            {
                botonPremium.BackColor = Color.Red;
                botonStandard.BackColor = Color.Red;
                comprobacion = false;
            }

            if (botonCamisa.Checked | botonPantalon.Checked)
            {
                if (botonCamisa.Checked)
                {
                    _prenda = "camisa";
                    botonPantalon.BackColor = Color.Transparent;
                    botonCamisa.BackColor = Color.Transparent;
                }
                else if (botonPantalon.Checked)
                {
                    _prenda = "pantalon";
                    botonPantalon.BackColor = Color.Transparent;
                    botonCamisa.BackColor = Color.Transparent;
                }
            }
            else
            {
                botonCamisa.BackColor = Color.Red;
                botonPantalon.BackColor = Color.Red;
                comprobacion = false;
            }

            return comprobacion;
        }
        private bool ComprobarCampos()
        {
            bool comprobacion = true;

            // Comprobación tipos numéricos
            if(Utiles.Validar(precioUnitarioInput.Text, "double"))
            {
                _precioUnitario = Convert.ToDouble(precioUnitarioInput.Text);
                precioUnitarioInput.BackColor = Color.White;
            }
            else
            {
                precioUnitarioInput.BackColor = Color.Red;
                comprobacion = false;
            }

            if (Utiles.Validar(cantidadInput.Text, "int"))
            {
                cantidadInput.BackColor = Color.White;
                _cantidad = Convert.ToInt32(cantidadInput.Text);
            }
            else
            {
                cantidadInput.BackColor = Color.Red;
                comprobacion = false;
            }
            return comprobacion;
        }

        #endregion
    }
}
