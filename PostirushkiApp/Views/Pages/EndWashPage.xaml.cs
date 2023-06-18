using PostirushkiApp.Views.Windows;
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

namespace PostirushkiApp.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для EndWashPage.xaml
    /// </summary>
    public partial class EndWashPage : Page
    {
        public EndWashPage()
        {
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            StatusEditWin statusEditWin = new StatusEditWin();
            statusEditWin.ShowDialog();
            
        }
    }
}
