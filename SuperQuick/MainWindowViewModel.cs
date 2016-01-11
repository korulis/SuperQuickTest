using System.Collections.ObjectModel;

namespace SuperQuick
{
    class MainWindowViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public MainWindowViewModel()
        {
            var context = new SuperQuickContext();
            Customers = new ObservableCollection<Customer>(context.Customers);
        }
    }
}
