using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainVehiculo
{
    public class VehiculoTurismo : Vehiculo

    {
        //ATRIBUTO EXTRA DEL VEHICULO

        private int nPuertas;


        //Se crea el construtor

        public VehiculoTurismo(int nPuertas, string matricula, string marca, string modelo) : base(matricula, marca, modelo)
        {
            this.nPuertas = nPuertas;

        }

        //Metdodo getter para retornar el numero de puertas

        public int GetNPuertas()
        {
            return nPuertas;
        }


        //Sobreescrubir el metrodo de la clase padre
        //Se debe agregar el atributo propio de la clase


        public override string mostrarDatos()
        {
            return "Matricula: "+ getMatricula() + "\nMarca: "+getMarca()+"\nModelo: "+getModelo() +
                "\nNumero de puertas: "+ nPuertas;
        }


    }
}
