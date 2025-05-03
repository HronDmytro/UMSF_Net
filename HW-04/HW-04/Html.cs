public interface IMessageSender
{
    void Send(string message);
}

public class EmailSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine($"[Email] {message}");
}

public class SmsSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine($"[SMS] {message}");
}

public abstract class Message
{
    protected IMessageSender _sender;

    protected Message(IMessageSender sender) => _sender = sender;
    public abstract void Send(string content);
}

public class TextMessage : Message
{
    public TextMessage(IMessageSender sender) : base(sender) { }

    public override void Send(string content) => _sender.Send($"Text: {content}");
}

public class HtmlMessage : Message
{
    public HtmlMessage(IMessageSender sender) : base(sender) { }

    public override void Send(string content) => _sender.Send($"<html><body>{content}</body></html>");
}
