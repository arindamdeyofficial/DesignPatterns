namespace Factory
{
    public interface IDeviceFactory
    {
        IDevice CreateDevice(int deviceType);
    }
}
