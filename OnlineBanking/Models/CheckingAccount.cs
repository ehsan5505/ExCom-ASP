using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineBanking.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        [Display(Name = "Account Number")]
        [Required]
        [Column(TypeName = "varchar")]
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
        //public string ApplicationUserId { get; internal set; }

        public virtual ApplicationUser User { get; set; }
        public String ApplicationUserId { get; set; }
    }
}