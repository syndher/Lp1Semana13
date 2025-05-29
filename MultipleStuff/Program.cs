

namespace MultipleStuff
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Double> numbers = new List<Double> { 1, 31, 51, 2, 41, 284, 172 };
            SuperList superList = new SuperList(numbers);

            superList.GetMinMax1(out double min, out double max);
            Console.WriteLine($"Minimum: {min}, Maximum: {max}");

            SuperList.MinMax result = superList.GetMinMax2();
            Console.WriteLine($"Minimum: {result.Min}, Maximum: {result.Max}");

            Tuple<Double, Double> result2 = superList.GetMinMax3(Double.MaxValue, Double.MinValue);
            Console.WriteLine($"GetMinMax3: Min = {result2.Item1}, Max = {result2.Item2}");

            (double, double) result3 = superList.GetMinMax4(Double.MaxValue, Double.MinValue);
            Console.WriteLine($"GetMinMax4: Min = {result3.Item1}, Max = {result3.Item2}");
        }
    }
}