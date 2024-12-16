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

namespace Labo_9___MenuSliderBrushes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string defaultValue = "2";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            var result=MessageBox.Show("Wilt u afsluiten?","afsluiten",MessageBoxButton.YesNo,MessageBoxImage.Question);
            if(MessageBox.Show("Wilt u afsluiten?","afsluiten",MessageBoxButton.YesNo,MessageBoxImage.Question)==MessageBoxResult.Yes)
            {
            Close();
            }
        }

        private void menuGetal1_Click(object sender, RoutedEventArgs e)
        {
            numberOneTextBox.Text = defaultValue;
        }

        private void menuGetal2_Click(object sender, RoutedEventArgs e)
        {
            numberTwoTextBox.Text = defaultValue;
        }



        private void sliderGetal1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberOneTextBox.Text = Convert.ToString(sliderGetal1.Value);
        }
        private void sliderGetal2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberTwoTextBox.Text = Convert.ToString(Math.Round(sliderGetal2.Value,2));
        }

        private void numberOneTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double.TryParse(numberOneTextBox.Text,out double getal);
            sliderGetal1.Value = getal;
        }

        private void numberTwoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            double.TryParse(numberTwoTextBox.Text, out double getal);
            sliderGetal2.Value = getal;
        }
    }
}