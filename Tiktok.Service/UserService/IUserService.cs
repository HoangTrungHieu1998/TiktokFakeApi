using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tiktok.Data.DbContext.Models;
using Tiktok.Model.UserModel;

namespace Tiktok.Service.UserService
{
    public interface IUserService
    {
        Task<IEnumerable<Data.DbContext.Models.User>> GetUsers();
        Task<Profile> GetProfile(int id);
        Task<IEnumerable<Videos>> GetAllVideos();
    }
}
