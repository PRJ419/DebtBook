using System.Collections.ObjectModel;

namespace DebtBook
{
    public class Persons : ObservableCollection<Person>
    {
        public Persons()
        {
            Add(new Person("Lars", 700));
            Add(new Person("Lone", -800));               
            Add(new Person("Line", -200));               
        }
    }
}
