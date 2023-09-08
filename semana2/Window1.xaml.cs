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
using System.Windows.Shapes;

namespace semana2
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Salidas_Click(object sender, RoutedEventArgs e)
        {
            salidas salida = new salidas();
            salida.Show();
        }

        private void Camiones_Click(object sender, RoutedEventArgs e)
        {
            camiones camion = new camiones();
            camion.Show();
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            conductores conductor = new conductores();
            conductor.Show();
        }
    }
}
