using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldForms {
    public partial class Form1 : Form {

        private int nbr = 0;

        public Form1() {
            InitializeComponent();
        }

        private void Minus_button_Click(object sender, EventArgs e) {
            Number.Text = (--nbr).ToString();
        }

        private void Plus_button_Click(object sender, EventArgs e) {
            Number.Text = (++nbr).ToString();
        }

        private void button1_Click(object sender, EventArgs e) {
            var userInput = InputNumber.Text;
            var aNumber = int.Parse(userInput);
            label1.Text = userInput;

        }
    }
}
