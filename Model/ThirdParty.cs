using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGresol.Model
{
    [Table("ThirdParty")]
    public class ThirdParty
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ThirdPartyID { get; set; }


        [Required(ErrorMessage = "Name is mandatory")]
        [Column(Order = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "City is mandatory")]
        [Column(Order = 3)]

        public string City { get; set; }

        [Required(ErrorMessage = "State is mandatory")]
        [Column(Order = 4)]
        public string State { get; set; }

        [Required(ErrorMessage = "Contact Person is mandatory")]
        [Column(Order = 5)]
        public string ContactPerson { get; set; }

        [Column(Order = 6)]
        public string SecondaryContactPerson { get; set; }

        [Column(Order = 7)]

        public string Mobile { get; set; }

        [Column(Order = 8)]

        public string SecondaryMobile { get; set; }

        [Column(Order = 9)]

        public string Email { get; set; }
        
        [Column(Order = 10)]

        public string SecondaryEmail { get; set; }

        [Column(Order = 11)]
        public bool IsActive { get; set; }

        [Column(Order = 12)]
        public bool IsBuyer { get; set; }

        [Column(Order = 13)]
        public string GSTNumber { get; set; }

        [Column(Order = 14)]
        public int AssociateUser { get; set; }
        
        [Column(Order = 15)]
        public bool IsProspect { get; set; }


        [Column(Order = 16)]
        public bool IsSupplier { get; set; }


        [Column(Order = 16)]
        public bool IsGovernment { get; set; } = false;


        [Column(Order = 16)]
        public bool IsOther { get; set; } = false;


        public ICollection<Invoice> Invoices { get; set; }

        public ICollection<Visit> Visits { get; set; }

        //Reference Navigation Property

        //Reference Navigation Properties
        public Users Users { get; set; }

    }
}
