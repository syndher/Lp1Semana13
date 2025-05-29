

using System.ComponentModel;
using System.Formats.Asn1;

namespace MultipleStuff
{
    public class SuperList : List<Double>
    {
        private List<double> numbers;
        public SuperList(List<double> numbers)
        {
            this.numbers = numbers; // Use the base class (List<double>) to add the numbers
        }
        public class MinMax
        {
            public double Min { get; set; }
            public double Max { get; set; }
            public MinMax(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }

        public void GetMinMax1(out double min, out double max)
        {
            min = numbers[0];
            max = numbers[0];
            foreach (double number in numbers)
            {
                if (number < numbers[0])
                {
                    min = number;
                }
                if (number > numbers[0])
                {
                    max = number;
                }
            }
        }
        public MinMax GetMinMax2()
        {
            double min = numbers[0];
            double max = numbers[0];
            foreach (double number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
            return new MinMax(min, max);
        }
        public Tuple<Double, Double> GetMinMax3(double min, double max)
        {

            foreach (double number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }

            }
            return new Tuple<double, double>(min, max);
        }
        public (double, double) GetMinMax4(double min, double max)
        {
            foreach (double number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }

            }
            return (min, max);
        }
    }
}