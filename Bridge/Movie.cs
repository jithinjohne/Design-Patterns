using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Movie : IMediaType
    {
        private readonly string title;
        private readonly string description;
        private readonly string photo;

        public Movie(string title, string description, string photo)
        {
            this.title = title;
            this.description = description;
            this.photo = photo;
        }
        public string GetDescription()
        {
            return description;
        }

        public string GetPhoto()
        {
            return photo;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
