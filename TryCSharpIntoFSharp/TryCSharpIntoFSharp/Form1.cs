using System;
using System.Windows.Forms;
using TryFSharpLib;

namespace TryCSharpIntoFSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // add
        private void add_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(x1.Text);
            int b = Convert.ToInt32(y1.Text);
            z1.Text = MyMathLib.addition(a, b).ToString();
        }
        // multiply
        private void multiply_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(x2.Text);
            int b = Convert.ToInt32(y2.Text);
            z2.Text = MyMathLib.multiplication(a, b).ToString();
        }
    }
}
// programmed by aswini