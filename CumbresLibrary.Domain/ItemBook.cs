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
    public class ItemBook
    {

        [Key]
        public int ItemBookId { get; set; }


        [Required (ErrorMessage ="The fiel {0} is required.")]
        [MaxLength(5, ErrorMessage ="The fiel {0} only can contains a maximum of {1} characters lenght.")]
        [Index("Book_Code_Index", IsUnique=true)]
        public int Book_Code { get; set; }



        public int BookId { get; set; }
        [JsonIgnore]
        public virtual Book Book { get; set; }


        public int StatusItemBookId { get; set; }
        [JsonIgnore]
        public virtual StatusItemBook StatusItemBook { get; set; }

        [JsonIgnore]
        public virtual ICollection<Operation> Operations { get; set; }




    }
}
