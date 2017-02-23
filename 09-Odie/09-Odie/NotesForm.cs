//Exercise 09
//Odie de Moura

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_Odie
{
    public partial class NotesForm : Form
    {
        public NotesForm()
        {
            InitializeComponent();
        }

        public string TextContents
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public bool HasTextChanged = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HasTextChanged = true;
        }
    }
}
