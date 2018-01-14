using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_Forms_MVVM.ViewModels {

    class MyNameViewModel : INotifyPropertyChanged {

        private string _myName { get; set; }
        public string MyName {

            get { return _myName; }

            set {
                _myName = value;
                OnPropertyChanged();
            }
        }

        private string _message { get; set; }
        public string Message {

            get { return _message; }

            set {
                _message = value;
                OnPropertyChanged();
            }
        }

        public Command IntroduceYourself {

            get {
                return new Command(() => { Message = $"My name is {MyName}"; });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
