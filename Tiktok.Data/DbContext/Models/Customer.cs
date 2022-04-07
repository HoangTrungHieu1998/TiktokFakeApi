using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok.Data.DbContext.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public string CustomerImg { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public virtual ICollection<Video> Video { get; set; }
        public virtual ICollection<Like> Like { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<Follow> Follow { get; set; }
    }
}
