using System.ComponentModel.DataAnnotations;

namespace PROG6212_POE_Part_1.Models
{
    public class ClaimModel
    {
            public int ClaimId { get; set; }
            public string LecturerName { get; set; }
            public string LecturerSurname { get; set; }
            public string PhoneNumber { get; set; }
            public string Description { get; set; }
            public decimal Hours { get; set; }
            public string Status { get; set; }
        
    }
}
