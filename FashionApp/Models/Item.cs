using FashionApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionApp.Models
{
    public class Item : ObservableObject
    {
        DateTime? postDate;
        string blogName;
        string title;
        string description;
        string link;
        Uri image;

        public DateTime? PostDate 
        {
            get { return postDate; }
            set { postDate = value; }
        }
        public string BlogName
        {
            get { return blogName; }
            set { blogName = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        public Uri Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
