using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneracionDeNumerosAleatorios
{
    public partial class frmNumAleatorio : Form
    {

        int x0, g, m, a, c, k;
        IEstrategiaNumAleatorio estrategia;
        public frmNumAleatorio()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
        }

        private void txtX0_Leave(object sender, EventArgs e)
        {
            txtG.Focus();
        }

        private void txtG_Leave(object sender, EventArgs e)
        {
        }

        private void btnLineal_CheckedChanged(object sender, EventArgs e)
        {
            IEstrategiaNumAleatorio estrategia = new EstrategiaLineal();
        }

        private void btnMultiplicativo_CheckedChanged(object sender, EventArgs e)
        {
            IEstrategiaNumAleatorio estrategia = new EstrategiaMultiplicativo();
        }

        public void validarCampos()
        {
            if (!(int.TryParse(txtX0.Text, out x0) && x0 > 0))
            {
                MessageBox.Show("Datos ingresados no válidos. La variable X0 debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtX0.Focus();
            }
            if (!(int.TryParse(txtG.Text, out g) && g > 0))
            {
                MessageBox.Show("Datos ingresados no válidos. La variable g debe ser un número entero positivo.", "Variables ingresadas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
