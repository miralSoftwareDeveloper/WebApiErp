using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiGresol.DTO
{
    public class DtoThirdParty
    {
        public int ThirdPartyID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ContactPerson { get; set; }
        public string SecondaryContactPerson { get; set; }
        public string Mobile { get; set; }
        public string SecondaryMobile { get; set; }
        public string Email { get; set; }
        public string SecondaryEmail { get; set; }
        public bool IsActive { get; set; }
        public bool IsBuyer { get; set; }
        public string GSTNumber { get; set; }
        public int AssociateUser { get; set; }
        public bool IsProspect { get; set; }
        public bool IsSupplier { get; set; }
        public bool IsGovernment { get; set; } = false;
        public bool IsOther { get; set; } = false;

    }

    
}
