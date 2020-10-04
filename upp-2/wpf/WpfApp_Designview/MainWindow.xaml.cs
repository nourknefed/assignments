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
using WpfApp_Designview.Models;

namespace WpfApp_Designview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnContact_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactModel();
        }

        private void btnmessage_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new MessageModelcs();
        }

        private void Calender_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnCalender_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new Calender_Model();
        }

        private void btnTasks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
