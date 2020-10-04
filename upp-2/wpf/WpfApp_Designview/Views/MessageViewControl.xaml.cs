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
    /// Interaction logic for MessageViewControl.xaml
    /// </summary>
    public partial class MessageViewControl : UserControl
    {
        public MessageViewControl()
        {
            InitializeComponent();
        }

        private void btn_ms1_Click(object sender, RoutedEventArgs e)
        {
            Subject.Text = "Faktura för september";
            from.Text = "Comviq <no-reply@comviq.se>";
            to.Text = "nourknefed@gmail,com";
            time.Text = "tors 10:10 pm";
            body.Text = "Faktura för september Att betala - 070 094 12 37 " +
                "375 kr." +
                "Har du autobetalning behöver du inte göra något med denna faktura. Din betalning dras då automatiskt.";
        }

        private void btn_ms2_Click(object sender, RoutedEventArgs e)
        {
            Subject.Text = "Din beställning har levererats";
            from.Text = "H&M < hm@deliverystatus.com >";
            to.Text = "nourknefed@gmail,com";
            time.Text = "tors 08:15 pm";
            body.Text = "Din beställning har levererats" +
                "Vår leveranspartner har meddelat oss att din order är levererad. Hör gärna av dig om du undrar något." +
                "Hoppas du blir nöjd med din beställning!" +
                "Varma hälsningar," +
                "H&M.";

        }

        private void btn_ms3_Click(object sender, RoutedEventArgs e)
        {
            Subject.Text = "Nya personliga jobbrekommendationer";
            from.Text = "jobrecommendations < jobrecommendations@sites.careerbuilder.se > ";
            to.Text = "nourknefed@gmail,com";
            time.Text = "tors 05:30 pm";
            body.Text = "Du har jobbrekommendationer som är nya för dig sedan 2 dagar tillbaka. Dessa visas med enikon. " +
                "Dina jobbrekommendationer baseras bland annat på dina tidigare ansökningar via CareerBuilder.se och innehållet i ditt CV." +
                " Du kan även anpassa dina rekommendationer ytterligare genom att att uppdatera ditt CV!";
                
        }

        private void btn_ms4_Click(object sender, RoutedEventArgs e)
        {
            Subject.Text = "Fråga barnpsykologen!";
            from.Text = "Libero noreply@libero.se";
            to.Text = "nourknefed@gmail,com";
            time.Text = "tors 09:30 am";
            body.Text = "Hej nour,Ibland kan det vara smått överväldigande att vara förälder, " +
                "och de första småbarnsåren kan bitvis kännas snåriga.Om du är en av de som går runt med funderingar kring ditt föräldraskap, " +
                "familjelivet eller ditt barns utveckling så har du nu chansen att prata med en expert." +
                " Nu öppnar vi nämligen för en frågestund med barnpsykologen Tova Winbladh, live på Liberos Instagram.";
        }
    }
}
