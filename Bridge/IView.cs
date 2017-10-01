namespace Bridge
{
    public interface IView
    {
        void DisplayOnMonitor(params IMediaType [] media);
    }
}
