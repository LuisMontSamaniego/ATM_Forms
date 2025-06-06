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
    public partial class frmCuentaEmpresa : Form
    {
        //Creamos atributo
        private CuentaEmpresa cuenta;
        public frmCuentaEmpresa()
        {
            cuenta = new CuentaEmpresa();
            InitializeComponent();
        }


        private void frmCuentaEmpresa_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = cuenta.Nombre;
            txtNumCuenta.Text = cuenta.NumCuenta;
            txtRFC.Text = cuenta.RFC;
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
            if (txtCantidad.Text != "")
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
            if(txtCantidad.Text != "")
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
            MessageBox.Show(cuenta.Estado() + "\nRFC: " + cuenta.RFC);
        }
    }
}
