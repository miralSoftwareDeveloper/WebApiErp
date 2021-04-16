using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiGresol.Model
{
    public class ExpenseCategories
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UID { get; set; }

        [Required(ErrorMessage = "Category is mandatory")]
        [Column(Order = 2)]
        public string CategoryName { get; set; }

        [Column(Order = 3)]
        public bool IsActive { get; set; } = true;

    }
}
