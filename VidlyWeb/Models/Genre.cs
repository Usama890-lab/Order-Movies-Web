using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VidlyWeb.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required(ErrorMessage ="A name is required to add a genre.")]
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

    }
}
