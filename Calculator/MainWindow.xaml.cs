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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnSquare.Visibility = Visibility.Hidden;
            btnEx.Visibility = Visibility.Hidden;
        }

        private void No0_Click(object sender, RoutedEventArgs e)
        {
            //ez igy nem jo
            //if(Muvelet.Content!=string.Empty) lblNumber.Content += No0.Content.ToString();
            Muvelet.Content += No0.Content.ToString();
        }
        
        private void No1_Click(object sender, RoutedEventArgs e)
        {
            //ez mukodik
            Muvelet.Content += No1.Content.ToString();
        }

        private void No2_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += No2.Content.ToString();
        }

        private void No3_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += No3.Content.ToString();
        }

        private void No4_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += No4.Content.ToString();
        }

        private void No5_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += No5.Content.ToString();
        }

        private void No6_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += No6.Content.ToString();
        }

        private void No7_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += No7.Content.ToString();
        }

        private void No8_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += No8.Content.ToString();
        }

        private void No9_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += No9.Content.ToString();
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
           
                if (Muvelet.Content.ToString().Contains(btnPlus.Content.ToString()))
                {
                    var numbers = lblNumber.Content.ToString().Split('+');
                    var result = double.Parse(numbers[0]) + double.Parse(numbers[1]);
                    Vegeredmeny.Content = result.ToString();
                }
                else if (Muvelet.Content.ToString().Contains(btnMinus.Content.ToString()))
                {
                    var numbers = Muvelet.Content.ToString().Split('-');
                double result = double.Parse(numbers[0]) - double.Parse(numbers[1]);
                    Vegeredmeny.Content = result.ToString();
                }
                else if (Muvelet.Content.ToString().Contains(btnMulti.Content.ToString()))
                {
                    var numbers = Muvelet.Content.ToString().Split('*');
                double result = double.Parse(numbers[0]) * double.Parse(numbers[1]);
                    Vegeredmeny.Content = result.ToString();
                }
                else if (Muvelet.Content.ToString().Contains(btnDivide.Content.ToString()))
                {
                    var numbers = Muvelet.Content.ToString().Split('/');
                double result = double.Parse(numbers[0]) / double.Parse(numbers[1]);
                    Vegeredmeny.Content = result.ToString();
                }
                if (Muvelet.Content != string.Empty) lblNumber.Content += "=";
            
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += btnDivide.Content.ToString();
        }

        private void btnMulti_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += btnMulti.Content.ToString();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += btnMinus.Content.ToString();
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content += btnPlus.Content.ToString();
        }

        private void Hide_Checked(object sender, RoutedEventArgs e)
        {
            if (Hide.IsChecked == true)
            {
                btnSquare.Visibility = Visibility.Visible;
                btnEx.Visibility = Visibility.Visible;
            }
        }

        private void Hide_Unchecked(object sender, RoutedEventArgs e)
        {
            btnSquare.Visibility = Visibility.Hidden;
            btnEx.Visibility = Visibility.Hidden;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Muvelet.Content = string.Empty;
            Vegeredmeny.Content = string.Empty;
        }

        private void btnSquare_Click(object sender, RoutedEventArgs e)
        {
            if (lblNumber.Content != string.Empty)
            {
                int number = int.Parse(lblNumber.Content.ToString());
                Vegeredmeny.Content = Math.Sqrt(number).ToString();
            }
        }

        private void btnEx_Click(object sender, RoutedEventArgs e)
        {
            if (Muvelet.Content != string.Empty)
            {
                int number = int.Parse(lblNumber.Content.ToString());
                Vegeredmeny.Content = Math.Pow(number, 2).ToString();
            }
        }
    }
}

