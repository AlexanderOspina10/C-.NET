namespace WebAplicationDashboard.Models
{
    public class SerieTorta
    {
        public string name { get; set; }
        
        public double y { get; set; }

        public bool sliced { get; set; }

        public bool selected { get; set; } 

        // Crear constructor vacio

        public SerieTorta() { }

        //Crer otro constructor para recibir esas variables para inicializar el objeto
        
        public SerieTorta(string name, double y, bool sliced = false, bool selected = false)
        {
            this.name = name;
            this.y = y; 
            this.sliced = sliced;
            this.selected = selected;
                
        }

        public List<SerieTorta> GetDataDumy()
        {
            List<SerieTorta>lista = new List<SerieTorta>();
            lista.Add(new SerieTorta("Angular", 45));
            lista.Add(new SerieTorta("View", 45));
            lista.Add(new SerieTorta("ReactJs", 45));
            lista.Add(new SerieTorta("CSS3", 45));
            lista.Add(new SerieTorta("HTML", 45));

            return lista; //Sino se retorna nada de error

        }
    }
}
