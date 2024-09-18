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

namespace InterficieBasica
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
        
        private void Botó1_Click(object sender, RoutedEventArgs e)
        {
            Etiqueta.Content = "Text canviat!";
            Botó2.Background = new SolidColorBrush(Colors.LightGreen);
            Botó2.Width = 200;
            

        }
        private void Botó2_Click(object sender, RoutedEventArgs e)
        {
            //Etiqueta.Content = "Hola, món!";
            Botó1.Background = new SolidColorBrush(Colors.Red);
            MessageBox.Show("Hola!");
            Background= new SolidColorBrush(Colors.Yellow);
            Etiqueta.Visibility = Visibility.Collapsed;

            
        }
        private void ActivarCampCheckbox_Checked(object sender, RoutedEventArgs e)
        {
            CampExtraTextBox.Visibility = Visibility.Visible;
        }
        private void ActivarCampCheckbox_Unchecked(object sender, RoutedEventArgs e)
        {
            CampExtraTextBox.Visibility = Visibility.Collapsed;
        }

        private void EnviarButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NomTextBox2.Text))
            {
                MessageBox.Show("El nom no pot estar buit.");
                return;
            }
            if(!int.TryParse(EdatTextBox.Text,out int edat))
            {
                MessageBox.Show("L'edat ha de ser un número.");
                return;
            }
            if (edat < 0 || edat > 120)
            {
                MessageBox.Show("Introdueix una edat vàlida.");
                return; 
            }
            MessageBox.Show("Formulari enviat correctament");
        }
    }
}