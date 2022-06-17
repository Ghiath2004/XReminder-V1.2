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
    /// Interaktionslogik für Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        int aktID = 0;
        int detailID = 0;
        Dictionary<int, Dictionary<string, string>> Elements;

        private MainWindow mainWindow = null;

        public Page1(MainWindow w, int ID, Dictionary<int, Dictionary<string, string>> allElements, int detID)
        {
            InitializeComponent();
            mainWindow = w;
            aktID = ID;
            Elements = allElements;
            detailID = detID;
        }

        private void FillReminder(object sender, RoutedEventArgs e)
        {
            Titel.Text = Elements[detailID]["Titel"];
            Datum.Text = Elements[detailID]["Datum"];
            Bem.Text = Elements[detailID]["Bem"];
            if(Elements[detailID]["Erledigt"] == "Ja")
            {
                checkBtn.Background = (Brush)this.FindResource("greenCheckIcon");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            page2 Page2 = new page2(mainWindow, aktID, Elements);
            mainWindow.Content = Page2;
        }

        private void delRemBest(object sender, RoutedEventArgs e)
        {
            Grid bestaetigungGrid = BestaetigungGrid;
            bestaetigungGrid.Visibility = Visibility.Visible;
        }

        private void delRem(object sender, RoutedEventArgs e)
        {
            Elements.Remove(detailID);
            page2 Page2 = new page2(mainWindow, aktID, Elements);
            mainWindow.Content = Page2;
        }

        private void delRemAbb(object sender, RoutedEventArgs e)
        {
            Grid bestaetigungGrid = BestaetigungGrid;
            bestaetigungGrid.Visibility = Visibility.Hidden;
        }

        private void editRem(object sender, RoutedEventArgs e)
        {
            editPage editpage = new editPage(mainWindow, aktID, Elements, detailID);
            mainWindow.Content = editpage;
        }

        private void checkReminder(object sender, RoutedEventArgs e)
        {
            if(Elements[detailID]["Erledigt"] == "Nein")
            {
                Elements[detailID]["Erledigt"] = "Ja";
                ((Button)sender).Background = (Brush)this.FindResource("greenCheckIcon");
            } else
            {
                Elements[detailID]["Erledigt"] = "Nein";
                ((Button)sender).Background = (Brush)this.FindResource("checkIcon");
            }
        }
    }
}
