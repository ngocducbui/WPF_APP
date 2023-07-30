using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Page_Navigation_App.Utilities;
using System.Windows.Input;

namespace Page_Navigation_App.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand CustomersCommand { get; set; }
        public ICommand ProductsCommand { get; set; }
        public ICommand OrdersCommand { get; set; }
        public ICommand TransactionsCommand { get; set; }
        public ICommand ShipmentsCommand { get; set; }
        public ICommand SettingsCommand { get; set; }
        public ICommand UserCommand { get; set; }
        public ICommand SupplierCommand { get; set; }
        public ICommand WarehouseCommand { get; set; }
        public ICommand ExportCommand { get; set; }
        public ICommand UnitCommand { get; set; }


        private void Home(object obj) => CurrentView = new HomeVM();
        private void Customer(object obj) => CurrentView = new CustomerVM();
        private void Product(object obj) => CurrentView = new ProductVM();
        private void Order(object obj) => CurrentView = new OrderVM();
        private void Transaction(object obj) => CurrentView = new TransactionVM();
        private void Shipment(object obj) => CurrentView = new ShipmentVM();
        private void Setting(object obj) => CurrentView = new SettingVM();
        private void User(object obj) => CurrentView = new UserVM();
        private void Supplier(object obj) => CurrentView = new SupplierVM();
        private void Warehouse(object obj) => CurrentView = new WarehouseVM();
        private void Export(object obj) => CurrentView = new ExportVM();
        private void Unit(object obj) => CurrentView = new UnitVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            CustomersCommand = new RelayCommand(Customer);
            ProductsCommand = new RelayCommand(Product);
            OrdersCommand = new RelayCommand(Order);
            TransactionsCommand = new RelayCommand(Transaction);
            ShipmentsCommand = new RelayCommand(Shipment);
            SettingsCommand = new RelayCommand(Setting);
            UserCommand = new RelayCommand(User);
            SupplierCommand = new RelayCommand(Supplier);
            WarehouseCommand = new RelayCommand(Warehouse);
            ExportCommand = new RelayCommand(Export);
            UnitCommand= new RelayCommand(Unit);
            // Startup Page
            CurrentView = new HomeVM();
        }
    }
}
