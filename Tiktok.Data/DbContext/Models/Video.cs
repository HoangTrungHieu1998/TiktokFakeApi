using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok.Data.DbContext.Models
{
    public partial class Video
    {
        public int VideoId { get; set; }
        public string VideoUrl { get; set; }
        public string Caption { get; set; }
        public string SongName { get; set; }
        public int Share { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Like> Like { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }
    }
}
