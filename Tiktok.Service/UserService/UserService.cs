using Aspose.Html.DataScraping.MultimediaScraping;
using MediaToolkit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiktok.Data.DbContext;
using Tiktok.Data.DbContext.Models;
using Tiktok.Model.UserModel;
using VideoLibrary;

namespace Tiktok.Service.UserService
{
    public class UserService : IUserService
    {
        private readonly AppTiktokContext context;

        public UserService(AppTiktokContext context)
        {
            this.context = context;
            
        }

        public async Task<IEnumerable<Videos>> GetAllVideos()
        {
            var customer = await context.Customer.ToListAsync();
            var videos = await context.Video.ToListAsync();
            var resultLike = await context.Like.ToListAsync();
            var resultComment = await context.Comment.ToListAsync();
            var listVideos = new List<Videos>();

            videos.ForEach(item => {
                listVideos.Add(new Videos
                {
                    VideoUrl = item.VideoUrl,
                    Caption = item.Caption,
                    Id = item.VideoId,
                    SongName = item.SongName,
                    Share = item.Share,
                    Image = customer.FirstOrDefault(e => e.CustomerId == item.CustomerId).CustomerImg,
                    Like = resultLike.Where(i => i.VideoId == item.VideoId).ToList().Count,
                    Comment = resultComment.Where(i=>i.VideoId == item.VideoId).ToList().Count,
                    UserName = customer.FirstOrDefault(e => e.CustomerId == item.CustomerId).UserName,
                });
            });
            return listVideos;
        }

        public async Task<Profile> GetProfile(int id)
        {
            var customer = await context.Customer.ToListAsync();
            var resultLike = await context.Like.ToListAsync();
            var resultFollow = await context.Follow.ToListAsync();
            var videos = await context.Video.ToListAsync();
            var resultComment = await context.Comment.ToListAsync();
            var listProfile = new List<Profile>();
            var listVideos = new List<UserVideo>();

            videos.Where(e => e.CustomerId == id).ToList().ForEach(item => {
                listVideos.Add(new UserVideo
                {
                    VideoUrl = item.VideoUrl,
                    Caption = item.Caption,
                    Id = item.VideoId,
                    SongName = item.SongName,
                    Share = item.Share,
                    Like = resultLike.Where(i => i.VideoId == item.VideoId).ToList().Count,
                    Comment = resultComment.Where(i => i.VideoId == item.VideoId).ToList().Count,
                });
            });

            customer.ForEach(item => {
                var like = resultLike.Where(i => i.CustomerId == item.CustomerId).ToList().Count;
                var follow = resultFollow.Where(i => i.CustomerId == item.CustomerId).ToList().Count;
                listProfile.Add(new Profile
                {
                    Image = item.CustomerImg,
                    Id = item.CustomerId,
                    Name = item.UserName,
                    Description = item.Description,
                    Follow = follow,
                    Like = like,
                    Following = 0,
                    UserVideo = listVideos
                });
            });
            return listProfile.FirstOrDefault(u => u.Id == id);
        }

        public async Task<IEnumerable<Data.DbContext.Models.User>> GetUsers()
        {
            var user = await context.Users.ToListAsync();

            return user;
        }
    }
}
