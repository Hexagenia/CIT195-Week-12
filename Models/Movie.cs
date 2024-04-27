using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60,MinimumLength =3)]
        [Required]
        [Display(Name = "Make")]
        public string? Title { get; set; } = string.Empty;


        [DataType(DataType.Date)]
        [Display(Name = "Release Date (Year)")]
        public DateTime? ReleaseDate { get; set; }



        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Model")]
        public string? Genre { get; set; } = string.Empty;



        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Price new (not what I paid)")]
        public decimal Price { get; set; } = 0;


        
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        
        public string Rating { get; set; } = string.Empty;
    }
}
