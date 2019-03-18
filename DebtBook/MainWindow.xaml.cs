using System.Windows;

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
            DataContext = new ViewModelLocator().GetMainWindowViewModel();
        }
    }
}
