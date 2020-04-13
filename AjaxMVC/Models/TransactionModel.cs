using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxMVC.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [Display(Name = "Account Number")]
        [Required(ErrorMessage ="This Field is Required")]
        [MaxLength(12)]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Beneficiary Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string BeneficiaryName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "Bank Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(11)")]
        [Display(Name = "Swift Code")]
        [Required(ErrorMessage = "This Field is Required")]
        [MaxLength(11)]
        public string SwiftCode { get; set; }
        [Display(Name = "Amount")]
        [Required(ErrorMessage = "This Field is Required")]
        public int Amount { get; set; }
        [Display(Name = "Date")]
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
