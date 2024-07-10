using System.Text;

namespace TwistedFizzBuzz
{
    public class FizzBuzz
    {
        public static string StandarFizzBuzz(int number)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i < number; i++)
            {
                string result = "";
                if (i % 3 == 0)
                {
                    result += "Fizz";
                }
                if (i % 5 == 0)
                {
                    result += "Buzz";
                }
                if (string.IsNullOrEmpty(result))
                {
                    sb.AppendLine(i.ToString()); continue;
                }
                sb.AppendLine(result);
            }
            return sb.ToString();
        }
        public static string TFizzBuzz(Dictionary<int, string> tokenNumber, string numbers)
        {
            StringBuilder sb = new StringBuilder();
            var range = numbers.Replace("(", "").Replace(")", "").Split(" - ");
            if (range.Length < 2)
            {
                range = numbers.Replace("(", "").Replace(")", "").Split(",");
            }
            if (range.Length > 2)
            {
                for (int i = 0; i < range.Length; i++)
                {
                    string result = "";
                    foreach (var item in tokenNumber)
                    {
                        if (int.Parse(range[i]) % item.Key == 0)
                        {
                            result += item.Value;
                        }
                    }
                    if (string.IsNullOrEmpty(result))
                    {
                        sb.AppendLine(i.ToString()); continue;
                    }
                    sb.AppendLine(result);
                }
                return sb.ToString();
            }
            int start = int.Parse(range[0]);
            int end = int.Parse(range[1]);
            for (int i = start; i < end; i++)
            {
                string result = "";
                foreach (var item in tokenNumber)
                {
                    if (i % item.Key == 0)
                    {
                        result += item.Value;
                    }
                }
                if (string.IsNullOrEmpty(result))
                {
                    sb.AppendLine(i.ToString()); continue;
                }
                sb.AppendLine(result);
            }
            return sb.ToString();
        }
    }
}
