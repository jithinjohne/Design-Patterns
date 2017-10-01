using System;

namespace Bridge
{
    public class LongView : IView
    {
        public void DisplayOnMonitor(params IMediaType[] media)
        {
            foreach (var mediaType in media)
            {
                Console.WriteLine($"Title - {mediaType.GetTitle()}");
                Console.WriteLine($"Description - {mediaType.GetDescription()}");
                Console.WriteLine($"Photo - {mediaType.GetPhoto()}");
            }
        }
    }
}
