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
   public  class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The field {0} is requiered.")]
        [MaxLength(100, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        [Index("Category_Name_Index", IsUnique = true)]
        public string Category_Name { get; set; }


        [JsonIgnore]
        public virtual ICollection<Book> Books { get; set; }
    }
}
