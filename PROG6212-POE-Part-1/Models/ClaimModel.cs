using System.ComponentModel.DataAnnotations;

namespace PROG6212_POE_Part_1.Models
{
    public class ClaimModel
    {
        [Required(ErrorMessage = "Please provide a description of the claim")]
        public string ClaimDescription { get; set; } // Description of the claim

        [Required(ErrorMessage = "Please enter the date of the incident")]
        [Display(Name = "Supporting Documents")]
        public List<IFormFile> SupportingDocuments { get; set; } // List of uploaded files

        public decimal ClaimAmount { get; set; } // The amount being claimed
    }
}
