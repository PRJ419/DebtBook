using System;
using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace DebtBook
{
    public class Person : BindableBase
    {
        private ObservableCollection<Debt> _debts;
        public ObservableCollection<Debt> Debts
        {
            get => _debts;
            set => SetProperty(ref _debts, value);
        }

        private double _collectiveDebt;

        public double CollectiveDebt
        {
            get => _collectiveDebt;
            set => SetProperty(ref _collectiveDebt, value);
        }

        private string _name;

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public Person(string name, double collectiveDebt)
        {
            Name = name;
            CollectiveDebt = collectiveDebt;
            Debts = new ObservableCollection<Debt> {new Debt(collectiveDebt)};
        }
    }
}