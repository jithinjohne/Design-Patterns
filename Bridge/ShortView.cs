using System;

namespace Bridge
{
    public class ShortView : IView
    {
        public void DisplayOnMonitor(params IMediaType[] media)
        {
            foreach (var mediaType in media)
            {
                Console.WriteLine($"{mediaType.GetTitle()} - {mediaType.GetDescription()}");
            }
        }
    }
}
