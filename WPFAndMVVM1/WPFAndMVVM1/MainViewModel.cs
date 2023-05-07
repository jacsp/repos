using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPFAndMVVM1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _myLabelText = "Text not set yet";

        public string MyLabelText
        {
            get => _myLabelText;
            set
            {
                _myLabelText = value;
                OnPropertyChanged(nameof(MyLabelText));
            }
        }

        private string _myTextBoxText = "Text not set yet";

        public string MyTextBoxText
        {
            get => _myTextBoxText;
            set
            {
                _myTextBoxText = value;
                OnPropertyChanged(nameof(MyTextBoxText));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
