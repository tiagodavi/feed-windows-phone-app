using FashionApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionApp.Models
{
    public class Blog : ObservableObject
    {
        string name;
        Uri address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Uri Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
