using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Login
{
    public class LoginInfo:INotifyPropertyChanged
    {
        public ICommand LoginCommand => new Command(Submit);
        public string name { get; set; }
        public string password { get; set; }
        public string _message { get; set; }
        public string message {
            get { return _message; }
            set
            { _message= value; 
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Submit()
        {
            message = "Hai New User! " + "Your name is " + this.name;

        }
    }
}
