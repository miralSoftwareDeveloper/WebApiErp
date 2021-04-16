using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGresol.Model
{
    public class Expense
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExpenseID { get; set; }


        [Required(ErrorMessage = "Category is mandatory")]
        [Column(Order = 2)]
        public int Categories { get; set; }
        
        [Column(Order = 3)]
        public int UserID { get; set; }
        
        [Column(Order = 4)]
        public bool IsPaid { get; set; } = false;

        [Required(ErrorMessage = "Expense Description is mandatory")]
        [Column(Order = 5)]
        public string Description { get; set; }
        
        [Column(Order = 6)]
        public double Amount { get; set; } = 0;


        //Reference Navigation Properties
        public Users Users { get; set; }

    }
}
