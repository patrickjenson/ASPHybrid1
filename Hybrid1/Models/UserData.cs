using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hybrid1.Models{
    public class UserData{

    }

    [Table("User")] //convention will pluralize table name.
    public class User{
        [Key] //convention will take first *ID* field name to use as key.
        public int Id { get; set; }
        public string UserId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public int? age { get; set; }
        public DateTime lastUpdate { get; set; }
    }

    public class UsersDbContext: DbContext{
        DbSet<User> users { get; set; }

        public System.Data.Entity.DbSet<Hybrid1.Models.User> Users { get; set; }
    }
}
