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

namespace Prezydenty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int licznikDlaTrump, licznkDlaBiden, licznikDlaJorgensen, licznikDlaObama;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonClickTrump(object sender, RoutedEventArgs e)
        {
            licznikDlaTrump++;
            vote1.Text = licznikDlaTrump.ToString() + " votes";

            winner();

        }

        private void OnButtonClickBiden(object sender, RoutedEventArgs e)
        {
            licznkDlaBiden++;
            vote2.Text = licznkDlaBiden.ToString() + " votes";

            winner();
          
        }

        private void OnButtonClickJorgensen(object sender, RoutedEventArgs e)
        {
            licznikDlaJorgensen++;
            vote3.Text = licznikDlaJorgensen.ToString() + " votes";

            winner();
            
        }

        private void OnButtonClickObama(object sender, RoutedEventArgs e)
        {
            licznikDlaObama++;
            vote4.Text = licznikDlaObama.ToString() + " votes";

            winner();

        }

       public void winner()
        {
            if (licznikDlaTrump >= 10)
            {
                MessageBox.Show("THE NEW PRESIDENT IS DONALD TRUMP");
                WIN_trump.Visibility = Visibility;
            }
            else if(licznkDlaBiden >= 10)
            {
                MessageBox.Show("THE NEW PRESIDENT IS JOSEF BIDEN");
                WIN_biden.Visibility = Visibility;
            }
            else if(licznikDlaJorgensen >= 10)
            {
                MessageBox.Show("THE NEW PRESIDENT IS JOE JORGENSEN");
                WIN_jorgensen.Visibility = Visibility;
            }
            else if(licznikDlaObama >= 10)
            {
                MessageBox.Show("THE NEW PRESIDENT IS BARAK OBAMA");
                WIN_obama.Visibility = Visibility;
            }


         
        }
       
 
    }
}
