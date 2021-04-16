using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WebApiGresol.Model
{
    public class Invoice
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceID { get; set; }

        [Column(Order = 2)]
        public int ThirdPartyID { get; set; }

        [Required(ErrorMessage = "Invoice Number is mandatory")]
        [Column(Order = 3)]
        public string InvoiceNumber { get; set; }

        [Required(ErrorMessage = "Invoice Date is mandatory")]
        [Column(Order = 4)]
        [DataType(DataType.Date)]
        public DateTime InvoiceDate { get; set; }


        [Required(ErrorMessage = "Amount is mandatory")]
        [Column(Order = 5)]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter valid Amount")]
        public double Amount { get; set; } = 0;


        [Required(ErrorMessage = "Credit Days is mandatory")]
        [Column(Order = 6)]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Credit Days")]
        public int CreditDays { get; set; } = 30;

        [Column(Order = 7)]
        public bool IsSale { get; set; } = true;

        [Column(Order = 8)]
        public bool IsPaid { get; set; } = false;

        [Column(Order = 9)]
        public bool IsBadDedbt { get; set; } = false;

        //Reference Property
        public ThirdParty ThirdParty { get; set; }



    }
}
