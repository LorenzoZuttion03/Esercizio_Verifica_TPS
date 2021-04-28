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
using System.Threading;

namespace Esercizio_Verifica_TPS
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnPartenza_Click(object sender, RoutedEventArgs e)
        {
            AvanzaBarra();
        }
        public async void AvanzaBarra()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        barra1.Value = i;
                    }));
                    Thread.Sleep(50);
                }
            });
        }

        private void btnMostraPercentuale_Click(object sender, RoutedEventArgs e)
        {
            CalcoloPercentuale();
        }
        public async void CalcoloPercentuale()
        {
            await Task.Run(() =>
            {
                double percentuale = 0;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    percentuale = barra1.Value;
                    lblOutput.Content ="La percentuale della Progress Barr è: " + percentuale + "%";
                }));
                Thread.Sleep(50);

            });
        }

        private void btnRiavviaBarra_Click(object sender, RoutedEventArgs e)
        {
            AvanzaBarra();
            
        }
        
    }
}
