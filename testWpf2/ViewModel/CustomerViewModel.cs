using System;
using System.Diagnostics;
using System.Windows.Input;
using testWpf2.Command;
using testWpf2.Model;

namespace testWpf2.ViewModel
{
    class CustomerViewModel {
        public Customer customer { get; set; }
		public ICommand updateCommand { get; set; }
        public bool canUpdate {
            get {
                if (customer == null) return false;
                return !String.IsNullOrWhiteSpace(customer.name);
            }
        }
        public CustomerViewModel ( ) {
            customer = new Customer("derp");
            updateCommand = new CustomerUpdateCommand(this);
        }
        public void saveChanges ( ) {
            Debug.Assert(false, String.Format("{0} was formatted.", customer.name));
        }
        
    }
}
