using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return string.Format($"{this.ID} - {this.Title} - {this.ImageURL} - by {this.SendByUsername}");
        }
    }
}