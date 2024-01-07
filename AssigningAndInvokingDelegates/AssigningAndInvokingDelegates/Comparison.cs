namespace AssigningAndInvokingDelegates
{
    public class Comparison
    {
        private readonly Func<Car, double> _valueSelector;

        public Comparison(Func<Car, double> valueSelector)
        {
            _valueSelector = valueSelector;
        }

        public double Yesterday { get; private set; }
        public double Today { get; private set; }
        public double Difference { get; private set; }

        public void Compare(Car yesterdayCar, Car todayCar)
        {
            Yesterday = _valueSelector(yesterdayCar);
            Today = _valueSelector(todayCar);
            Difference = Yesterday - Today;
        }
    }
}
