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
        string remKat;
        string remBem;
        string remPrio;
        int lastID;
        int newID;
        string[] allEle;
        string[] newEle;
        // string[] rems;
        UIElementCollection oldContent;
        UIElementCollection newContent;

        private MainWindow mainWindow = null;

        public Page3(MainWindow w)
        {
            InitializeComponent();
            mainWindow = w;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            page2 Page2 = new page2(mainWindow);
            remTitel = titelBox.Text;
            remDatum = datumBox.Text;
            remKat = kategorieBox.Text;
            remBem = bemBox.Text;
            remPrio = prioBox.Text;

            object dskfj = Page2.Tag;

            lastID = Int32.Parse(Page2.lastID.Text);
            newID = lastID + 1;
            Page2.lastID.Text = newID.ToString();
            var newEle = new Dictionary<string, string>();
            newEle["ID"] = newID.ToString();
            newEle["Titel"] = remTitel;
            newEle["Datum"] = remDatum;
            newEle["Kat"] = remKat;
            newEle["Bem"] = remBem;
            newEle["Prio"] = remPrio;

            var allEle = new Dictionary<int, Dictionary<string, string>>();
            allEle[newID] = newEle;

            Page2.Tag = allEle.ToArray();
            Page2.content.Text = allEle.ToString();

            mainWindow.Content = Page2;
        }
        private void AbbrechenButton_Click(object sender, RoutedEventArgs e)
        {
            page2 Page2 = new page2(mainWindow);
            mainWindow.Content = Page2;
        }
    }
}
