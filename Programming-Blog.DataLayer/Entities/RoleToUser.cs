using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Blog.DataLayer.Entities
{
    public  class RoleToUser : BaseEntity
    {


        [Required]
        public int UserId { get; set; }

        [Required]
        public int RoleId { get; set; }


    }
}
