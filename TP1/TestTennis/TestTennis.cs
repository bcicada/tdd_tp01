namespace TestTennis
{
    public class TestTennis
    {
        [Fact]
        public void GetScore_ReturnsCorrectScore()
        {
            // Arrange
            var tennis = new Tennis.Tennis();

            // Act
            tennis.PlayerOneMarkPoint();
            tennis.PlayerOneMarkPoint();
            tennis.PlayerOneMarkPoint();

            tennis.PlayerTwoMarkPoint();
            tennis.PlayerTwoMarkPoint();

            var actual = "40 - 30";

            // Assert
            Assert.Equal(tennis.GetScore(), actual);
        }
    }
}