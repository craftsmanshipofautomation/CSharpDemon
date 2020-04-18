using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            echolabel.DataBindings.Add("Text", textBox1, "Text");
            speech_ = new Speech("first of all");
            // Speech is now bound to textBox1
            // it is a two way street, textBox1 changes the state of speech_.Words
            // the latter also changes textBox1.Text
            textBox1.DataBindings.Add("Text", speech_, "Words");
        }

        readonly Speech speech_;

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(speech_.Words);
        }
    }
}
