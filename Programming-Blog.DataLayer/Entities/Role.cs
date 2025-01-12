using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Blog.DataLayer.Entities
{
    public  class Role : BaseEntity
    {

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [EnumDataType(typeof(UserTitle))]
        public UserTitle RoleTitle { get; set; }

        public enum UserTitle
        {
            Admin,
            User,
            Author
        }




    }
}
