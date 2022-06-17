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

        private MainWindow mainWindow = null;

        public Page3(MainWindow w)
        {
            InitializeComponent();
            mainWindow = w;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            remTitel = titelBox.Text;
            remDatum = datumBox.Text;
            remKat = kategorieBox.Text;
            remBem = bemBox.Text;

            Grid remGrid = new Grid();
            remGrid.Margin = new Thickness(20, 20, 20, 0);
            remGrid.HorizontalAlignment = HorizontalAlignment.Stretch;
            remGrid.VerticalAlignment = VerticalAlignment.Top;

            RowDefinition gridRow1 = new RowDefinition();
            gridRow1.Height = new GridLength(40);
            RowDefinition gridRow2 = new RowDefinition();
            gridRow2.Height = new GridLength(40);
            remGrid.RowDefinitions.Add(gridRow1);
            remGrid.RowDefinitions.Add(gridRow2);

            ColumnDefinition gridCol1 = new ColumnDefinition();
            gridCol1.Width = new GridLength();
            ColumnDefinition gridCol2 = new ColumnDefinition();
            gridCol2.Width = new GridLength(50);
            ColumnDefinition gridCol3 = new ColumnDefinition();
            gridCol3.Width = new GridLength(20);
            ColumnDefinition gridCol4 = new ColumnDefinition();
            gridCol4.Width = new GridLength(50);
            remGrid.ColumnDefinitions.Add(gridCol1);
            remGrid.ColumnDefinitions.Add(gridCol2);
            remGrid.ColumnDefinitions.Add(gridCol3);
            remGrid.ColumnDefinitions.Add(gridCol4);
           
            TextBlock txtBlock1 = new TextBlock();
            txtBlock1.SetValue(Grid.RowProperty, 0);
            txtBlock1.SetValue(Grid.ColumnProperty, 0);
            txtBlock1.TextAlignment = TextAlignment.Left;
            txtBlock1.FontSize = 30;
            txtBlock1.Text = remTitel;
            txtBlock1.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));
            remGrid.Children.Add(txtBlock1);

            TextBlock txtBlock2 = new TextBlock();
            txtBlock2.SetValue(Grid.RowProperty, 1);
            txtBlock2.SetValue(Grid.ColumnProperty, 0);
            txtBlock2.TextAlignment = TextAlignment.Left;
            txtBlock2.VerticalAlignment = VerticalAlignment.Bottom;
            txtBlock2.FontSize = 15;
            txtBlock2.Text = remDatum + " - " + remBem;
            txtBlock2.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffffff"));
            remGrid.Children.Add(txtBlock2);

            Style style = new Style(typeof(Border));
            style.Setters.Add(new Setter(Border.CornerRadiusProperty, new CornerRadius(10)));

            Button btn1 = new Button();
            btn1.SetValue(Grid.RowProperty, 0);
            btn1.SetValue(Grid.ColumnProperty, 1);
            btn1.SetValue(Grid.RowSpanProperty, 2);
            btn1.Width = 50;
            btn1.Height = 50;
            btn1.Resources.Add(typeof(Border), style);
            btn1.Background = (Brush)this.FindResource("checkIcon");
            remGrid.Children.Add(btn1);

            Button btn2 = new Button();
            btn2.SetValue(Grid.RowProperty, 0);
            btn2.SetValue(Grid.ColumnProperty, 3);
            btn2.SetValue(Grid.RowSpanProperty, 2);
            btn2.Width = 50;
            btn2.Height = 50;
            btn2.Resources.Add(typeof(Border), style);
            btn2.Background = (Brush)this.FindResource("suchIcon");
            remGrid.Children.Add(btn2);

            page2 Page2 = new page2(mainWindow);
            mainWindow.Content = Page2;

            Page2.Tag = remGrid;
        }
        private void AbbrechenButton_Click(object sender, RoutedEventArgs e)
        {
            page2 Page2 = new page2(mainWindow);
            mainWindow.Content = Page2;
        }
    }
}
