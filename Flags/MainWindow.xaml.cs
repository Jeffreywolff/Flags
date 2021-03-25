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

namespace Flags
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

        private void Apaknapp_Click(object sender, RoutedEventArgs e)
        {
            if(Apatext.Text == "Apa")
            {
                Apatext.Text = "Oni-Chan";
                Apaknapp.Content = "Apa";
            }
            else if (Apatext.Text == "Oni-Chan")
            {
                var newButton = new Button();
                newButton.Content = "Ny Knapp";
                newButton.Width = 75;
                newButton.Height = 30;
                MainGrid.Children.Add(newButton);

            }
            else
            {
                Apatext.Text = "Apa";
                Apaknapp.Content = "Oni-Chan";
            }
        }
    }
}
