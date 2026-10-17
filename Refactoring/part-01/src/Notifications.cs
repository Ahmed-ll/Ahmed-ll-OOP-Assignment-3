namespace Refactoring.Part01;

public class Notification
{
    private readonly IChannel _channel;
    private readonly bool _isUrgent;
    private readonly DateTime? _sendAt;

    public Notification(IChannel channel, bool isUrgent = false, DateTime? sendAt = null)
    {
        _channel = channel;
        _isUrgent = isUrgent;
        _sendAt = sendAt;
    }

    public void Send(string to, string message)
    {
        if (_isUrgent)
            message = $"[URGENT] {message}";

        if (_sendAt is not null)
            _channel.Schedule(to, message, _sendAt.Value);

        else
            _channel.Send(to, message);
    }
}

public interface IChannel
{
    void Send(string to, string message);

    void Schedule(string to, string message, DateTime sendAt);
}

public class EmailChannel : IChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
    public void Schedule(string to, string message, DateTime sendAt) =>
        Console.WriteLine($"[email scheduled {sendAt:g}] {to}: {message}");
}

public class SmsChannel : IChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
    public void Schedule(string to, string message, DateTime sendAt) =>
        Console.WriteLine($"[sms scheduled {sendAt:g}] {to}: {message}");
}
public class WhatsAppChannel : IChannel
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[whatsapp] {to}: {message}");
    public void Schedule(string to, string message, DateTime sendAt) =>
        Console.WriteLine($"[whatsapp scheduled {sendAt:g}] {to}: {message}");
}
