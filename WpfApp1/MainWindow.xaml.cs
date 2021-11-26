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

namespace VegaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WpfApp1.Windows.Extras ex = new WpfApp1.Windows.Extras();
            ex.Show();
        }

        public Boolean comprobarCampos()
        {
            Boolean bandera3 = true;
            if (TextUsuario.Text.Equals(""))
            {
                MessageBox.Show("El campo Usuario no puede estar vacio");
                bandera3 = false;
            }

            if (TextContra.Password.Equals(""))
            {
                MessageBox.Show("El campo Contraseña no puede estar vacio");
                bandera3 = false;
            }

            return bandera3;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (comprobarCampos())
            {
                Window2 w2 = new Window2();
                w2.Show();
            }
        }

        private void Registrar(object sender, MouseButtonEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }
    }
}
