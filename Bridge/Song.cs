using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Song : IMediaType
    {
        private readonly string title;
        private readonly string description;
        private readonly string photo;

        public Song(string title, string description, string photo)
        {
            this.title = title;
            this.description = description;
            this.photo = photo;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetPhoto()
        {
            return photo;
        }
    }
}
