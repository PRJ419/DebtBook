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

        private ViewModelLocator _viewModelLocator;

        private Person _currentPerson = null;

        public Person CurrentPerson
        {
            get => _currentPerson;
            set => SetProperty(ref _currentPerson, value);
        }

        public MainWindowViewModel(Persons persons)
        {
            _viewModelLocator = new ViewModelLocator();            
            PersonList = persons;
            CurrentPerson = PersonList[0];
        }

        private ICommand _showAddDebtorCommand;

        public ICommand ShowAddDebtorCommand => _showAddDebtorCommand ??
                                                (_showAddDebtorCommand = new DelegateCommand(OnShowDebtor));

        public void OnShowDebtor()
        {
            _viewModelLocator.GetAddDebtorViewModel("AddDebtor", PersonList);            
        }

        private ICommand _showCheckDebtCommand;

        public ICommand ShowCheckDebtCommand =>
            _showCheckDebtCommand ?? (_showCheckDebtCommand = new DelegateCommand(OnShowCheckDebt));

        public void OnShowCheckDebt()
        {
            _viewModelLocator.GetCheckDebtViewModel("CheckDebt", CurrentPerson);
        }

    }
}
