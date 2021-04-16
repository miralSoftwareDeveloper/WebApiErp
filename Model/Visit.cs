using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGresol.Model
{
    public class Visit
    {

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VisitID { get; set; }
        public int ThirdPartyId { get; set; }

        public DateTime VisitDate { get; set; } = DateTime.Now;

        public string Response { get; set; }

        // Reference Navigation Property
        public ThirdParty  ThirdParty{ get; set; }


    }
}
