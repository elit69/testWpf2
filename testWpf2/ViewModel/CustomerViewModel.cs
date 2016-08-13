using System;
using System.Diagnostics;
using System.Windows.Input;
using testWpf2.Command;
using testWpf2.Model;
using testWpf2.View;

namespace testWpf2.ViewModel
{
    class CustomerViewModel {
        private CustomerInfoViewModel childViewModel;
        public Customer customer { get; set; }
		public ICommand updateCommand { get; set; }
        public CustomerViewModel ( ) {
            customer = new Customer("derp");
            updateCommand = new CustomerUpdateCommand(this);
            childViewModel = new CustomerInfoViewModel();
        }
        public void saveChanges ( ) {
            CustomerInfoView childView = new CustomerInfoView();
            childView.DataContext = childViewModel;
            childViewModel.info = customer.name + "er it's fuckingsave";
            childView.Show();
        }
        
    }
}
