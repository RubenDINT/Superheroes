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

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Superheroe> listaSuperheroes = Superheroe.GetSamples();
        int posicion = 0;

        public MainWindow()
        {
            InitializeComponent();

            PrincipalDockPanel.DataContext = listaSuperheroes[posicion];

        }

        private void FlechaIzquierda_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if (posicion > 0)
            {
                posicion--;
                PrincipalDockPanel.DataContext = listaSuperheroes[posicion];
                NumeroPagina.Text = posicion + 1 + " /3";
            }

        }

        private void FlechaDerecha_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (posicion < listaSuperheroes.Count - 1)
            {
                posicion++;
                PrincipalDockPanel.DataContext = listaSuperheroes[posicion];
                NumeroPagina.Text = posicion + 1 + " /3";
            }
        }
    }
}

