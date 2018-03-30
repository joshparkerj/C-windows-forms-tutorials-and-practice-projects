// This is from the tutorial found at:
// https://docs.microsoft.com/en-us/visualstudio/ide/tutorial-2-create-a-timed-math-quiz

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // A random object named randomizer
        // for generating random numbers.
        Random randomizer = new Random();
        // timer variable:
        int timeLeft;

        // integer variables for the quiz problems:
        int plus_operand1;
        int plus_operand2;
        int minus_operand1; // in the tutorial they call it "minuend" but that's pretty much greek to me
        int minus_operand2; // same for "subtrahend" ... operand seems much easier...
        int times_operand1;
        int times_operand2;
        int divide_operand1;
        int divide_operand2;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        public void StartTheQuiz()
        {
            // generate the random numbers for the quiz question:
            plus_operand1 = randomizer.Next(1, 51);
            plus_operand2 = randomizer.Next(1, 51);
            minus_operand1 = randomizer.Next(2, 101);
            minus_operand2 = randomizer.Next(1, minus_operand1);
            times_operand1 = randomizer.Next(2, 51);
            times_operand2 = randomizer.Next(2, 100 / times_operand1);
            divide_operand1 = randomizer.Next(4, 101);
            divide_operand2 = randomizer.Next(2, divide_operand1 / 2);
            // for quiz purposes, let's ensure that we can divide without a remainder:
            divide_operand1 = divide_operand1 - (divide_operand1 % divide_operand2); 
            // convert these numbers to strings and put them on the appropriate labels:
            plusLeftLabel.Text = plus_operand1.ToString();
            plusRightLabel.Text = plus_operand2.ToString();
            minusLeftLabel.Text = minus_operand1.ToString();
            minusRightLabel.Text = minus_operand2.ToString();
            timesLeftLabel.Text = times_operand1.ToString();
            timesRightLabel.Text = times_operand2.ToString();
            divideLeftLabel.Text = divide_operand1.ToString();
            divideRightLabel.Text = divide_operand2.ToString();
            // set the default value for the answer field:
            sum.Value = 0;
            difference.Value = 0;
            product.Value = 0;
            quotient.Value = 0;
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        public bool CheckTheAnswers()
        {
            if  (
                sum.Value == plus_operand1 + plus_operand2
                && difference.Value == minus_operand1 - minus_operand2
                && product.Value == times_operand1 * times_operand2
                && quotient.Value == divide_operand1 / divide_operand2
                )
                return true;
            else
                return false;

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            start_button.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswers())
            {
                timer1.Stop();
                timeLabel.Text = "Good Job!";
                MessageBox.Show("You finished the quiz!", "You win!");
                start_button.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft -= 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time!", "You lose!");
                sum.Value = plus_operand1 + plus_operand2;
                difference.Value = minus_operand1 - minus_operand2;
                product.Value = times_operand1 * times_operand2;
                quotient.Value = divide_operand1 / divide_operand2;
                start_button.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // identify the box that has been entered
            NumericUpDown answerBox = sender as NumericUpDown;
            // if a box of the NumericUpDown class has really been entered
            if (answerBox != null)
            {   
                // find out how much to select
                int lengthofAnswer = answerBox.Value.ToString().Length;
                // then select that much
                answerBox.Select(0, lengthofAnswer);
            }
        }
    }
}
