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
    /// Interaction logic for profilepage.xaml
    /// </summary>
    public partial class profilepage : Page
    {
        Sin_upEntities db =new Sin_upEntities();
        public profilepage(string name)
        {
            InitializeComponent();
           
            datagrid.ItemsSource=db.MMMs.ToList();
            datagrid.ItemsSource=db.MMMs.Where(x=>x.admin_username == name).ToList();
           
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            login dd=new login();
            this.NavigationService.Navigate(dd);    
        }

        private void Button_Click_1(object sender, object e)
        {

        }
    }
}
