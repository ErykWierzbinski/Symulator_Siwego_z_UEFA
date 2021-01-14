using Newtonsoft.Json;
using Symulator_Siwego_z_UEFA.Models;
using Symulator_Siwego_z_UEFA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace Symulator_Siwego_z_UEFA.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class QuickMatchOptionsView : Window
    {
        
        public string GetValueInOptions
        {
            get
            {
                return txt.Text;
            }
        }

        public string GetMinRangeDraw
        {
            get
            {
                return MinRangeDraw.Text;
            }
        }

        public string GetMaxRangeDraw
        {
            get
            {
                return MaxRangeDraw.Text;
            }
        }

        public QuickMatchOptionsView()
        {
            
            InitializeComponent();

            //DataContext = new QuickMatchViewModel();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void RangeDraw_Click(object sender, RoutedEventArgs e)
        {
            if(RangeDraw.IsChecked.Value && StarsForRangeDraw.Visibility==Visibility.Hidden)
            {
                StarsForRangeDraw.Visibility = Visibility.Visible;
            }
        }
    }
}
