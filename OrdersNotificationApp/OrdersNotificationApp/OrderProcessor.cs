namespace C_OrdersNotificationApp;

internal class OrderProcessor
{
    // Event Publisher
    public event EventHandler<EventClickArgs>? OnOrderPlaced;

    public int _currentOrdercount { get; private set; } = 0;

    private MyTextBox? _textbox;
    public OrderProcessor(MyTextBox textbox)
    {
        _textbox = textbox;
    }

    async public void ProcessOrder()
    {
        _currentOrdercount++;
        int cachedOrder = _currentOrdercount;
        // Indicate Start of Processing
        _textbox?.AppendText($"Background Processing for Order No {cachedOrder}...\r\n");

        // Simulate Delay for OrderValidation
        int randomSecond = new Random().Next(5, 10);
        await Task.Delay(randomSecond * 1000);
        OrderValidation();

        // Indicate End of Processing
        _textbox?.AppendText($"Order No {cachedOrder} Processed!\r\n");
        OnOrderPlaced?.Invoke(this, new EventClickArgs(cachedOrder));
    }

    public void ProcessOrder(object? sender,EventArgs e)
    {
        ProcessOrder();
    }

    public void OrderValidation()
    {
        // Business Validations
        
    }
}