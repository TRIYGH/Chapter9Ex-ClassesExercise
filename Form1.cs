using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExampleProj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int whatItyped;
            whatItyped = int.Parse(textBox1.Text);

            GoToClassThatCalcsx2 CalcObjectInstantiated1 = new GoToClassThatCalcsx2(whatItyped);

            textBox1.Text = Convert.ToString(CalcObjectInstantiated1.MultipleByTwo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int whatItyped;
            whatItyped = int.Parse(textBox1.Text);

            GoToClassThatCalcsx100 CalcObjectInstantiated2 = new GoToClassThatCalcsx100(whatItyped);

            textBox1.Text = Convert.ToString(CalcObjectInstantiated2.MultipleByHundred());
        }
    }
}
