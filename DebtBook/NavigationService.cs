using DebtBook.Views;

namespace DebtBook
{
    public interface INavigationService
    {
        void Show(IViewModel viewModel, string id);
    }

    public class NavigationService : INavigationService
    {
        public void Show(IViewModel viewModel, string id)
        {
            switch (id)
            {
                case "AddDebtor":
                    var addDebtorView = new AddDebtor(viewModel);
                    addDebtorView.ShowDialog();
                    break;
                case "CheckDebt":
                    var checkDebt = new CheckDebt(viewModel);
                    checkDebt.ShowDialog();
                    break;

                default:
                    break;
            }
        }
    }
}