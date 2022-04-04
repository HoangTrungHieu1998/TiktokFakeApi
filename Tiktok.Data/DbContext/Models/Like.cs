using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok.Data.DbContext.Models
{
    public partial class Like
    {
        public int LikeId { get; set; }
        public int VideoId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Video Video { get; set; }
    }
}
