public class AlarmClock
{
    public event EventHandler WakeUp = delegate { };
    public event EventHandler<DateTime> Ticked = delegate { };

    protected void OnWakeUp()
    {
        WakeUp.Invoke(this, EventArgs.Empty);
    }

    public DateTime AlarmTime { get; set; }

    public DateTime ClockTime { get; set; }

    public void Start()
    {
        // Run for 24 hours
        const int MinutesInADay = 60 * 24;
        for (var i = 0; i < MinutesInADay; i++)
        {
            ClockTime = ClockTime.AddMinutes(1);
            Ticked.Invoke(this, ClockTime);

            var timeRemaining = ClockTime.Subtract(AlarmTime).TotalMinutes;

            if (IsTimeToWakeUp(timeRemaining))
            {
                OnWakeUp();
                break;
            }
        }

        static bool IsTimeToWakeUp(double timeRemaining) => timeRemaining is (>= -1.0 and <= 1.0);
    }
}
