using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainVehiculo
{
    public class VehiculoFurgoneta : Vehiculo
    {
        private int carga;

        public VehiculoFurgoneta(string matricula, string marca, string modelo, int carga) : base(matricula, marca, modelo)
        {
            this.carga = carga;
        }

        public int GetCarga()
        {
            return carga;
        }

        public override string mostrarDatos()
        {
            return "Matricula: " + getMatricula() + "\nMarca: " + getMarca() + "\nModelo: " + getModelo() +
                "\nCarga: " + carga;
        }
    }
}
