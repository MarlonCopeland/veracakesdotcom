using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unjaded.Core.MVC;
using Unjaded.Core.MVC.Data;

namespace Veracakes.Data
{
    [Table("Order")]
    public class Order: ModelBase
    {
        public Order() : base() { }

        //TODO: Construct Order from Customer and Patry Design?


        [Key]
        [Display(Name = "Order ID")]
        public int OrderID { get; set; }


        [Display(Name = "CustomerID")]
        public int CustomerID{ get; set; }

        [Display(Name = "PastryDesignID")]
        public string PastryDesignID { get; set; }

        //TODO: Check the date ranges on the client or server?
        [Display(Name = "Order Date")]
        public DateTime? OrderDate { get; set; }

        [Display(Name = "Consult Date")]
        public DateTime? ConsultDate { get; set; }

        [Display(Name = "Overall Price")]
        public double OverallPrice { get; set; }


    }
}
