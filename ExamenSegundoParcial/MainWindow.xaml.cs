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

namespace ExamenSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (controlInformacionPersonal.Visibility == Visibility.Visible)
            {
                
                if (controlInformacionPersonal.txtNombre.Text != "" && controlInformacionPersonal.txtEdad.Text != "" && controlInformacionPersonal.txtApellidoPaterno.Text != "" && controlInformacionPersonal.txtApellidoMaterno.Text != "")
                {
                    lblAnuncio.Text = "";
                    controlInformacionPersonal.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Visible;
                    controlInformacionPago.Visibility = Visibility.Collapsed;
                    lblPersonal.Foreground = Brushes.Black;
                    lblContacto.Foreground = Brushes.Crimson;
                    lblPago.Foreground = Brushes.Black;
                }
                else
                {
                    lblAnuncio.Text = "Es necesario llenar todos los campos";
                }
            }
            else if (controlContacto.Visibility == Visibility.Visible)
            {
                
                if (controlContacto.txtCelular.Text != "" && controlContacto.txtCorreo.Text != "" && controlContacto.txtTelefono.Text != "")
                {
                    controlInformacionPersonal.Visibility = Visibility.Collapsed;
                    controlContacto.Visibility = Visibility.Collapsed;
                    controlInformacionPago.Visibility = Visibility.Visible;
                    lblAnuncio.Text = "";
                    btnSiguiente.Content = "Finalizar";
                    lblPersonal.Foreground = Brushes.Black;
                    lblContacto.Foreground = Brushes.Black;
                    lblPago.Foreground = Brushes.Crimson;
                }
                else
                {
                    lblAnuncio.Text = "Es necesario llenar todos los campos";
                }
            }
            else
            {
                
                int cantidad = controlInformacionPago.txtNumeroTarjeta.Text.Length;
                if (cantidad != 16)
                {
                    controlInformacionPago.lblAnuncioTarjeta.Text = "Es necesario que el número de tarjeta sean 16 dígitos";
                }
                else
                {
                    controlInformacionPago.lblAnuncioTarjeta.Text = "";
                }
            }    

            
        }
    }
}
