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
using System.Xml.Linq;

namespace Fontanella.Simone._5i.XMLPersone
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

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                XElement dati = XElement.Load("Persone.xml");
                dati.Element("metei").Add(
                            new XElement("Meteo",
                            new XAttribute("Citta", "Prova"),
                            new XAttribute("Temperatura", "123")
                    );
                dgDati.ItemsSource = from l in dati.Elements("Persone").First().Elements("Persona")
                                     select new Persona(l);
            }
            catch (Exception errore)
            {
                MessageBox.Show(errore.Message);
            }
        }
    }
}
