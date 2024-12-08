using System;

namespace BackPropagation
{
	public class HiddenNeuron
	{
		private double[] weights;
		private int idno;
		private int weight_size;
		private double activation;
		private double bias;
		private double error;
		static System.Random rnd;

		public HiddenNeuron()
		{
			idno = 0;
			activation = 0.0;
			bias = this.randomWeight();
			error = 0.0;
			weight_size = 10;
			weights = new double[weight_size];
			this.setRandomWeights(10);
		}

		public HiddenNeuron(int idnodata, int size)
		{
			idno = idnodata;
			activation = 0.0;
			bias = 0.01;
			error = 0.0;
			weight_size = size;
			weights = new double[weight_size];
			this.setRandomWeights(weight_size);
		}

		public int getID()
		{
			return idno;
		}

		public void setID(int no)
		{
			idno = no;
		}

		public double getActivation()
		{
			return activation;
		}

		public void setError(double e)
		{
			error = e;
		}

		public double getError()
		{
			return error;
		}

		public void calculateErr(double[] der)
		{
			double result = 0.0;

			for (int i = 0; i < der.Length; i++)
			{
				result += (der[i] * weights[i]);
			}

			error = (result * activation * (1 - activation));
		}

		public void setActivation(double a)
		{
			activation = a;
		}

		public double getBias()
		{
			return bias;
		}

		public void setBias(double b)
		{
			bias = b;
		}

		public void changeBias(double lrpin)
		{
			bias += (error * lrpin);
		}

		public double getWeight(int id)
		{
			return weights[id];
		}

		public void setWeight(int pos, double weight)
		{
			this.weights[pos] = weight;
		}

		public void setWeight(double lrpout, double[] der)
		{
			double x = 0.0;
			x = activation * lrpout;

			for (int i = 0; i < der.Length; i++)
			{
				weights[i] += (x * der[i]);
			}
		}

		private double randomWeight()
		{
			if (rnd == null)
			{
				rnd = new System.Random();
			}

			int maxLimit = +1000;
			int minLimit = -1000;

			double weight = (double)(rnd.Next(minLimit, maxLimit)) / 2000;

			return weight;
		}

		public void setRandomWeights(int size)
		{
			for (int i = 0; i < size; i++)
			{
				weights[i] = this.randomWeight();
			}
		}
	}
}
