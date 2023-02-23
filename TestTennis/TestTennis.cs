namespace TestTennis
{
    public class TestTennis
    {
        [Fact]
        public void GetScore_ReturnsCorrectScore()
        {
            // Arrange
            string playerOne = "Roger Federer";
            string playerTwo = "Rafael Nadal";
            var tennis = new Tennis.Tennis();

            // Act
            tennis.MarkPoint(playerOne);
            tennis.MarkPoint(playerOne);
            tennis.MarkPoint(playerOne);

            tennis.MarkPoint(playerTwo);
            tennis.MarkPoint(playerTwo);

            var actual = "40 - 30";

            // Assert
            Assert.Equal(tennis.GetScore(), actual);
        }
    }
}