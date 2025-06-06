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
    public partial class frmCuentaFree : Form
    {
        //atributos
        private CuentaFree cuenta;
        public frmCuentaFree()
        {
            cuenta = new CuentaFree();
            InitializeComponent();
        }

        private void frmCuentaFree_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = cuenta.Nombre;
            this.txtNumCuenta.Text = cuenta.NumCuenta;
            txtSaldo.Text = "$ " + cuenta.Saldo;

        }


        private void txtCantidad_Enter(object sender, EventArgs e)
        {
            txtCantidad.Text = "";
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                txtCantidad.Text = "solo numeros";
            }
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                try
                {
                    cuenta.Deposito(float.Parse(txtCantidad.Text));
                    txtSaldo.Text = "$ " + cuenta.Saldo;
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
                    txtCantidad.Text = "Solo numeros";
                    txtSaldo.Text = "$ " + cuenta.Saldo;
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
