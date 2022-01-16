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


namespace sudoku
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void easyBtn_Click(object sender, RoutedEventArgs e)
        {
            PuzzlePage puzzlePage = new PuzzlePage();
            if (puzzlePage != null)
            {
                // Blir null :/
               this.NavigationService.Navigate(puzzlePage);
            }
        }
        
        private void mediumBtn_Click(object sender, RoutedEventArgs e)
        {
            //Debug.WriteLine("Medium is clicked.");

        }

        private void hardBtn_Click(object sender, RoutedEventArgs e)
        {
            //Debug.WriteLine("Hard is clicked.");

        }
    }

    
}
