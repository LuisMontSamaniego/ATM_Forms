using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class CuentaJR:Cuenta
    {
        //atributos ya estan heredados
        //ya heredamos tambien las propiedades
        //constructor opcional 
        public CuentaJR() : base()
        {
            //solo cambio el nombre
            nombre = "Cuenta JR";
        }

        //metodos reescritos
        public override bool Deposito(float cantidad)
        {
            if (cantidad >= 1 && cantidad <= 5000 && saldo+cantidad <= 35000)
            {
                saldo = saldo + cantidad;
                return true;
            }
            return false;
        }

        public override bool Retiro(float cantidad)
        {
            if (cantidad > 1 && cantidad < 5000 && cantidad <= saldo)
            {
                saldo = saldo - cantidad;
                return true;
            }
            return false;
        }


    }
}
