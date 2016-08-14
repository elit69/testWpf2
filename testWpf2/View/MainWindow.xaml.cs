using System.Windows;
using testWpf2.ViewModel;

namespace testWpf2.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new CustomerViewModel();
        }

        private void Button_Click ( object sender, RoutedEventArgs e ) {

        }
    }
}
