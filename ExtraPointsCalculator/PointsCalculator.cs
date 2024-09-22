namespace ExtraPointsCalculator
{
    public static class PointsCalculator
    {
        public static int CalculateExtraPointsBasedOnTime(TimeSpan timeSpent)
        {
            const int FirstMinuteThresholdMs = 60 * 1000; // 1 dakika
            const int TwoMinutesThresholdMs = 2 * 60 * 1000; // 2 dakika
            const int ThreeMinutesThresholdMs = 3 * 60 * 1000; // 3 dakika

            var timeSpentMs = (int)timeSpent.TotalMilliseconds;

            return timeSpentMs switch
            {
                < FirstMinuteThresholdMs => 15,
                < TwoMinutesThresholdMs => 10,
                < ThreeMinutesThresholdMs => 5,
                _ => 0
            };
        }
    }
}