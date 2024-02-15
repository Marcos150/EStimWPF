
using System.Windows.Media.Imaging;

namespace EStimWPF.models 
{
    public class Juego
    {
        private string _id;
        private string _nombre;
        private string _descripcion;
        private double precio;
        private DateTime _fechaLanzamiento;
        private string _desarrollador;
        private string _editor;
        private List<string> _generos;
        private string _portadaB64;

        public Juego() { }
        /*public Juego(string _id, string _nombre, string _descripcion, double precio, DateTime _fechaLanzamiento, string _desarrollador, string _editor, List<string> _generos, string _portadaB64)
        {
            this._id = _id;
            this._nombre = _nombre;
            this._descripcion = _descripcion;
            this.precio = precio;
            this._fechaLanzamiento = _fechaLanzamiento;
            this._desarrollador = _desarrollador;
            this._editor = _editor;
            this._generos = _generos;
            this._portadaB64 = _portadaB64;
        }
        public Juego(string _nombre)
        {
            this._nombre = _nombre;
        }*/

        public string id { get => _id; set => _id = value; }
        public string nombre { get => _nombre; set => _nombre = value; }
        public string descripcion { get => _descripcion; set => _descripcion = value; }
        public DateTime fechaLanzamiento { get => _fechaLanzamiento; set => _fechaLanzamiento = value; }
        public string desarrollador { get => _desarrollador; set => _desarrollador = value; }
        public string editor { get => _editor; set => _editor = value; }
        public List<string> generos { get => _generos; set => _generos = value; }
        public string portadaB64 { get => _portadaB64; set => _portadaB64 = value; }
        public BitmapImage portadaSource { get; set; }
    }
}
