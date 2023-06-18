using PostirushkiApp.Views.Pages;
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

namespace PostirushkiApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new ActiveWashPage());

        }

        private void btnActiveWash_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ActiveWashPage());
            tlbPage.Text = "Активные стирки";
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ReportPage());
            tlbPage.Text = "Кассовый отчет";
        }

        private void btnEndWash_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new EndWashPage());
            tlbPage.Text = "Завершенные стирки";
        }

        private void btnAddWash_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
