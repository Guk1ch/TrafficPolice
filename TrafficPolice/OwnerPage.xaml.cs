using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
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

namespace TrafficPolice
{
    /// <summary>
    /// Interaction logic for OwnerPage.xaml
    /// </summary>
    public partial class OwnerPage : Page
    {
        public static ObservableCollection<Owner> owners { get; set; }
        public OwnerPage()
        {
            InitializeComponent();
            owners = new ObservableCollection<Owner>(BD_Connection.connection.Owner.ToList());

            var o = new Owner();
            this.DataContext = this;
        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var n = (sender as ListView).SelectedItem as Owner;
            NavigationService.Navigate(new OwnermanPage(n));
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOwnerPage());
        }
    }
}

