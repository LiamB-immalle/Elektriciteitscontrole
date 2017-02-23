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

namespace lamp
{

    public partial class MainWindow : Window
    {
        SmartLamp ali;
        SmartLamp jos;
        SmartLamp kees;
        SmartLamp rita;
        SmartLamp john;
        SmartLamp fred;

        public MainWindow()
        {
            InitializeComponent();

            ali = new SmartLamp();
            jos = new SmartLamp();
            kees = new SmartLamp();
            rita = new SmartLamp();
            john = new SmartLamp();
            fred = new SmartLamp();
        }               

        void UpdateUI()
        {
            if (ali.Brandend)
            {
                ell_ali.Fill = Brushes.Yellow;
            }else
            {
                ell_ali.Fill = Brushes.Black;                
            }
            if (jos.Brandend)
            {
                ell_jos.Fill = Brushes.Yellow;
            }
            else
            {
                ell_jos.Fill = Brushes.Black;                
            }
            if (kees.Brandend)
            {
                ell_kees.Fill = Brushes.Yellow;
            }
            else
            {
                ell_kees.Fill = Brushes.Black;                
            }
            if (rita.Brandend)
            {
                ell_rita.Fill = Brushes.Yellow;
            }
            else
            {
                ell_rita.Fill = Brushes.Black;                
            }
            if (john.Brandend)
            {
                ell_john.Fill = Brushes.Yellow;
            }
            else
            {
                ell_john.Fill = Brushes.Black;                
            }
            if (fred.Brandend)
            {
                ell_fred.Fill = Brushes.Yellow;
            }
            else
            {
                ell_fred.Fill = Brushes.Black;                
            }
        }

        private void ali_Click(object sender, RoutedEventArgs e)
        {
            ali.Toggle();
            UpdateUI();
            text_ali.Text = Convert.ToString(ali.BrandTijd);
        }

        private void jos_Click(object sender, RoutedEventArgs e)
        {
            jos.Toggle();
            UpdateUI();
            text_jos.Text = Convert.ToString(jos.BrandTijd);
        }

        private void kees_Click(object sender, RoutedEventArgs e)
        {
            kees.Toggle();
            UpdateUI();
            text_kees.Text = Convert.ToString(kees.BrandTijd);
        }

        private void rita_Click(object sender, RoutedEventArgs e)
        {
            rita.Toggle();
            UpdateUI();
            text_rita.Text = Convert.ToString(rita.BrandTijd);
        }

        private void john_Click(object sender, RoutedEventArgs e)
        {
            john.Toggle();
            UpdateUI();
            text_john.Text = Convert.ToString(john.BrandTijd);
        }

        private void fred_Click(object sender, RoutedEventArgs e)
        {
            fred.Toggle();
            UpdateUI();
            text_fred.Text = Convert.ToString(fred.BrandTijd);
        }
    }
}