using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiGresol.Model
{
    public class TravelExpense
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TravelExpenseID { get; set; }

        [Column(Order = 2)]
        public int AssociateUser { get; set; }

        [Column(Order = 3)]
        public DateTime JourneyDate { get; set; }
        
        [Column(Order = 4)]
        public DateTime EndDate { get; set; }
        
        [Column(Order = 5)]
        public double PetrolAllowance { get; set; } = 0;
        
        [Column(Order = 6)]
        public double FoodAllowance { get; set; } = 0;
        
        [Column(Order = 7)]
        public double OpenDistance { get; set; } = 0;
        
        [Column(Order = 8)]
        public double CloseDistance { get; set; } = 0;


        [Required(ErrorMessage = "Description is mandatory")]
        [Column(Order = 9)]
        public string Description { get; set; }


        [Required(ErrorMessage = "City is mandatory")]
        [Column(Order = 10)]
        public string City { get; set; }
        
        [Column(Order = 11)]
        public bool IsPaid { get; set; } = false;
        
        [Column(Order = 12)]
        public bool IsApprove { get; set; } = true;


        //Reference Navigation Properties
        public Users Users { get; set; }
    }
}
