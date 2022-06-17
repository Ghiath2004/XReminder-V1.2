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
    /// Interaktionslogik für page2.xaml
    /// </summary>
    public partial class page2 : Page
    {
        private MainWindow mainWindow = null;

        public page2(MainWindow w)
        {
            InitializeComponent();
            mainWindow = w;
        }

        private void FillReminders(object sender, RoutedEventArgs e)
        {
            object Rems = this.Tag;

            if (Rems != null)
            {
                Reminders.Children.Add((UIElement)Rems);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Page3 page3 = new Page3(mainWindow);
            mainWindow.Content = page3;
        }

        private void DetailButton_Click(object sender, RoutedEventArgs e)
        {
            var RemID = ((Button)sender).Tag;

            Page1 page1 = new Page1(mainWindow);
            mainWindow.Content = page1;

            page1.Tag = RemID;
        }
    }
}
