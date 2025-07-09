using System.CodeDom;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Transactions;

namespace C_OrdersNotificationApp;

internal class MyButton : Button
{
    
    public MyButton() : this(null)
    {
        // Calls constructor as null for buttonWidth
    }
    public MyButton(int? buttonWidth)
    {
        this.Text = "Process Order!";
        int actualWidth = buttonWidth ?? 150;
        int actualHeight = (int)(actualWidth * 1.62);
        this.Bounds = new Rectangle(10, 100, actualHeight, actualWidth);
    }

    
 }