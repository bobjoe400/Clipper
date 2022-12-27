using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Clipper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class Thumbnail
    {
        public Thumbnail() { }

        public Thumbnail(BitmapImage image, string game, DateTime timestamp)
        {
            Image = image;
            Game = game;
            Timestamp = timestamp;
        }

        public BitmapImage Image { get; set; } = default!;
        public string Game { get; set; } = "";
        public DateTime Timestamp { get; set; }
    }
    public partial class MainWindow : Window
    {
        private ObservableCollection<Thumbnail> FavThumbnails;
        private ObservableCollection<Thumbnail> RecentThumbnails;
        public MainWindow()
        {
            FavThumbnails = new ObservableCollection<Thumbnail>();
            RecentThumbnails = new ObservableCollection<Thumbnail>();
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewClipBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SearchClear_Click(object sender, RoutedEventArgs e)
        {
            SearchBox.Clear();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchBox.Text == "")
            {
                // Create an ImageBrush.
                ImageBrush textImageBrush = new ImageBrush();
                textImageBrush.ImageSource =
                    new BitmapImage(
                        new Uri("pack://application:,,,/Images/searchBarText.png")
                    );
                textImageBrush.AlignmentX = AlignmentX.Left;
                textImageBrush.Stretch = Stretch.Uniform;
                // Use the brush to paint the button's background.
                SearchBox.Background = textImageBrush;
            }
            else
            {

                SearchBox.Background = null;
            }
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MessageBox.Show("You just searched for " + SearchBox.Text + "!");
            }

        }
    }
}
