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

namespace DesktopAssmenit
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        Sin_upEntities db = new Sin_upEntities();
        public Search()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null) 
            {
                mm.ItemsSource = db.User_1.ToList();
                int xx = int.Parse(City.Text);
                mm.ItemsSource = db.sinups.Where(x => x.city == xx).ToList();
            }
          
          
        }
    }
}
