using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void q1button_Click(object sender, EventArgs e)
        { outputLabel.Text = "";
            for (int i=0; i < 10; i++) {
                outputLabel.Text += "I will study every day starting now for exams "+ "\n";
            }
        }

        private void q2button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            int i = 0;
            while (i < 10)
            {
                outputLabel.Text += "I will study every day starting now for exams " + "\n";
                i++;
            }
            }

        private void q3button_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            try
            {
                int reps = Convert.ToInt32(textBox1.Text);
                int i = 0;
                while (i < reps)
                {
                    outputLabel.Text += "I will study every day starting now for exams " + "\n";
                    i++;
                }
            }
            catch { outputLabel.Text = "enter a valid input"; }
        }

        private void q4button_Click(object sender, EventArgs e)
        {try
            {
                int reps = Convert.ToInt32(textBox1.Text);
                outputLabel.Text = "";
                for (int i = 1; i < reps +1; i++)
                {

                    for (int j = 0; j < i * reps;)
                    {//font must be consolas because all numbers are the same size 
                        j = j + i;
                        if (j > 9)
                        {
                            outputLabel.Text += " "+j ;
                        }
                        if (j < 10) { outputLabel.Text += "  "+j ; }

                    }
                    outputLabel.Text += "\n";
                }
            }catch { outputLabel.Text = "enter a valid input"; }
        }
    }
}
