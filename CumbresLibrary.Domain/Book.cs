using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumbresLibrary.Domain
{
    public class Book
    {

        [Key]
        public int BookId { get; set; }

        [Display(Name = "Tittle")]
        [Required(ErrorMessage = "The field {0} is requiered.")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public string Tittle { get; set; }

        [Display(Name = "Subtittle")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public string Subtittle { get; set; }

        [Display(Name = "ISBN")]
        [Required(ErrorMessage = "The field {0} is requiered.")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public string ISBN { get; set; }

        [Display(Name = "Signature")]
        [MaxLength(200, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public string Signature { get; set; }

        [Display(Name = "Paginas")]
        [MaxLength(4, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public int Paginas { get; set; }

        [Display(Name = "Edition")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public string Edition { get; set; }

        [Display(Name = "Year")]
        [MaxLength(4, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public int Year { get; set; }

        [Display(Name = "Country")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public string Country { get; set; }

        [Display(Name = "Description")]
        [MaxLength(200, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public string Description { get; set; }

        public int AuthorId { get; set; }
        [JsonIgnore]
        public virtual Author Author { get; set; }


        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }
        

        public int EditorialId { get; set; }
        [JsonIgnore]
        public virtual Editorial Editorial { get; set; }


        [JsonIgnore]
        public virtual ICollection<ItemBook> ItemBooks { get; set; }

        [NotMapped]
        public byte[] ImageArray { get; set; }
    }
}
