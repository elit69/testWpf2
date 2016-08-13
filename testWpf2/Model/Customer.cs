using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace testWpf2.Model {
    class Customer : INotifyPropertyChanged , IDataErrorInfo {

        public Customer ( string name ) {
            this._name = name;
        }
        private string _name;
        public String name {
            get {
                return this._name;
            }
            set {
                this._name = value;
                OnPropertyChanged("name");
            } 
        }

        #region implement IDataErrorInfo
        public string Error {
            get;
            private set;
        }

        public string this[string columnName] {
            get {
                if (columnName == "name" && String.IsNullOrWhiteSpace(name)) {
                    Error = "cannot be null";
                } else {
                    Error = null;
                }
                return Error;
            }
        }
        #endregion

        #region implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged ( string propertyName ) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}
