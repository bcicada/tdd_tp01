namespace TestFizzBuzz
{
    public class TestFizzBuzz
    {
        [Theory]
        [InlineData(15, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz")]
        [InlineData(20, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz")]
        [InlineData(30, "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz")]
        public void Generate_ReturnsCorrectString(int n, string expected)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz.FizzBuzz();

            // Act
            string actual = fizzBuzz.Generate(n);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}