using FashionApp.Helpers;
using FashionApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FashionApp.ViewModels
{
    [DataContract]
    public class ItemViewModel : ObservableObject
    {
        private ObservableCollection<Item> collectionOfItems;

        public ItemViewModel()
        {

        }
        public ItemViewModel(ObservableCollection<Blog> blogs)
        {
            LoadItems(blogs);
        }
        public ObservableCollection<Item> CollectionOfItems
        {
            get {return collectionOfItems;}
            private set 
            {
                collectionOfItems = value;
                RaisePropertyChanged("CollectionOfItems");
            }
        }
        public void LoadItems(ObservableCollection<Blog> blogs)
        {
            collectionOfItems = new ObservableCollection<Item>();

            foreach (Blog blog in blogs)
            {
                WebClient client = new WebClient();
                client.DownloadStringCompleted += (s, e) =>
                {
                    IEnumerable<Item> resData = from rss in XElement.Parse(e.Result).Descendants("item")
                                                select new Item
                                                {
                                                    BlogName = rss.Parent.Element("title").Value,
                                                    Link = rss.Element("link").Value,
                                                    Title = rss.Element("title").Value,
                                                    PostDate = Convert.ToDateTime(rss.Element("pubDate").Value)
                                                };

                    foreach(Item i in resData)
                    {
                        collectionOfItems.Add(i);
                    }
                };

                client.DownloadStringAsync(blog.Address);
            }
        }
    }
}
