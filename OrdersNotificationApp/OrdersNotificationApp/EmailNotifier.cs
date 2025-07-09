using C_OrdersNotificationApp;

internal class EmailNotifier
{
    // Subscriber 2 - To simulate send email
    private MyTextBox? _textbox;

    public EmailNotifier(MyTextBox textboxx)
    {
        _textbox = textboxx;
    }

    public EmailNotifier()
    {
        // Empty constructor
    }
    public async void logEmailSent(object? sender, EventClickArgs e)
    {
        // int cachedTimesClicked = e.TimesClicked;
        await Task.Delay(3000);
        // Simulate Email sent
        logEmailSent(e.TimesClicked);
    }

    public void logEmailSent(int? TimesClicked)
    {
        switch (TimesClicked)
        {
            case null:
                Console.WriteLine($"EmailNotifier: Email Sent in 3 seconds");
                _textbox?.addCurrentText($"EmailNotifier: Email Sent in 3 seconds");
                break;
            default:
                Console.WriteLine($"EmailNotifier: Email for Order No. {TimesClicked} sent!");
                _textbox?.addCurrentText($"EmailNotifier: Email for Order No. {TimesClicked} sent!");
                break;
        }

        
    }
}