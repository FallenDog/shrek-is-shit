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
using WpfApp1.Models;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<GameViewModel> Games = new List<GameViewModel>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = Games;
          
            Games.Add(new GameViewModel()
            {
                Name = "Metro Exodus",
                Developer = "whoes",
                General = "shuter",

            });
            Games.Add(new GameViewModel()
            {
                Name = "Fallout New Vegas",
                Developer = "Obsidian",
                General = "Rpg",

            }); Games.Add(new GameViewModel()
            {
                Name = "Skyrim",
                Developer = "Bethesda",
                General = "Rpg",

            }); Games.Add(new GameViewModel()
            {
                Name = "Red Alert",
                Developer = "Ea",
                General = "Strattegi",

            });



        }
    }
}
