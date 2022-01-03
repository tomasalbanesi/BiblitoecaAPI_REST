using System.ComponentModel.DataAnnotations;

namespace BiblitoecaAPI_REST.DTOs
{
    public class CategoryCreationDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
