using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CineEvo.WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ComboCines.ItemsSource = ObtenerCiudades();
            ComboCines.SelectedIndex = 0;
        }

        public IList<string> ObtenerCiudades()
        {
            //TODO: Obtener valores de la base de datos
            //return Cines.Listar().Select( c => c.Nombre).ToList();

            //Test data
            List<String> cines = new List<string>();
            cines.Add("Cinépolis Plaza Norte");
            cines.Add("Cinépolis Santa Anita");
            return cines;
        }

        private void Comprar_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

    }
}
