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

namespace ggapp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string[] mArray = new string[16];
        static string[] dValues = new string[2] { "2", "4" };

        public void SetterOFValues()
        {
            TB1.Text = mArray[0];
            TB2.Text = mArray[1];
            TB3.Text = mArray[2];
            TB4.Text = mArray[3];

            TB5.Text = mArray[4];
            TB6.Text = mArray[5];
            TB7.Text = mArray[6];
            TB8.Text = mArray[7];

            TB9.Text = mArray[8];
            TB10.Text = mArray[9];
            TB11.Text = mArray[10];
            TB12.Text = mArray[11];

            TB13.Text = mArray[12];
            TB14.Text = mArray[13];
            TB15.Text = mArray[14];
            TB16.Text = mArray[15];
        }

        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            mArray[random.Next(0, 16)] = dValues[random.Next(0,2)];
            SetterOFValues();
        }

        private void UP_Click(object sender, RoutedEventArgs e)
        {
            string[] col1 = {}
        }

        private void DOWN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RIGHT_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LEFT_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
