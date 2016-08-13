using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using testWpf2.ViewModel;

namespace testWpf2.Command {
    class CustomerUpdateCommand : ICommand {

        private CustomerViewModel viewModel;
        public CustomerUpdateCommand ( CustomerViewModel viewModel ) {
            this.viewModel = viewModel;
        }

        #region implement ICommand
        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute ( object parameter ) {
            return String.IsNullOrWhiteSpace(viewModel.customer.Error);
        }

        public void Execute ( object parameter ) {
            viewModel.saveChanges();
        }
        #endregion
    }
}
