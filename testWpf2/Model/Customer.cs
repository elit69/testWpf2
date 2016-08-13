using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWpf2.Model {
    class Customer : INotifyPropertyChanged {

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
                OnPropertyChanged("Name");
            }
        }

        #region event
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
