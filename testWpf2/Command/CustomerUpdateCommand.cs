﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using testWpf2.ViewModel;

namespace testWpf2.Command {
    class CustomerUpdateCommand : ICommand {

        private CustomerViewModel customerViewModel;
        public CustomerUpdateCommand ( CustomerViewModel viewModel ) {
            this.customerViewModel = viewModel;
        }

        #region implement
        public event EventHandler CanExecuteChanged {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute ( object parameter ) {
            return customerViewModel.canUpdate;
        }

        public void Execute ( object parameter ) {
            customerViewModel.saveChanges();
        }
        #endregion
    }
}
