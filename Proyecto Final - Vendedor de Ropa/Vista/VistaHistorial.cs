using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter
{
    public partial class VerHistorial : Form
    {
        String historial = $"";
        public VerHistorial(string historial)
        {
            this.historial = historial;
            InitializeComponent();
            MostrarHistorial();
        }
        public void MostrarHistorial()
        {
            string[] historialArray = historial.Split('|');

            for (int i = 0; i < historialArray.Length; i++)
            {
                textBoxHistorial.AppendText(historialArray[i]);
                textBoxHistorial.AppendText(Environment.NewLine);
                textBoxHistorial.AppendText(Environment.NewLine);
            }
        }

    }
}
