using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok.Model.UserModel
{
    public class UserVideo
    {
        public int Id { get; set; }
        public string VideoUrl { get; set; }
        public string Caption { get; set; }
        public string SongName { get; set; }
        public int Share { get; set; }
        public int Like { get; set; }
        public int Comment { get; set; }

    }
}
