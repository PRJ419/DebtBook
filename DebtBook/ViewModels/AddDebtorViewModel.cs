using System;
using System.Diagnostics;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace DebtBook.ViewModels
{
    public class AddDebtorViewModel : BindableBase, IViewModel
    {
        public Person TempPerson { get; set; }
        public Persons Persons { set; get; }
        public AddDebtorViewModel(Persons persons)
        {
            if (Persons == null)
                Persons = persons;
            TempPerson = new Person("Name",0);
        }

        private ICommand _cancelCommand;
        public ICommand CancelCommand => _cancelCommand ??
                                                (_cancelCommand = new DelegateCommand<System.Windows.Window>(OnCancel));
        public void OnCancel(System.Windows.Window window)
        {
            window?.Close();
        }

        private ICommand _saveCommand;

        public ICommand SaveCommand => _saveCommand ?? (_saveCommand = new DelegateCommand<System.Windows.Window>(OnSave));

        public void OnSave(System.Windows.Window window)
        {
            Persons.Add(TempPerson);
            window?.Close();
        }
    }
}