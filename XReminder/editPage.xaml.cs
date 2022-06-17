﻿using System;
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
    /// Interaktionslogik für editPage.xaml
    /// </summary>
    public partial class editPage : Page
    {
        int aktID = 0;
        int editID = 0;
        Dictionary<int, Dictionary<string, string>> Elements;

        private MainWindow mainWindow = null;

        public editPage(MainWindow w, int ID, Dictionary<int, Dictionary<string, string>> allElements, int toEditID)
        {
            InitializeComponent();
            mainWindow = w;
            aktID = ID;
            Elements = allElements;
            editID = toEditID;
        }

        private void FillReminder(object sender, RoutedEventArgs e)
        {
            var RemID = this.Tag;

            titelBox.Text = "Titel";
            kategorieBox.Text = "Kategorie";
            
            prioBox.Text = "Prio";
            bemBox.Text = "Bemerkung";
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var titel = titelBox;
            var kat = kategorieBox;
            var hours = hrTime;
            var minutes = minTime;
            var prio = prioBox;
            var bem = bemBox;

            page2 Page2 = new page2(mainWindow, aktID, Elements);
            mainWindow.Content = Page2;
        }
        private void AbbrechenButton_Click(object sender, RoutedEventArgs e)
        {
            page2 Page2 = new page2(mainWindow, aktID, Elements);
            mainWindow.Content = Page2;
        }
    }
}
