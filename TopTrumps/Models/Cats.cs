using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace TopTrumps.Models
{
    public class Cats
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "ImageLink")]
        [DataType(DataType.Text)]

        public string? ImageLink { get; set; }

        [Required]
        [Display(Name = "Description")]
        [DataType(DataType.Text)]

        public string? Description { get; set; }

        [Required]
        [Display(Name = "Size")]
        [DataType(DataType.Text)]
        public int Size { get; set; }
        [Required]
        [Display(Name = "Rarity")]
        [DataType(DataType.Text)]
        public int Rarity { get; set; }
        [Required]
        [Display(Name = "GoodTemper")]
        [DataType(DataType.Text)]
        public int GoodTemper { get; set; }
        [Required]
        [Display(Name = "Cuteness")]
        [DataType(DataType.Text)]
        public int Cuteness { get; set; }
        [Required]
        [Display(Name = "Size")]
        [DataType(DataType.Text)]
        public int Mischief { get; set; }


    }
}
