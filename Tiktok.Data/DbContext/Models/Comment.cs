using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok.Data.DbContext.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int VideoId { get; set; }
        public int CustomerId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int CommentLike { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Video Video { get; set; }
        public virtual ICollection<CommentChild> CommentChild { get; set; }

    }
}
