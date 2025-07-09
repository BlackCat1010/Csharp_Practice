namespace C_OrdersNotificationApp;

public class EventsBootStrapper
{
    private Logger _logger;
    private EmailNotifier _emailnotifier;
    private OrderProcessor _backgroundorderprocessing;
    public int OrderCount { get; private set;}

    internal EventsBootStrapper(MyButton button, MyTextBox txtbox)
    {
        _logger = new Logger(txtbox);
        _emailnotifier = new EmailNotifier(txtbox);
        _backgroundorderprocessing = new OrderProcessor(txtbox);
        OrderCount = _backgroundorderprocessing._currentOrdercount;

        // Hook Events

        // Button Processing events
        button.Click += _logger.logTimeStamp;
        button.Click += _backgroundorderprocessing.ProcessOrder;
            
        // Background events
        _backgroundorderprocessing.OnOrderPlaced += _emailnotifier.logEmailSent;

        


    }
}