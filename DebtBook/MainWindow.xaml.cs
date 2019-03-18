using System.Windows;
using DebtBook.ViewModels;

namespace DebtBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel(new Persons());
        }
    }
}
