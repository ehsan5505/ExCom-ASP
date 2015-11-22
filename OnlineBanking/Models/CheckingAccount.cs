using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace OnlineBanking.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        [Display(Name = "Account Number")]
        [Required]
        [RegularExpression(@"\w{3}-\d{3}-\w{3}\d{4}",ErrorMessage = "Account Number format should be RSX-314-ACC3141")]
        public String AccountNumber { get; set; }
        [Display(Name = "First Name")]
        [Required]
        [RegularExpression(@"\w{5,10}")]
        public String FirstName { get; set; }

        [Display(Name ="Last Name")]
        [Required]
        [RegularExpression(@"\w{5,10}")]
        public String LastName { get; set; }

        [Display(Name="Name")]
        public String Name
        {
           get 
                {
                return String.Format("{0} {1}", this.FirstName, this.LastName);
                }
        }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

    }
}