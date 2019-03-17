using DebtBook.ViewModels;

namespace DebtBook
{
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel => new MainWindowViewModel(new Persons());

        public NavigationService NavigationService { get; set; }

        public MainWindowViewModel GetViewModel()
        {
            NavigationService = new NavigationService();
            return MainWindowViewModel;
        }
    }
}