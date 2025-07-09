public class EventClickArgs : EventArgs
{
    public int TimesClicked { get; private set; }
    public EventClickArgs(int timesClicked)
    {
        TimesClicked = timesClicked;
    }
}