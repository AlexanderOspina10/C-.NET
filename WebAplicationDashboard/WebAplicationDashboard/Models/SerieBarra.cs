namespace WebAplicationDashboard.Models
{
    public class SerieBarra
    {
        public SerieBarra() { }

        //Crear constructor vacio, la data de esta grafica no tiene nombre, name 

        public object[]GetDataDumy()
        {
            //Arreglo de objetos
            object[]data = new object[5];//Tamaño del arreglo

            data[0] = new object[] { "Angular", 45 };
            data[1] = new object[] { "ViewJS", 50 };
            data[2] = new object[] { "React", 76 };
            data[3] = new object[] { "CSS", 40 };
            data[4] = new object[] { "HTML", 35 };
            return data;
        }
    }
}
