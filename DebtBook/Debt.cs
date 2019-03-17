using System;
using Prism.Mvvm;

namespace DebtBook
{
    public class Debt : BindableBase
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

        public Debt(double amount)
        {
            Time = DateTime.Today;
            _amount = amount;
        }

        public Debt(double amount, DateTime time)
        {
            Time = time;
            Amount = amount;
        }
    }
}