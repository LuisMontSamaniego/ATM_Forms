using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmCuentaJR : Form
    {
        private CuentaJR cuenta;
        public frmCuentaJR()
        {
            cuenta = new CuentaJR();
            InitializeComponent();
        }

        private void frmCuentaJR_Load(object sender, EventArgs e)
        {
            txtNombre.Text = cuenta.Nombre;
            txtNumCuenta.Text = cuenta.NumCuenta;
            txtSaldo.Text = "$" + cuenta.Saldo;
        }

        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if(txtCantidad.Text == "")
            {
                txtCantidad.Text = "Solo numeros";
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            if(txtCantidad.Text != "")
            {
                try
                {
                    cuenta.Deposito(float.Parse(txtCantidad.Text));
                    txtSaldo.Text = "$" + cuenta.Saldo;
                    txtCantidad.Text = "Solo numeros";
                }
                catch
                {
                    MessageBox.Show("Datos capturados no validos");
                    txtCantidad.Text = "Solo numeros";
                }
            }
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                try
                {
                    cuenta.Retiro(float.Parse(txtCantidad.Text));
                    txtSaldo.Text = "$" + cuenta.Saldo;
                    txtCantidad.Text = "Solo numeros";
                }
                catch
                {
                    MessageBox.Show("Datos capturados no validos");
                    txtCantidad.Text = "Solo numeros";
                }
            }
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cuenta.Estado());
        }
    }
}
