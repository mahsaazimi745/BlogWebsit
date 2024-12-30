using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Blog.DataLayer.Entities
{
    public class PostComment
    {
        [Key]
        public int Id { get; set; }
       // public int UserId { get; set; }
        public int RoleId { get; set; }
        public int PostId { get; set; }
        [Required]

        public string Text { get; set; }

        [ForeignKey("Post")]
        public Post Post { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }


    }
}
