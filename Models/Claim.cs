using System.ComponentModel.DataAnnotations;

namespace CMCS.Models

{
    public class Claim
    {
        public int ClaimID { get; set; }

        [Required]
        public int LecturerID { get; set; }
        public Lecturer? Lecturer { get; set; }

        [DataType(DataType.Date)]
        public DateTime ClaimDate { get; set; } = DateTime.Today;

        [Range(0, 500)]
        public decimal HoursWorked { get; set; }

        [Range(0, 5000)]
        public decimal HourlyRate { get; set; }

        // Calculated on the fly; not stored
        public decimal TotalAmount => Math.Round(HoursWorked * HourlyRate, 2);

        // Pending, Approved, Rejected
        [Required, StringLength(20)]
        public string ClaimStatus { get; set; } = "Pending";

        public ICollection<SupportingDocument> SupportingDocuments { get; set; } = new List<SupportingDocument>();
        public ICollection<Approval> Approvals { get; set; } = new List<Approval>();
    }
}
