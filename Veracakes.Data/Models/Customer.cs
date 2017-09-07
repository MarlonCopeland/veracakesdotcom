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
    [Table("Customer")]
    public abstract class Customer : ModelBase
    {
        public Customer() : base() { }

        public Customer(string firstName, string lastName, string email, string phoneNumber, string addressLine1, string addressLine2, 
            string city, string state, string zip, int )
            : base()
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            ZipCode = zip;

            IsActive = true;
            CreatedDate = DateTime.Now;
            CreatedSessionID = CreatedSessionID;

        }

        [Key]
        [Display(Name = "Customer ID"]
        public int CustomerID { get; set; }

        [MaxLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [MaxLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [EmailAddress]
        [Display(Name = "Email"]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name ="State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        
    }
}
