using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veracakes.MVC.Web
{
    public class CakePage
    {
        public CakePage()
        {
            lstCakes = new List<string>();
            strDescription = "";
        }

       public  List<string> lstCakes { get; set; }
       public string strDescription { get; set; }
    }
}