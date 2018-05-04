using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CumbresLibrary.Backend.Models
{
    using CumbresLibrary.Domain;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<CumbresLibrary.Domain.User> Users { get; set; }

        public System.Data.Entity.DbSet<CumbresLibrary.Domain.UserType> UserTypes { get; set; }
    }
}