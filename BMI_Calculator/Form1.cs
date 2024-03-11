using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        string underWeight = ">18,5 = Underweight";
        string normalWeight = "18,5 - 24,99 = Correct Weight";
        string overWeight = "25,0 - 29,99 = Overweight";
        string obesity1 = "30,0 - 34,99 = 1st degree obesity";
        string obesity2 = "35,0 - 39,99 = 2st degree obesity";
        string obesity3 = "<40,0 = 3st degree obesity";
        string incorrectData = "Incorrect Data";
        float weight;
        float height;
        float bmi;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            weight = (float)weightValue.Value;
            height = (float)heightValue.Value / 100;
            
            bmi = weight / (height * height);
            bmi = (float)Math.Round(bmi, 2);

            bmiResult.Text = bmi.ToString();
            switch (bmi)
            {
                case var value when value  < 18.5:
                    resultsLabel.Text = underWeight;
                    break;
                case var value when value > 18.5 && bmi < 24.99:
                    resultsLabel.Text = normalWeight;
                    break;
                case var value when value >= 25.0 && bmi < 29.99:
                    resultsLabel.Text = overWeight;
                    break;
                case var value when value >= 30.0 && bmi < 34.99:
                    resultsLabel.Text = obesity1;
                    break;
                case var value when value > 35.0 && bmi < 39.99:
                    resultsLabel.Text = obesity2;
                    break;
                case var value when value > 40.0:
                    resultsLabel.Text = obesity3;
                    break;
                default:
                    resultsLabel.Text = incorrectData;
                    break;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

    }
}
