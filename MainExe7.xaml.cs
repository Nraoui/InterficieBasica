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
using System.Windows.Shapes;

namespace InterficieBasica
{
    /// <summary>
    /// Interaction logic for MainExe7.xaml
    /// </summary>
    public partial class MainExe7 : Window
    {
        public MainExe7()
        {
            InitializeComponent();
        }
        private void ReproduirButton_Click(object sender, RoutedEventArgs e)
        {
            VideoElement.Play();
        }
    }
}
