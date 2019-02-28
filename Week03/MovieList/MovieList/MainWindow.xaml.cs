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

namespace MovieList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Movie>MovieList;

        public MainWindow()
        {
            InitializeComponent();

            MovieList = new List<Movie>();
        }

        private void buttonAddMovie_Click(object sender, RoutedEventArgs e)
        {
            string name = textBoxTitle.Text;
            int year = Convert.ToInt32(textBoxReleaseYear.Text);
            string director = textBoxDirector.Text;
            int legnth = Convert.ToInt32(textBoxLegnth.Text);
            string genre = textBoxGenre.Text;
            textBoxTitle.Clear();
            textBoxReleaseYear.Clear();
            textBoxDirector.Clear();
            textBoxLegnth.Clear();
            textBoxGenre.Clear();
            Movie newMovie = new Movie(name, year, director, legnth, genre);

            MovieList.Add(newMovie);

           
        }

        private void buttonShowAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (Movie movie in MovieList)
            {
                movie.ShowMovie();
            }
        }
    }
}
