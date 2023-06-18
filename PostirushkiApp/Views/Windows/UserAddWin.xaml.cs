using PostirushkiApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PostirushkiApp.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для UserAddWin.xaml
    /// </summary>
    public partial class UserAddWin : Window
    {
        private HttpClient client = new HttpClient();
        public UserAddWin()
        {
            InitializeComponent();
            client.BaseAddress = new Uri("https://localhost:44326");
            DataContext = new User();
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if 
                {

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
