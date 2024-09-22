namespace ExtraPointsCalculator.UnitTests
{
    [TestFixture]
    public class ExtraPointsCalculatorTests
    {
        [Test]
        public void CalculateExtraPointsBasedOnTime_LessThanOneMinute_Returns15()
        {
            // Arrange
            var timeSpent = TimeSpan.FromSeconds(59);

            // Act
            var result = PointsCalculator.CalculateExtraPointsBasedOnTime(timeSpent);

            // Assert
            Assert.AreEqual(15, result);
        }

        [Test]
        public void CalculateExtraPointsBasedOnTime_BetweenOneAndTwoMinutes_Returns10()
        {
            // Arrange
            var timeSpent = TimeSpan.FromSeconds(60);

            // Act
            var result = PointsCalculator.CalculateExtraPointsBasedOnTime(timeSpent);

            // Assert
            Assert.AreEqual(10, result);
        }

        [Test]
        public void CalculateExtraPointsBasedOnTime_BetweenTwoAndThreeMinutes_Returns5()
        {
            // Arrange
            var timeSpent = TimeSpan.FromSeconds(120);

            // Act
            var result = PointsCalculator.CalculateExtraPointsBasedOnTime(timeSpent);

            // Assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void CalculateExtraPointsBasedOnTime_MoreThanThreeMinutes_Returns0()
        {
            // Arrange
            var timeSpent = TimeSpan.FromSeconds(181);

            // Act
            var result = PointsCalculator.CalculateExtraPointsBasedOnTime(timeSpent);

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}