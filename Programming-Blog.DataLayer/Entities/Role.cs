using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Blog.DataLayer.Entities
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public UserTitle RoleTitle { get; set; }
        public enum UserTitle
        { 
            Admin,
            User,
            Author
        }


           

    }
}
