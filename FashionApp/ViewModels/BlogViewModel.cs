using FashionApp.Helpers;
using FashionApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FashionApp.ViewModels
{
    [DataContract]
    public class BlogViewModel : ObservableObject
    {
        private ObservableCollection<Blog> collectionOfBlogs;

        public BlogViewModel()
        {
            LoadBlogs();
        }

        [DataMember]
        public ObservableCollection<Blog> CollectionOfBlogs
        {
            get { return collectionOfBlogs; }
            private set
            {
                collectionOfBlogs = value;
                RaisePropertyChanged("CollectionOfBlogs");
            }
        }
        private void LoadBlogs()
        {
            collectionOfBlogs = new ObservableCollection<Blog>();

            collectionOfBlogs.Add(new Blog { Name = "Eduardo Pires", Address = new Uri("http://eduardopires.net.br/feed/") });
            collectionOfBlogs.Add(new Blog { Name = "Fabricio Sanchez", Address = new Uri("http://fabriciosanchez.com.br/2/feed/") });
        }
    }
}
