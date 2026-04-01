using System;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatform.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(150)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required]
        public string MessageText { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
    }
}
