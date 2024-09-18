using LiveCharts;
using LiveCharts.Wpf;
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
    /// Interaction logic for MainEx8.xaml
    /// </summary>
    public partial class MainEx8 : Window
    {
        public MainEx8()
        {
            InitializeComponent();

            Gràfic.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<double> {3, 5, 7, 4}
                }
            };
        }
    }
}
