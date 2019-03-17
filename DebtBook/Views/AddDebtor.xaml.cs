using System.Windows;

namespace DebtBook.Views
{
    /// <summary>
    /// Interaction logic for AddDebtor.xaml
    /// </summary>
    public partial class AddDebtor : Window
    {
        public AddDebtor(IViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
