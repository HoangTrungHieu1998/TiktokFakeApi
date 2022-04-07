using System;
using System.Collections.Generic;
using System.Text;

namespace Tiktok.Model.UserModel
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Following { get; set; }
        public int Follow { get; set; }
        public int Like { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string LoginName { get; set; }

        public List<UserVideo> UserVideo { get; set; }
    }
}
