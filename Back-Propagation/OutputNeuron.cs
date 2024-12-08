using System;

namespace BackPropagation
{
	public class OutputNeuron
	{
		private double bias;
		private int idno;
		private double activation;
		static System.Random rnd;

		public OutputNeuron()
		{
			bias = this.randomBias();
			idno = 0;
			activation = 0.0;
		}

		public OutputNeuron(int idnodata)
		{
			bias = 0.01;
			idno = idnodata;
			activation = 0.0;
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

		public void changeBias(double lrpout, double[] der)
		{
			bias += lrpout * der[idno];
		}

		private double randomBias()
		{
			if (rnd == null)
			{
				rnd = new System.Random();
			}

			int maxLimit = +1000;
			int minLimit = -1000;

			double bias = (double)(rnd.Next(minLimit, maxLimit)) / 2000;

			return bias;
		}
	}
}
