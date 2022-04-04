using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok.Data.DbContext.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string VideoUrl { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public string SongName { get; set; }
        public string ProfileImg { get; set; }
        public int Like { get; set; }
        public int Comment { get; set; }
        public int Share { get; set; }

    }
}
