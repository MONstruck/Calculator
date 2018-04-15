using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool a = true;
        short i=5;
        ToDo toDo = new ToDo();
        Monitror operand = new Monitror();
        // realization of all button
        private void numPad1_Click(object sender, EventArgs e)
        {
            if (i == 5 ) { textBox1.Clear(); i = 0; }
            textBox1.Text += "1";
        }
        private void numPad2_Click(object sender, EventArgs e)
        {
            if (i == 5 ) { textBox1.Clear(); i = 0; }
            textBox1.Text += "2";
        }
        private void numPad3_Click(object sender, EventArgs e)
        {
            if (i == 5) { textBox1.Clear(); i = 0; }
            textBox1.Text += "3";
        }
        private void numPad4_Click(object sender, EventArgs e)
        {
            if (i == 5 ) { textBox1.Clear(); i = 0; }
            textBox1.Text += "4";
        }
        private void numPad5_Click(object sender, EventArgs e)
        {
            if (i == 5) { textBox1.Clear(); i = 0; }
            textBox1.Text += "5";
        }
        private void numPad6_Click(object sender, EventArgs e)
        {
            if (i == 5 ) { textBox1.Clear(); i = 0; }
            textBox1.Text += "6";
        }
        private void numPad7_Click(object sender, EventArgs e)
        {
            if (i == 5 ) { textBox1.Clear(); i = 0; }
            textBox1.Text += "7";
        }
        private void numPad8_Click(object sender, EventArgs e)
        {
            if (i == 5 ) { textBox1.Clear(); i = 0; }
            textBox1.Text += "8";
        }
        private void numPad9_Click(object sender, EventArgs e)
        {
            if (i == 5 ) { textBox1.Clear(); i = 0; }
            textBox1.Text += "9";
        }
        private void numPad0_Click(object sender, EventArgs e)
        {
            if (i == 5 ) { textBox1.Clear(); i = 0; }
            
            textBox1.Text += "0";
        }
        private void numPad_Click(object sender, EventArgs e)
        {
            if (a)
            if (i == 5) {
                textBox1.Clear();
                i = 0; textBox1.Text += "0,";
                a = false;
            }
            else
            {
                textBox1.Text += ",";
                a = false;
            }
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void numPadAdd_Click(object sender, EventArgs e)
        {
            if (i == 5) { log.Text = ""; }
            
            if (operand.Operand != 0)
            {
                log.Text += textBox1.Text + " + ";
                operand.Operand = toDo.Check(i, operand.Operand, double.Parse(textBox1.Text), toDo);
            }
            else {
                log.Text += textBox1.Text + " + ";
                operand.Operand = double.Parse(textBox1.Text);
            }
            i = 1;
            textBox1.Clear();
            

        }

        private void numPadSub_Click(object sender, EventArgs e)
        {
            if (i == 5) { log.Text = ""; }
            if (operand.Operand != 0)
            {
                log.Text += textBox1.Text + " - ";
                operand.Operand = toDo.Check(i, operand.Operand, double.Parse(textBox1.Text), toDo);
            }
            else
            {
                log.Text += textBox1.Text + " - ";
                operand.Operand = double.Parse(textBox1.Text);
            }
            i = 2;
            textBox1.Clear();
        }

        private void numPadDivide_Click(object sender, EventArgs e)
        {
            if (i == 5) { log.Text = ""; }
            if (operand.Operand != 0)
            {
                log.Text += textBox1.Text + " / ";
                operand.Operand = toDo.Check(i, operand.Operand, double.Parse(textBox1.Text), toDo);
            }
            else
            {
                log.Text += textBox1.Text + " / ";
                operand.Operand = double.Parse(textBox1.Text);
            }
            i = 3;
            textBox1.Clear();
        }

        private void numPadMult_Click(object sender, EventArgs e)
        {
            if (i == 5) { log.Text = ""; }
            if (operand.Operand != 0)
            {
                log.Text += textBox1.Text + " * ";
                operand.Operand = toDo.Check(i, operand.Operand, double.Parse(textBox1.Text), toDo);
            }
            else
            {
                log.Text += textBox1.Text + " * ";
                operand.Operand = double.Parse(textBox1.Text);
            }
            i = 4;
            textBox1.Clear();
        }
        //result math expression
        private void Answer_Click(object sender, EventArgs e)
        {

            log.Text += textBox1.Text;
            textBox1.Text = $"{toDo.Check(i, operand.Operand, double.Parse(textBox1.Text), toDo)}";
            log.Text+= " = " + textBox1.Text;
            operand.Operand = 0;
            
            i = 5;

        }
        //delete all values
        private void deleteButton_Click(object sender, EventArgs e)
        {
            operand.Operand = 0;
            log.Text="";
            textBox1.Clear();
        }

      
        //delete last symbol
        private void deleteOne_Click(object sender, EventArgs e)
        {
            string del = textBox1.Text;
            int a = del.Length;
            textBox1.Text = del.Remove(--a); ;
        }
    }
}
