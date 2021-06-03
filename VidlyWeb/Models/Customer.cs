using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VidlyWeb.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Please enter a customer's name")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        // Navigation Type - navigate from one object to it's related entity
        public MembershipType MembershipType { get; set; } 

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YrsIfMemeber]
        public DateTime? Birthdate { get; set; }

    }
}
