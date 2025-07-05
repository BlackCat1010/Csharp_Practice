using System;
using System.Threading;

namespace C_EventsPractice;
// Subscriber
internal class Consoler
{
    public Consoler()
    {
        EmailServer.OnEmailReceived += testingToOnEmailReceived;
        while (true)
        { 
            EmailServer.EventTrigger();
        }
    }

    private void testingToOnEmailReceived(object? sender,EmailServer.EmailArgs e)
    {
        System.Console.WriteLine("testing Called");
        EmailServer.OnEmailReceived -= testingToOnEmailReceived;
        System.Console.WriteLine("Starting to use actual email receiving Subscribers in 10s");
        Thread.Sleep(10000);
        EmailServer.OnEmailReceived += deliverEmail;
    }

    private void deliverEmail(object? sender, EmailServer.EmailArgs e)
    {
        System.Console.WriteLine($"Email from {e.From} to {e.To} has been sent.");
        System.Console.WriteLine($"Body:");
        System.Console.WriteLine($"{e.Body}");
    }

}