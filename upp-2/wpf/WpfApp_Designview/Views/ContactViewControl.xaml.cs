using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Designview.Views
{
    /// <summary>
    /// Interaction logic for ContactViewControl.xaml
    /// </summary>
    public partial class ContactViewControl : UserControl
    {
        public ContactViewControl()
        {
            InitializeComponent();
        }

        private void c1_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "Ayham Sanjakder";
            Mobile.Text = "070094237";
            email.Text = "Email: Ayhamgs80 @gmail.com";
        }

        private void c2_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "Karl Andersson";
            Mobile.Text = "072294237";
            email.Text = "Email: Karl@gmail.com";
        }

        private void c3_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "Nour Knefed";
            Mobile.Text = "072794235";
            email.Text = "Email:noura@gmail.com";
        }

        private void c4_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "Tidle Martinsson";
            Mobile.Text = "072794456";
            email.Text = "Email:tiddy@gmail.com";

        }

        private void c5_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "Emilia  Harförs";
            Mobile.Text = "072794456";
            email.Text = "Email:tiddy@gmail.com";


        }

        private void c6_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "Jenny Johansson";
            Mobile.Text = "088194456";
            email.Text = "Email:jennyjo@gmail.com";

            
        }

        private void c7_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "Naya Känfed";
            Mobile.Text = "099291156";
            email.Text = "Email:naya200@gmail.com";

        }

        private void c8_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "Felicia Andersson";
            Mobile.Text = "097713566";
            email.Text = "Email:felicia92@gmail.com";

            
        }

        private void c9_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "Cecilia Karlstad";
            Mobile.Text = "0977245696";
            email.Text = "Email:cecilia@gmail.com"; 
        }

        private void c10_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = "Julia Roberto";
            Mobile.Text = "0978232696";
            email.Text = "Email:julia@gmail.com";
        }
    }
}
