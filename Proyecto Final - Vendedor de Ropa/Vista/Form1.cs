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
        private string _prenda;
        private string _calidad;
        private bool _checkedMao;
        private bool _checkedCorta;
        private bool _checkedChupin;

        public Form1()
        {
            InitializeComponent();
        }
        public void MostrarResultado()
        {

            
        }
        public void LeerInput()
        {

        }
        private void Historial_Click(object sender, EventArgs e)
        {

        }
        private void Cotizar_Click(object sender, EventArgs e)
        {
            // Asignar campos para pasarlos al presentador. Antes Validar.

            if (botonCamisa.Checked)
            {
                _prenda = "camisa";
                _checkedMao = checkMao.Checked;
                _checkedCorta = checkCorta.Checked;
            }
            else if (botonPantalon.Checked)
            {
                _prenda = "pantalon";
                _checkedChupin = checkChupin.Checked;
            }
            if (botonStandard.Checked)
                _calidad = botonStandard.Text.ToLower();
            else if (botonPremium.Checked)
                _calidad = botonPremium.Text.ToLower();


            _cantidad = Convert.ToInt32(cantidadInput.Text);
            _precioUnitario = Convert.ToDouble(precioUnitarioInput.Text);

            _Presentador.Cotizar(_precioUnitario,_cantidad,_calidad,_prenda,_checkedChupin,_checkedCorta,_checkedMao);

            MostrarResultado();
        }
    }
}
