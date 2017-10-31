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
    [Table("PastryDesign")]
    public class PastryDesign : ModelBase
    {
        public PastryDesign() : base() { }


        [Key]
        [Display(Name = "Pastry ID")]
        public int PastryID { get; set; }

 
        [Display(Name = "Pastry Style")]
        public string PastryStyle { get; set; }

        [Display(Name = "Pastry Type")]
        public string PastryType { get; set; }

        [Display(Name = "Pastry Details")]
        public string PastryDetails { get; set; }

        [Display(Name = "Pastry Price")]
        public string PastryPrice { get; set; }
    }
}

