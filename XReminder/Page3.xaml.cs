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
    public partial class Page3 : Page
    {
        private MainWindow mainWindow = null;

        public Page3(MainWindow w)
        {
            InitializeComponent();
            mainWindow = w;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            page2 Page2 = new page2(mainWindow);
            mainWindow.Content = Page2;
        }
        private void AbbrechenButton_Click(object sender, RoutedEventArgs e)
        {
            page2 Page2 = new page2(mainWindow);
            mainWindow.Content = Page2;
        }
    }
}
