using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok.Data.DbContext.Models
{
    public partial class Follow
    {
        public int FollowId { get; set; }
        public int CustomerFollowId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
