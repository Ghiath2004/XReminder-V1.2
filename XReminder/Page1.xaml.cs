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
        Dictionary<int, Dictionary<string, string>> Elements;

        private MainWindow mainWindow = null;

        public Page1(MainWindow w, int ID, Dictionary<int, Dictionary<string, string>> allElements)
        {
            InitializeComponent();
            mainWindow = w;
            aktID = ID;
            Elements = allElements;
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
            var RemID = this.Tag;

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
            var RemID = ((Button)sender).Tag;

            editPage editpage = new editPage(mainWindow, aktID, Elements);
            mainWindow.Content = editpage;

            editpage.Tag = RemID;
        }

        /*private void getID(object sender, RoutedEventArgs e)
        {
            var RemID = ((Button)sender).Tag;
            Grid bestaetigungGrid = BestaetigungGrid;
            bestaetigungGrid.Visibility = Visibility.Visible;
            delete(RemID);
        }

        public void delete(int remID)
        {
            
        }*/
    }
}
