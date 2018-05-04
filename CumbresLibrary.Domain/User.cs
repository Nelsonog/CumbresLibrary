﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CumbresLibrary.Domain
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "The field {0} is requiered.")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "The field {0} is requiered.")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field {0} is requiered.")]
        [MaxLength(100, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        [Index("User_Email_Index", IsUnique = true)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Student`s Code")]
        [Required(ErrorMessage = "The field {0} is requiered.")]
        [MaxLength(20, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        [Index("User_Codigo_Index", IsUnique = true)]        
        public string Code { get; set; }

        [MaxLength(20, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        public int UserTypeId { get; set; }

        [JsonIgnore]
        public virtual UserType UserType { get; set; }

        [NotMapped]
        public byte[] ImageArray { get; set; }

        [NotMapped]
        public string Password { get; set; }

        [JsonIgnore]
        public virtual ICollection<Operation> Clients { get; set; }

        [JsonIgnore]
        public virtual ICollection<Operation> Receptors { get; set; }

        //[Display(Name = "Image")]
        //public string ImageFullPath
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(ImagePath))
        //        {
        //            return "noimage";
        //        }

        //        return string.Format(
        //            "http://landsapi1.azurewebsites.net/{0}",
        //            ImagePath.Substring(1));
        //    }
        //}

        [Display(Name = "User")]
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        //[JsonIgnore]
        //public virtual ICollection<Board> Boards { get; set; }

        //[JsonIgnore]
        //public virtual ICollection<Prediction> Predictions { get; set; }
    }
}
