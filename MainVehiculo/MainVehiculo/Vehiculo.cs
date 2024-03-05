
namespace MainVehiculo
    {
        public class Vehiculo
        {
            protected string matricula;
            protected string marca;
            protected string modelo;

            public Vehiculo(string matricula, string marca, string modelo)
            {
                this.matricula = matricula;
                this.marca = marca;
                this.modelo = modelo;

            }

        public Vehiculo()
        {
        }

        public string getMatricula()
            {
                return matricula;
            }
            public string getMarca()
            {
                return marca;
            }
            public string getModelo()
            {
                return modelo;
            }

            //METODO QUE VA A CAMBIAR DE ACUERDO A LA CLASE, RETORNA MATRICULA, LA MARCA Y EL MODELO
            public virtual string mostrarDatos()
            {
                //HACERLO VISIBLE 
                return "Matricula: " + matricula + "\nMarca: " + marca + "\nModelo: " + modelo;

            }




        }

    }

