namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Generate(int n)
        {
            if (n < 1 || n > 150)
            {
                throw new ArgumentException("Le nombre doit être compris entre 15 et 150");
            }

            string result = "";
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result += "FizzBuzz ";
                }
                else if (i % 3 == 0)
                {
                    result += "Fizz ";
                }
                else if (i % 5 == 0)
                {
                    result += "Buzz ";
                }
                else
                {
                    result += i.ToString() + " ";
                }
            }

            return result.TrimEnd();
        }
    }
}