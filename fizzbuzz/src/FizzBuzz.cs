namespace FizzBuzKata
{
    public class FizzBuzz
    {
        public FizzBuzz()
        { }

        public string StringFor(int number)
        {
            return FizBuzzRules(number);

            string FizBuzzRules(int number)
            {
                return IsDivisibleByFive(number) && IsDivisibleByTree(number)
                    ? "FizzBuzz"
                    : IsDivisibleByTree(number)
                    ? "Fizz"
                    : IsDivisibleByFive(number)
                    ? "Buzz"
                    : number.ToString();
            }
        }

        private bool IsDivisibleByTree(int number) =>
         number % 3 == 0;

        private bool IsDivisibleByFive(int number) =>
        number % 5 == 0;
    }
}