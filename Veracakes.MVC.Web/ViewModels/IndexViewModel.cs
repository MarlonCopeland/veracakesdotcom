using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veracakes.MVC.Web
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            contact = new ContactViewModel();
            order = new OrderViewModel();
        }

        public CakePage cakePage { get; set; }
        public ContactViewModel contact { get; set; }

        public OrderViewModel order { get; set; }
    }
}