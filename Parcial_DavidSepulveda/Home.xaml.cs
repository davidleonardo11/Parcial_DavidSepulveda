using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Quiz_DavidSepulveda
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            

        }


        private void btnSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            lblPasta.Visibility = Visibility.Visible;
            lstPan.Items.Add(txtAliniado.Text);
            lstPan.Items.Add(txtNoali.Text);
            lstPan.Items.Add(txtEspeci.Text);
            lblPasta.Content = "$" + (lstPan.Items.Count * 1000);
        }

        private void btnQuitar_Click(object sender, RoutedEventArgs e)
        {
            lstPan.Items.Remove(lstPan.SelectedItem);
            lblPasta.Content = "$" + (lstPan.Items.Count *1000-(1000));
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            lblHora.Visibility = Visibility.Visible;
            lblHora.Content = "Hora de la compra: " + DateTime.Now.ToString("hh:mm:ss");
            MessageBox.Show("Gracias por tu compra, te esperamos de nuevo!. OnlyPans");
           

           
        }

        private void Regresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow navegar = (MainWindow)Window.GetWindow(this);
            navegar.frameLogin.NavigationService.Navigate(new InicioSesion());
        }
    }
}
