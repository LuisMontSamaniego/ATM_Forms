using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class CuentaFree:Cuenta
    {
        //atributos ya estan heredados
        //ya heredamos tambien las propiedades
        //constructor opcional 
        public CuentaFree() : base()
        {
            //solo cambio el nombre
            nombre = "Cuenta free";
        }

        //metodos reescritos
        public override bool Deposito(float cantidad)
        {
            if (cantidad >= 1 && cantidad <= 11000)
            {
                saldo = saldo + cantidad;
                return true;
                
            }
            
            return false;
        }

        public override bool Retiro(float cantidad)
        {
            if (cantidad > 1 && cantidad < 11000 && cantidad <= saldo)
            {
                saldo = saldo - cantidad;
                return true;
                
            }

            return false;
        }
        

    }
}
