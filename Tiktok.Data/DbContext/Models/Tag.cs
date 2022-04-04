using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok.Data.DbContext.Models
{
    public partial class Tag
    {
        public int TagId { get; set; }
        public string TagContent { get; set; }
        public virtual Video Video { get; set; }
    }
}
