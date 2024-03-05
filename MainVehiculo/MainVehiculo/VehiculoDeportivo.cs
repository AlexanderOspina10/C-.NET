using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainVehiculo
{
    public class VehiculoDeportivo : Vehiculo
    {
        private int cilindrada;

        public VehiculoDeportivo(string matricula, string marca, string modelo, int cilindrada) : base(matricula, marca, modelo)
        {
            this.cilindrada = cilindrada;
        }

        public int GetCilindrada()
        {
            return cilindrada;
        }

        public override string mostrarDatos()
        {
            return "Matricula: " + getMatricula() + "\nMarca: " + getMarca() + "\nModelo: " + getModelo() +
                "\nCilindrada: " + cilindrada;
        }
    }
}
