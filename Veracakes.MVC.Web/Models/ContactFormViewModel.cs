using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Veracakes.MVC.Web.Models
{
    public class ContactFormViewModel
    {
        string emailAddress { get; set; }
        string message { get; set; }
        string subject { get; set; }
        DateTime dateCake { get; set; } //Are you looking to get a cake at a specific time?
    }
}