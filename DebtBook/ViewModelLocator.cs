using DebtBook.ViewModels;

namespace DebtBook
{
    public class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel => new MainWindowViewModel(new Persons());

        public NavigationService NavigationService { get; set; }


        public ViewModelLocator()
        {
            NavigationService = new NavigationService();
        }

        public MainWindowViewModel GetMainWindowViewModel()
        {
            return MainWindowViewModel;
        }

        public void GetAddDebtorViewModel(string id, Persons persons)
        {
            var viewModel = new AddDebtorViewModel(persons);
            NavigationService.Show(viewModel, "AddDebtor");
        }

        public void GetCheckDebtViewModel(string id, Person person)
        {
            var viewmodel = new CheckDebtViewModel(person);
            NavigationService.Show(viewmodel,id);
        }
    }
}