using DebtBook.ViewModels;

namespace DebtBook
{
    public class ViewModelLocator
    {
        public NavigationService NavigationService { get; set; }

        public ViewModelLocator()
        {
            NavigationService = new NavigationService();
        }

        public void AddDebtorViewModel(string id, Persons persons)
        {
            var viewModel = new AddDebtorViewModel(persons);
            NavigationService.Show(viewModel, id);
        }

        public void CheckDebtViewModel(string id, Person person)
        {
            var viewmodel = new CheckDebtViewModel(person);
            NavigationService.Show(viewmodel,id);
        }
    }
}