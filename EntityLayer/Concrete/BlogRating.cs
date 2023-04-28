using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogRating
    {
        public int Id { get; set; }
        public int blogId { get; set; }
        public int blogTotalScore { get; set; }
        public int blogRaytingCount { get; set; }

    }
}
