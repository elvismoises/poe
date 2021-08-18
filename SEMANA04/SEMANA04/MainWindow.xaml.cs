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

namespace SEMANA04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Referencia a las paginas
        Page1 page1 = new Page1();
        Page2 page2 = new Page2();
        public MainWindow()
        {
            InitializeComponent();
            //frPrincipal.Content = new Page1();
            frPrincipal.NavigationService.Navigate(page1);
        }

        #region EVENTOS DE LA VENTANA
        private void btnPagina1_Click(object sender, RoutedEventArgs e)
        {
            //Llamando a pagina 1
            //   NombreFrame.Content = new PaginaDestino();
            //frPrincipal.Content = new Page1();

            //Otra forma para no perder el contenido de las paginas
            //NombreFrame.NavigationService.Navigate(objeto);
            frPrincipal.NavigationService.Navigate(page1);
        }

        private void btnPagina2_Click(object sender, RoutedEventArgs e)
        {
            //Llamando a pagina 2
            //   NombreFrame.Content = new PaginaDestino();
            //frPrincipal.Content = new Page2();

            //Otra forma para no perder el contenido de las paginas
            //NombreFrame.NavigationService.Navigate(objeto);
            frPrincipal.NavigationService.Navigate(page2);
        }
        #endregion
    }
}
