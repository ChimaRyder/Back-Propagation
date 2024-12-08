using System;

namespace BackPropagation
{
	public class NeuralNetwork
	{
		private InputNeuron[] inputs;
		private OutputNeuron[] outputs;
		private HiddenNeuron[] hidden;
		private const double LRP_out = 0.2;
		private const double LRP_in = 0.15;
		private double[] errorComponent;
		private double[] errorDerivative;
		private double[] desiredout;

		public NeuralNetwork()
		{
			inputs = new InputNeuron[3072];
			outputs = new OutputNeuron[10];
			hidden = new HiddenNeuron[64];
			errorComponent = new double[10];
			errorDerivative = new double[10];
			desiredout = new double[10];
			createNeurons(inputs.Length, hidden.Length, outputs.Length);
		}

        public NeuralNetwork(int i, int h, int o)
		{
			inputs = new InputNeuron[i];
			outputs = new OutputNeuron[o];
			hidden = new HiddenNeuron[h];
			errorComponent = new double[o];
			errorDerivative = new double[o];
			desiredout = new double[o];
			createNeurons(inputs.Length, hidden.Length, outputs.Length);
		}

		public void createNeurons(int i, int h, int o)
		{
			for (int j = 0; j < i; j++)
			{
				inputs[j] = new InputNeuron(j, h);
			}

            for (int j = 0; j < h; j++)
			{
				hidden[j] = new HiddenNeuron(j, o);
			}

            for (int j = 0; j < o; j++)
			{
				outputs[j] = new OutputNeuron(j);
			}
		}

		public double getOutputData(int i)
		{
			return outputs[i].getActivation();
		}

		public void setInputs(int i, double data)
		{
			inputs[i].setInput(data);
		}

		public void setDesiredOutput(int i, double data)
		{
			desiredout[i] = data;
		}

		public double sigmoid(double dat)
		{
			if(dat >= 20.00)
			{
				dat = 32;
			}

			return (double)(1.0 / (1.0 + System.Math.Exp(-dat)));
		}

		public void calculateHA()
		{
			for (int i = 0; i < hidden.Length; i++)
			{
				double total = 0.0;

				for (int j = 0; j < inputs.Length; j++)
				{
					total += inputs[j].getInput() * inputs[j].getWeight(i);
				}

				hidden[i].setActivation(sigmoid(total + hidden[i].getBias()));
			}
		}

        public void calculateOA()
		{
			for (int i = 0; i < outputs.Length; i++)
			{
				double total = 0.0;

				for (int j = 0; j < hidden.Length; j++)
				{
					total += hidden[j].getActivation() * hidden[j].getWeight(i);
				}

				outputs[i].setActivation(sigmoid(total + outputs[i].getBias()));
			}
		}


	}
}
