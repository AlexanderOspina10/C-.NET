using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UsoCuent
{
    internal class CuentaCorrient
    {
        private double saldo;
        private String nombreTitular;
        private long numeroCuenta;

        //Crear construsctor - click derecho acciones rapidas
        public CuentaCorrient(double saldo, string nombreTitular )
        {
            this.saldo = saldo;
            this.nombreTitular = nombreTitular;
            Random rnd = new Random();
            numeroCuenta = Math.Abs( rnd.Next());
        }

        //Metodo setter para realizar ingresos
        public void setIngreso(double ingreso)
        {
            if( ingreso < 0 )
            {
                Console.WriteLine("No se permiten ingresos negativos");
            }
            else
            {
                saldo += ingreso;
            }
        }

        //Metodo setter para realizar retiros/SALIDAS

        public void setRetiro(double retiro)
        {
            saldo -= retiro;
        }

        //Metodo getter para obtener saldo y datos generales de la cuenta

        private String getSaldo()
        {
            return ("El saldo de la cuenta es:" + saldo);
        }

        //metodo adicional para realizar transferencias

        public static void transferencia (CuentaCorrient titul1,  CuentaCorrient titul2, double cantidad)
        {
            titul1.saldo += cantidad;
            titul2.saldo -= cantidad;
        }

        public String getDatosCuenta()
        {
            return "Titular :" + nombreTitular + "\n" + "No cuenta: " + numeroCuenta + "\n" + "Saldo: " + saldo; 
        }
    }
}
