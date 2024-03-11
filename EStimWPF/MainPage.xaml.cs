using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using EStimWPF.models;

namespace EStimWPF
{
    public partial class MainPage: Window
    {
        public static Frame CatalogoNavigation;
        public static List<Frame> Frames;
        public MainPage()
        {
            InitializeComponent();  

            CatalogoNavigation = Catalogo;

            Frames = GetAllFrames();

            var destacadosControl1 = new Destacados();
            var destacadosControl2 = new Destacados();
            var destacadosControl3 = new Destacados();
            var destacadosControl4 = new Destacados();
            
            CargarJuegosDestacados(frame1, destacadosControl1);
            CargarJuegosDestacados(frame2, destacadosControl2);
            CargarJuegosDestacados(frame3, destacadosControl3);
            CargarJuegosDestacados(frame4, destacadosControl4);
        }
        
        private void CargarJuegosDestacados(Frame frame, Destacados destacadosControl)
        {
            destacadosControl.DataContext = new ObservableCollection<Juego>();
            destacadosControl.DestacadosObtenidos += (juegosDestacados) => OnDestacadosLoaded(juegosDestacados, destacadosControl, frame);
        }

        private void OnDestacadosLoaded(List<Juego> juegosDestacados, Destacados destacadosControl, Frame frame)
        {
            var JuegosDestacadosLocal = destacadosControl.DataContext as ObservableCollection<Juego>;
            JuegosDestacadosLocal.Clear();
            foreach (var juego in juegosDestacados)
            {
                JuegosDestacadosLocal.Add(juego);
            }
            
            frame.Content = destacadosControl;
        }

        private List<Frame> GetAllFrames()
        {   
            List<Frame> frames = new List<Frame>();
            int quantity = VisualTreeHelper.GetChildrenCount(destacados);

            for(int i = 0; i < quantity; i++)
            {
                frames.Add(VisualTreeHelper.GetChild(destacados, i) as Frame);
            }

            return frames;
        }
    }
}