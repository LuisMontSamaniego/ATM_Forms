using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    abstract class Cuenta
    {
        //atributos
        protected string nombre;
        protected string numCuenta;
        protected float saldo;
        //propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }

        public float Saldo
        {
            get { return saldo; }
        }
        //constructor
        public Cuenta()
        {
            nombre = "";
            numCuenta = "000000000";
            saldo = 10000;
        }
        //metodos
        abstract public bool Deposito(float cantidad);
        abstract public bool Retiro(float cantidad);
        public string Estado()
        {
            return "La cuenta: " + numCuenta + " \nPrtenece a: " + nombre + "  \nTiene : $" + saldo;
        }
    }
}
