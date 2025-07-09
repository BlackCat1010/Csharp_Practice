using C_OrdersNotificationApp;

internal class Logger
{
    // Subscriber 1 - To do logging and timestamp
    private MyTextBox? _textboxx;

    public Logger(MyTextBox textboxx)
    {
        _textboxx = textboxx;
    }
    public Logger()
    {
        // Empty constructor
    }

    public void logTimeStamp(object? sender, EventArgs e)
    {
        // int cachedTimesClicked = e.TimesClicked;
        logTimeStamp(null);
    }
    public void logTimeStamp(int? TimesClicked)
    {
        DateTime dateTimeNow = DateTime.Now;
        string localDateTimeNow = dateTimeNow.ToString();
        Console.WriteLine($"Order Placed at {localDateTimeNow}");
        _textboxx?.addCurrentText($"Order Placed at {localDateTimeNow}");
    }
}