using BackPropagation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Back_Propagation
{
    public partial class Form1 : Form
    {
        private NeuralNetwork neuralNetwork;
        public Form1()
        {
            InitializeComponent();
            AddValidate();
        }

        private void AddValidate()
        {
            inputBox1.KeyPress += ValidateInput;
            inputBox2.KeyPress += ValidateInput;
            inputBox3.KeyPress += ValidateInput;
            inputBox4.KeyPress += ValidateInput;
        }

        private void ValidateInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as RichTextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void createNeuralNetwork_Click(object sender, EventArgs e)
        {
            neuralNetwork = new NeuralNetwork(4, 50, 1);
            MessageBox.Show("Neural Network Created.");
        }

        private void trainNeuralNetwork_Click(object sender, EventArgs e)
        {
            if (neuralNetwork == null)
            {
                MessageBox.Show("Create a Neural Network first.");
                return;
            }

            TrainNeuralNetwork();
        }

        private void TrainNeuralNetwork()
        {
            for (int epoch = 0; epoch < 500; epoch++)
            {
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            inputBox1.Clear();
            inputBox2.Clear();
            inputBox3.Clear();
            inputBox4.Clear();
            neuralNetworkOutput.Clear();
        }

        private void testNeuralNetwork_Click(object sender, EventArgs e)
        {
            if (neuralNetwork == null)
            {
                MessageBox.Show("Create a Neural Network first.");
                return;
            }

            testNetwork();
        }

        private void testNetwork()
        {
            neuralNetwork.setInputs(0, Convert.ToDouble(inputBox1.Text));
            neuralNetwork.setInputs(1, Convert.ToDouble(inputBox2.Text));
            neuralNetwork.setInputs(2, Convert.ToDouble(inputBox3.Text));
            neuralNetwork.setInputs(3, Convert.ToDouble(inputBox4.Text));

            neuralNetwork.run();

            double output = neuralNetwork.getOutputData(0);
            neuralNetworkOutput.Text = output.ToString() + " | " + (output > 0.6 ? "True" : "False");
        }
    }
}
