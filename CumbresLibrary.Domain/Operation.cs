using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumbresLibrary.Domain
{
    public class Operation
    {
        [Key]
        public int OperationId { get; set; }

        public int temBookId { get; set; }
        [JsonIgnore]
        public virtual ItemBook ItemBook { get; set; }


        [Display(Name = "Client")]
        public int ClientId { get; set; }

        [Display(Name = "Receptor")]
        public int ReceptorId { get; set; }

        [JsonIgnore]
        public virtual User Client { get; set; }

        [JsonIgnore]
        public virtual User Receptor { get; set; }


        [Display(Name = "Date time")]
        [DataType(DataType.DateTime)]
        public DateTime DateTime { get; set; }


        [Required(ErrorMessage = "The fiel is required.")]
        [Display(Name = "Start")]
        [DataType(DataType.Date)]
        public DateTime Start { get; set; }


        [Display(Name = "Finish")]
        [DataType(DataType.Date)]
        public DateTime Finish { get; set; }


        [Display(Name = "Returned")]
        [DataType(DataType.Date)]
        public DateTime Returned { get; set; }



        [Display(Name = "Reserved")]
        //[MaxLength(1, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public int Reserved { get; set; }


    }
}
