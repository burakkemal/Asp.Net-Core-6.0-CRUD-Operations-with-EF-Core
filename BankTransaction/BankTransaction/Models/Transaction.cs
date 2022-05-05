using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransaction.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [DisplayName("Account Number")]
        [Required]
        public string AccountNumber { get; set; }

        [DisplayName("Beneficiary Name")]
        [Required]
        public string BeneficiaryName { get; set; }

        [DisplayName("Bank Name")]
        [Required]
        public string BankName { get; set; }

        [DisplayName("SWIFT Code")]
        [Required]
        [MaxLength(11,ErrorMessage ="Maximum 11 charecters only.")]
        public string SWIFTCode { get; set; }

        [Required]
        public int Amount { get; set; }
        public DateTime Date { get; set; }

    }
}
