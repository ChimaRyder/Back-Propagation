using System;

namespace BackPropagation
{
    public class InputNeuron
    {
        private int idno;
        private double input;
        private double[] weights;
        private int weight_size;
        private int num;
        static System.Random rnd;

        public InputNeuron()
        {
            idno = 0;
            input = 0;
            weight_size = 64;
            weights = new double[weight_size];
            this.setRandomWeights(weight_size);
        }

        public InputNeuron(int idnodata, int size)
        {
            idno = idnodata;
            input = 0;
            weight_size = size;
            weights = new double[weight_size];
            this.setRandomWeights(weight_size);
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

        public int getID()
        {
            return idno;
        }

        public void setID(int no)
        {
            idno = no;
        }

        public double getInput()
        {
            return input;
        }

        public void setInput(double input)
        {
            this.input = input;
        }

        public double getWeight(int hidno)
        {
            return weights[hidno];
        }

        public void setWeight(int pos, double weight)
        {
            this.weights[pos] = weight;
        }

        public void setWeight(int pos, double err, double lrpin)
        {
            double x = err * lrpin;
            this.weights[pos] += (input * x);
        }
    }
}
