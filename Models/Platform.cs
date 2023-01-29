
using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id { get; private set; }

        [Required]
        public string Name { get; private set; }

        [Required]
        public string Publisher { get; private set; }

        [Required]
        public string Cost { get; private set; }
    }
}