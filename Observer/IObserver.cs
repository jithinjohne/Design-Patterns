namespace Observer
{
    public interface IObserver
    {
        void OnNotify(IWeatherPayload weatherPayload);
    }
}