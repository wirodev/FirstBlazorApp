using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class TextMessage
    {
        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "The mobile phone number must be 10 digits.")]
        public string MobilePhoneNumber { get; set; }

        [Required]
        [MaxLength(140, ErrorMessage = "The message content cannot exceed 140 characters.")]
        public string Content { get; set; }
    }
}
