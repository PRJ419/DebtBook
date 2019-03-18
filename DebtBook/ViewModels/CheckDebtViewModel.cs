using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace DebtBook.ViewModels
{
    public class CheckDebtViewModel : BindableBase, IViewModel
    {
        private double _amount;

        public double Amount
        {
            get => _amount;
            set => SetProperty(ref _amount, value);
        }

        private DateTime _time;

        public DateTime Time
        {
            get => _time;
            set => SetProperty(ref _time, value);
        }

        public Person Person { set; get; }
        public CheckDebtViewModel(Person person)
        {
            Person = person;
            Amount = 0;
            Time = DateTime.Today;
        }

        private ICommand _addDebtCommand;

        public ICommand AddDebtCommand => _addDebtCommand ?? (_addDebtCommand = new DelegateCommand(OnAddDept));

        public void OnAddDept()
        {
            Person.Debts.Add(new Debt(Amount, Time));
            Person.CollectiveDebt += Amount;
        }
    }
}