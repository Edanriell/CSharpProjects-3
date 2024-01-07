namespace AssigningAndInvokingDelegates
{
    public class JourneyComparer
    {
        public JourneyComparer()
        {
            Distance = new Comparison(GetCarDistance);
            JourneyTime = new Comparison(GetCarJourneyTime);
            AverageSpeed = new Comparison(GetCarAverageSpeed);
        }

        static double GetCarDistance(Car car) => car.Distance;

        static double GetCarJourneyTime(Car car) => car.JourneyTime;

        static double GetCarAverageSpeed(Car car) => car.Distance / car.JourneyTime;

        public Comparison Distance { get; }
        public Comparison JourneyTime { get; }
        public Comparison AverageSpeed { get; }

        public void Compare(Car yesterday, Car today)
        {
            Distance.Compare(yesterday, today);
            JourneyTime.Compare(yesterday, today);
            AverageSpeed.Compare(yesterday, today);
        }
    }
}
