using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo
{
    class Speech
    {
        private string value_;


        public string Words { get { return value_; } 
            set
            {
                value_ = value;
            } }

  
        public Speech(string words)
        {
            Words = words;
        }
    }
}
