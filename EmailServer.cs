using System.Dynamic;
using System.Security.Cryptography;

namespace C_EventsPractice;
// Publisher
internal static class EmailServer
{
    // Event declared
    public static event EventHandler<EmailArgs>? OnEmailReceived;

    public class EmailArgs : EventArgs
    {
        public string? From;
        public string? To;
        public string? Body;
    }

    public static void EventTrigger()
    {
        int randomSecond = new Random().Next(2, 5);
        System.Console.WriteLine($"Processing next input in {randomSecond} seconds");
        Thread.Sleep(randomSecond * 1000);
        OnEmailReceived?.Invoke(typeof(EmailServer), new EmailArgs { From="HSJ",To="KSS",Body="hi how are you?" });
    }
    
}