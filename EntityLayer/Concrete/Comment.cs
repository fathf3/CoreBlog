using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string commentUserName { get; set; }
        public string commentTitle { get; set; }
        public string commentContent { get; set; }
        public DateTime commentCreateDate { get; set; }
        public bool commentStatus { get; set; }

        public int blogId { get; set; }
        public Blog blogs { get; set; }

    }
}
