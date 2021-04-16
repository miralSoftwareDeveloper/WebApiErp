using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGresol.Model
{
    public class Users
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Required(ErrorMessage = "User is mandatory")]
        [Column(Order = 2)]
        public string Name { get; set; }

        [Column(Order = 3)]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "City is mandatory")]
        [Column(Order = 4)]
        public string City { get; set; }


        [Required(ErrorMessage = "State is mandatory")]
        [Column(Order = 5)]
        public string State { get; set; }


        [Required(ErrorMessage = "Salary is mandatory")]
        [Column(Order = 6)]
        public int Salary { get; set; }
        [Column(Order = 7)]
        public int PetrolAllowance { get; set; } = 0;
        [Column(Order = 8)]
        public int TravelAllowance { get; set; } = 0;

        [Required(ErrorMessage = "Joining Date is mandatory")]
        [Column(Order = 9)]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        [Required(ErrorMessage = "End Date is mandatory")]
        [Column(Order = 10)]
        [DataType(DataType.Date)]
        public  DateTime EndDate { get; set; }
        public ICollection<Todo> Todos { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<TravelExpense> TravelExpenses { get; set; }

        public ICollection<ThirdParty> ThirdParty { get; set; }



    }
}
