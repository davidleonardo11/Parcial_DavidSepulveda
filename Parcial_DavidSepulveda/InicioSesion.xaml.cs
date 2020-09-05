using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Page
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        

        private void txtUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtUsuario.Text == "Empleado" && txtPassword.Password == "1234" )
            {
                MainWindow navegar = (MainWindow)Window.GetWindow(this);
                navegar.frameLogin.NavigationService.Navigate(new Home());
            }
            if (txtUsuario.Text == "admin" && txtPassword.Password == "4321")
            {
                MainWindow navegar = (MainWindow)Window.GetWindow(this);
                navegar.frameLogin.NavigationService.Navigate(new Home());
            }

        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(txtPassword.Password == "1234" && txtUsuario.Text == "Empleado")
            {
                MainWindow navegar = (MainWindow)Window.GetWindow(this);
                navegar.frameLogin.NavigationService.Navigate(new Home());
            }
            if (txtPassword.Password == "4321" && txtUsuario.Text == "admin")
            {

                MainWindow navegar = (MainWindow)Window.GetWindow(this);
                navegar.frameLogin.NavigationService.Navigate(new Admin());
            }
        }   
    }
}
