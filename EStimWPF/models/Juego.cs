namespace EStimWPF.models
{
    public class Juego
    {
        
        private string id;
        private string nombre;
        private string descripcion;
        private double precio;
        private DateTime fechaLanzamiento;
        private string desarrollador;
        private string editor;
        private List<string> generos;
        private string portadaB64;
        private string img1, img2, img3, img4;
        
        public Juego()
        {
        } 
        
        public Juego(string id, string nombre, string descripcion, double precio, DateTime fechaLanzamiento, 
            string desarrollador, string editor, List<string> generos, string portadaB64, string img1, string img2, string img3, string img4)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.fechaLanzamiento = fechaLanzamiento;
            this.desarrollador = desarrollador;
            this.editor = editor;
            this.generos = generos;
            this.portadaB64 = portadaB64;
            this.img1 = img1;
            this.img2 = img2;
            this.img3 = img3;
            this.img4 = img4;
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime FechaLanzamiento { get => fechaLanzamiento; set => fechaLanzamiento = value; }
        public string Desarrollador { get => desarrollador; set => desarrollador = value; }
        public string Editor { get => editor; set => editor = value; }
        public List<string> Generos { get => generos; set => generos = value; }
        public string PortadaB64 { get => portadaB64; set => portadaB64 = value; }
        public string Img1 { get => img1; set => img1 = value; }
        public string Img2 { get => img2; set => img2 = value; }
        public string Img3 { get => img3; set => img3 = value; }
        public string Img4 { get => img4; set => img4 = value; }
    }
}