public interface IDevice
{
    void On();
    void Off();
}

public class TV : IDevice
{
    public void On() => Console.WriteLine("TV is ON");
    public void Off() => Console.WriteLine("TV is OFF");
}

public class Radio : IDevice
{
    public void On() => Console.WriteLine("Radio is ON");
    public void Off() => Console.WriteLine("Radio is OFF");
}

public abstract class Remote
{
    protected IDevice _device;

    protected Remote(IDevice device) => _device = device;

    public abstract void TogglePower();
}

public class BasicRemote : Remote
{
    private bool _isOn = false;

    public BasicRemote(IDevice device) : base(device) { }

    public override void TogglePower()
    {
        if (_isOn) _device.Off();
        else _device.On();
        _isOn = !_isOn;
    }
}
