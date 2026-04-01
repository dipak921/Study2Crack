using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ELearningPlatform.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        public ICollection<Topic>? Topics { get; set; } = new List<Topic>();
    }
}
