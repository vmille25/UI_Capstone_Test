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

namespace cap_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double maxWndHeight;
        public double maxWndWidth;
        public double scale;
        public double lstboxMinFont;
        public double lstboxMaxFont;
        public double nameTBminFont;
        public double nameTBMaxFont;
        public const double minWndHeight = 450;
        public const double minWndWidth = 800;
        public const double listBoxSpacing = 10;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void mainWnd_Loaded(object sender, RoutedEventArgs e)
        {
            maxWndHeight = mainWnd.Height;
            maxWndWidth = mainWnd.Width;
            lstboxMinFont = lstBox.FontSize;
            nameTBminFont = nameTB.FontSize;

            scale = Math.Min((maxWndHeight / minWndHeight), (maxWndWidth / minWndWidth));

            nameTB.Height = nameTB.MinHeight * scale;
            nameTB.Width = nameTB.MinWidth * scale;
            nameTB.MaxHeight = nameTB.Height;
            nameTB.MaxWidth = nameTB.Width;
            nameTB.FontSize = nameTB.FontSize * scale;
            nameTBMaxFont = nameTB.FontSize;


            lstBox.Height = lstBox.MinHeight * scale;
            lstBox.Width = lstBox.MinWidth * scale;
            lstBox.MaxHeight = lstBox.Height;
            lstBox.MaxWidth = lstBox.Width;
            lstBox.FontSize = lstboxMinFont * scale;
            lstboxMaxFont = lstBox.FontSize;
            lstBox.Items.Add("Select a Index:");
            lstBox.Items.Add("SPY 500");
            lstBox.Items.Add("DOW 30");
            lstBox.Items.Add("S&P 500");
            Thickness t2 = new Thickness(lstBox.Margin.Left, nameTB.Height, 0, 0);
            lstBox.Margin = t2;

            lstBox2.Height = lstBox.Height;
            lstBox2.Width = lstBox.Width;
            lstBox2.MaxHeight = lstBox2.Height;
            lstBox2.MaxWidth = lstBox2.Width;
            lstBox2.FontSize = lstBox.FontSize;
            lstBox2.Items.Add("Select Pattern:");
            lstBox2.Items.Add("Cup and handle");
            lstBox2.Items.Add("Falling wedge");
            lstBox2.Items.Add("Short squeeze");
            Thickness t1 = new Thickness(lstBox.Margin.Left + lstBox.Width + listBoxSpacing, nameTB.Height, 0, 0);
            lstBox2.Margin = t1;

        }

        private void mainWnd_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (mainWnd.WindowState != WindowState.Maximized)
            {
                scale = Math.Min((mainWnd.Height / minWndHeight), (mainWnd.Width / minWndWidth));

                nameTB.Height = nameTB.MinHeight * scale;
                nameTB.Width = nameTB.MinWidth * scale;
                nameTB.FontSize = nameTBminFont * scale;

                lstBox.Height = lstBox.MinHeight * scale;
                lstBox.Width = lstBox.MinWidth * scale;
                lstBox.FontSize = lstboxMinFont * scale;
                Thickness t2 = new Thickness(lstBox.Margin.Left, nameTB.Height, 0, 0);
                lstBox.Margin = t2;

                lstBox2.Height = lstBox.Height;
                lstBox2.Width = lstBox.Width;
                lstBox2.FontSize = lstBox.FontSize;
                Thickness t1 = new Thickness(lstBox.Margin.Left + lstBox.Width + listBoxSpacing, nameTB.Height, 0, 0);
                lstBox2.Margin = t1;
            }
            
        }

        private void mainWnd_StateChanged(object sender, EventArgs e)
        {
            if (mainWnd.WindowState == WindowState.Maximized)
            {
                nameTB.Height = nameTB.MaxHeight;
                nameTB.Width = nameTB.MaxWidth;
                nameTB.FontSize = nameTBMaxFont;

                lstBox.Height = lstBox.MaxHeight;
                lstBox.Width = lstBox.MaxWidth;
                lstBox.FontSize = lstboxMaxFont;
                Thickness t2 = new Thickness(lstBox.Margin.Left, nameTB.Height, 0, 0);
                lstBox.Margin = t2;

                lstBox2.Height = lstBox.Height;
                lstBox2.Width = lstBox.Width;
                lstBox2.FontSize = lstboxMaxFont;
                Thickness t1 = new Thickness(lstBox.Margin.Left + lstBox.Width + listBoxSpacing, nameTB.Height, 0, 0);
                lstBox2.Margin = t1;
            }
        }

        private void lstBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
