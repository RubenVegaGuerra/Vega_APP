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
using System.Windows.Shapes;
using VegaWPF.LogicaNegocio;

namespace VegaWPF
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        Usuario User;
        public Window1()
        {
            InitializeComponent();
            User = new Usuario();
            this.DataContext = User;
        }


        //BOTON DE REGISTRAR
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Logica.comprobarRegistro(TextContra, TextContra2, this);
        }

        private void btLimpiar_Click(object sender, RoutedEventArgs e)
        {
            TextUsuario.Text = "";
            TextCorreo.Text = "";
            TextContra.Password = "";
            TextContra2.Password = "";
        }
    }
}
