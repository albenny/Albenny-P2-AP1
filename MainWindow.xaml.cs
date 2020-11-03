using System.Windows;
using Albenny_P2_AP1.UI.Registros;
using Albenny_P2_AP1.UI.Consultas;

namespace Albenny_P2_AP1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rProyectosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rProyectos rProyectos = new rProyectos();
            rProyectos.Show();
        }

        private void cTiposTareasMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cTiposTareas cTiposTareas = new cTiposTareas();
            cTiposTareas.Show();
        }
    }
}