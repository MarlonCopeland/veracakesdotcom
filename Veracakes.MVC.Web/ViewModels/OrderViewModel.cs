using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veracakes.MVC.Web
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {
            
        }

        public string Name { get; set; }
        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string CakeDescription { get; set; }

        public int CakeType { get; set; }

        public DateTime RequestedByDate { get; set; }



    }
}