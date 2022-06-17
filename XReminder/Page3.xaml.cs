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

namespace XReminder
{
    /// <summary>
    /// Interaktionslogik für Page3.xaml
    /// </summary>
    /// 


    public partial class Page3 : Page
    {
        string remTitel;
        string remDatum;
        string remHrs;
        string remMin;
        string remKat;
        string remBem;
        string remPrio;
        int aktID = 0;
        int newID;
        Dictionary<int, Dictionary<string, string>> Elements;

        private MainWindow mainWindow = null;

        public Page3(MainWindow w, int ID, Dictionary<int, Dictionary<string, string>> allElements)
        {
            InitializeComponent();
            mainWindow = w;
            aktID = ID;
            Elements = allElements;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            remTitel = titelBox.Text;
            remDatum = datumBox.Text;
            remHrs = hrTime.Text;
            remMin = minTime.Text;
            remKat = kategorieBox.Text;
            remBem = bemBox.Text;
            remPrio = prioBox.Text;
            newID = aktID + 1;
            var newEle = new Dictionary<string, string>();
            newEle["ID"] = newID.ToString();
            newEle["Titel"] = remTitel;

            newEle["Time"] = remDatum + "  " + remHrs + " : " + remMin;
            newEle["Kat"] = remKat;
            newEle["Bem"] = remBem;
            newEle["Prio"] = remPrio;
            newEle["Erledigt"] = "Nein";

            Elements[newID] = newEle;

            page2 Page2 = new page2(mainWindow, newID, Elements);

            mainWindow.Content = Page2;
        }
        private void AbbrechenButton_Click(object sender, RoutedEventArgs e)
        {
            page2 Page2 = new page2(mainWindow, aktID, Elements);
            mainWindow.Content = Page2;
        }
    }
}
