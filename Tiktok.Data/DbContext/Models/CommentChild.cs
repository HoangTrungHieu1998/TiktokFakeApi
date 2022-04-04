using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok.Data.DbContext.Models
{
    public partial class CommentChild
    {
        public int CommentChildId { get; set; }
        public int CommentId { get; set; }
        public string ChildContent { get; set; }
        public DateTime Date { get; set; }
        public int CommentChildLike { get; set; }
        public virtual Comment Comment { get; set; }
    }
}
