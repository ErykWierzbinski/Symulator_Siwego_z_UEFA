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
    public partial class QuickMatchView : UserControl
    {
        private Random rand { get; set; }
        private IList<Team> teams { get; set; }
        public QuickMatchView()
        {
            rand = new Random();
            //teams = new List<Team>();
            using (var webclient = new WebClient())
            {
                //var rand = new Random();
                var json = webclient.DownloadString(@"teams1.txt");
                teams = JsonConvert.DeserializeObject<IList<Team>>(json);
                //HomeTeam.Text = teams[rand.Next(teams.Count())].Name;
            }
            InitializeComponent();

            //DataContext = new QuickMatchViewModel();
        }

        private void DrawTeams_Click(object sender, RoutedEventArgs e)
        {
            var team1 = teams[rand.Next(teams.Count())];
            var team2 = teams[rand.Next(teams.Count())];
            HomeTeam.Text = team1.Name;
            HomeTeamLeague.Text = team1.League;

            AwayTeam.Text = team2.Name;
            AwayTeamLeague.Text = team2.League;
        }

        private void opcjebtn_Click(object sender, RoutedEventArgs e)
        {

            QuickMatchOptionsView qmov = new QuickMatchOptionsView();
            
            //qmov.Show();
            if(qmov.ShowDialog() == false)
            {
                StringBuilder stringBuilder = new StringBuilder();
                if(qmov.SimpleDraw.IsChecked == true)
                {
                    stringBuilder.Append("SimpleDraw");
                }
                else if (qmov.SameRatingDraw.IsChecked == true)
                {
                    stringBuilder.Append("SameRatingDraw");
                }
                else if (qmov.RangeDraw.IsChecked == true)
                {
                    stringBuilder.Append("RangeDraw");
                    //string pom = qmov.GetMinRangeDraw + "-" + qmov.GetMaxRangeDraw;
                    stringBuilder.Append(qmov.GetMinRangeDraw);
                    stringBuilder.Append("-");
                    stringBuilder.Append(qmov.GetMaxRangeDraw);
                }
                label.Content = stringBuilder.ToString();
            }
            

            
        }
    }
}
