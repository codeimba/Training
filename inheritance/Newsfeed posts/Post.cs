using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_
{
    public class Post
    {
        private static int currentPostID;
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My first post";
            SendByUsername = "MartinEmilov";
            IsPublic = true;
        }

        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostID;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format($"{this.ID} - {this.Title} - by {this.SendByUsername}");
        }
    }
}