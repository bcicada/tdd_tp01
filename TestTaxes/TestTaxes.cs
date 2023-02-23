using Taxes;

namespace TestTaxes
{
    public class TestTaxes
    {
        [Fact]
        public void CalculateTaxesAmount_ReturnsCorrectAmount()
        {
            // Arrange
            var taxes = new Taxes.Taxes();

            // Act
            taxes.SetAnnualIncome(27478);

            var actual = 111;

            // Assert
            Assert.Equal(taxes.CalculateTaxesAmount(), actual);
        }
    }
}