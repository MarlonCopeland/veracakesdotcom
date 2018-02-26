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
        }

        public CakePage cakePage { get; set; }
        public ContactViewModel contact { get; set; }
    }
}