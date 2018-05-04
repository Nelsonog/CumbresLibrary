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
   public class StatusItemBook
    {
        [Key]
        public int StatusItemBookId { get; set; }

        

        [Required(ErrorMessage ="The fiel is required.")]
        [MaxLength(20, ErrorMessage ="The fiel {0} only can contains a maximum of {1} characters lenht. ")]
        [Index("Status_Name_Index", IsUnique =true)]
        public string Status_Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<ItemBook> ItemBooks { get; set; }

    }
}
