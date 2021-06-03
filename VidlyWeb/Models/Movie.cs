using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VidlyWeb.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Genre field is required")]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }


        [Required(ErrorMessage = "Release Date field is required")]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name= "Date Added")]
        public DateTime InventoryDate { get; set; }

        [Required(ErrorMessage = "Number in Stock field is required")]
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }


    }
}
