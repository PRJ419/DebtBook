using System.Windows.Input;
using DebtBook.Views;
using Prism.Commands;
using Prism.Mvvm;

namespace DebtBook.ViewModels
{
    public class MainWindowViewModel : BindableBase, IViewModel
    {
        public INavigationService NavigationService { get; set; }
        public Persons PersonList { get; set; }

        private Person _currentPerson = null;

        public Person CurrentPerson
        {
            get => _currentPerson;
            set => SetProperty(ref _currentPerson, value);
        }

        public MainWindowViewModel(Persons persons)
        {
            NavigationService = new NavigationService();

            if(PersonList == null)
            PersonList = persons;
            CurrentPerson = PersonList[0];
        }

        private ICommand _showAddDebtorCommand;

        public ICommand ShowAddDebtorCommand => _showAddDebtorCommand ??
                                                (_showAddDebtorCommand = new DelegateCommand(OnShowDebtor));

        public void OnShowDebtor()
        {
            var window = new AddDebtorViewModel(PersonList);
            NavigationService.Show(window, "AddDebtor");
        }

        private ICommand _showCheckDebtCommand;

        public ICommand ShowCheckDebtCommand =>
            _showCheckDebtCommand ?? (_showCheckDebtCommand = new DelegateCommand(OnShowCheckDebt));

        public void OnShowCheckDebt()
        {
            var window = new CheckDebtViewModel(_currentPerson);
            NavigationService.Show(window, "CheckDebt");
        }

    }
}
