using System.ComponentModel.DataAnnotations;

namespace SimpleAPI.Resources
{
    public class SaveSportResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}