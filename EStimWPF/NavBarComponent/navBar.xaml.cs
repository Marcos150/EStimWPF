using System.Windows.Controls;
using EStimWPF.NavBarComponent.models;

namespace EStimWPF.NavBarComponent
{
    public partial class navBar : UserControl
    {
        public navBar()
        {
            this.DataContext = new navBarViewModel("Tu tienda", "Nuevo y destacable", "Categorías", "Tienda de puntos", "Noticias", "Laboratorios");
            InitializeComponent();
        }
    }
}
