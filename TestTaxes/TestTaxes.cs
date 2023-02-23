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
            taxes.SetAnnualIncome(10776);
            string actual = "0% - 0";

            // Assert
            Assert.Equal($"{taxes.CalculateTaxesRate()}% - {taxes.CalculateTaxesAmount()}", actual);
        }
    }
}