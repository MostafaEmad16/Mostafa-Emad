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
using System.Xml.Linq;

namespace DesktopAssmenit
{
  
    /// <summary>
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        Sin_upEntities db = new Sin_upEntities();
        public Delete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MO.ItemsSource = db.User_1.ToList();
            db.User_1.Remove(db.User_1.First(x => x.phonenum == Phone.Text));
            db.SaveChanges();
            MessageBox.Show("Remove");
        }
    }
}
