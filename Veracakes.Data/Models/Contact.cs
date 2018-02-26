using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Unjaded.Core.MVC;


namespace Veracakes.Data
{
    [Table("Contact")]
    public class Contact : ModelBase
    {
        public Contact() : base() { }

        public Contact(string email, string message, string subject, DateTime? cakeDate)
            : base()
        {
            Message = message;
            Subject = subject;
            Email = email;
            CakeDate = cakeDate;

            IsActive = true;
            CreatedDate = DateTime.Now;
           
        }

        [Key]
        [Display(Name = "Customer ID")]
        public int ContactID { get; set; }

        [Display(Name = "Message")]
        public string Message { get; set; }

        //TODO: Validate Email regex on client
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Display(Name = "Cake Date")]
        public DateTime? CakeDate { get; set; }


        
    }
}
