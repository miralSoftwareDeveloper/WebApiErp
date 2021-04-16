using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGresol.Model
{
    public class Todo
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TodoID { get; set; }


        [Required(ErrorMessage = "Description is mandatory")]
        [Column(Order = 2)]
        public string Description { get; set; }

        [Column(Order = 3)]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Column(Order = 4)]
        public int EstimateDays { get; set; } = 2;
        
        [Column(Order = 5)]
        public DateTime CompletionDate { get; set; }
        
        [Column(Order = 6)]
        public int AssignTo { get; set; }
        
        [Column(Order = 7)]
        public int AssignBy { get; set; }
        
        [Column(Order = 8)]
        public bool IsActive { get; set; }

        [Column(Order = 10)]
        public int Progress { get; set; }

        //Reference Navigation Properties
        public Users Users { get; set; }

    }
}
