namespace C_OrdersNotificationApp;

internal class MyTextBox : TextBox
{
    public MyTextBox(int? x, int? y)
    {
        int systemWidth = x ?? 150;
        int systemHeight = y ?? 200;
        this.ReadOnly = true;
        this.Multiline = true;
        this.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.BorderStyle = BorderStyle.FixedSingle;
        this.Bounds = new Rectangle(systemWidth / 2 + 10, 10, systemWidth / 2 - 10, systemHeight / 2 - 10);
    }

    public void addCurrentText(string text)
    {
        this.AppendText(text + Environment.NewLine);
    }
}