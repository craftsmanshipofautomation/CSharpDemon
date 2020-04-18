using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo
{
    class Speech : INotifyPropertyChanged
    {
        private string value_;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Words { get { return value_; } 
            set
            {
                value_ = value;
                OnPropertyChanged("Words");
            } }

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        public Speech(string words)
        {
            Words = words;
        }
    }
}
