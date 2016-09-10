using System;
using System.Collections.Generic;
using System.Linq;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.DataLayer;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.BusinessLayer.UserModels
{
    public class UserService : BaseService, IUserService
    {
        public UserModel LoggedInUser { get; set; }
        public List<UserModel> Users { get; set; } 

        public UserService(ISampleContext context) : base(context)
        {           
        }

        public UserModel GetUser(int id)
        {
            if (Users == null)
            {
                Users = new List<UserModel>();
                foreach (var user in Context.Users)
                {
                    Users.Add(new UserModel
                    {
                        Id = user.Id,
                        UserName = user.UserName,
                        Password = user.Password
                    });
                }
            }
            if (Users.Any(e => e.Id == id))
            {
                UserModel user = Users.FirstOrDefault(e => e.Id == id);
                return user;
            }
            return null;
        }

        public UserModel GetUser(string username)
        {
            if (Context.Users.Any(e => e.UserName == username))
            {
                UserModel model = new UserModel();
                UserEntity entity = Context.Users.FirstOrDefault(e => e.UserName == username);
                model.Id = entity?.Id;
                model.UserName = entity?.UserName;
                model.Password = entity?.Password;
                return model;
            }
            else
            {
                return null;
            }
        }

        public bool SaveUser(UserModel user)
        {
            if(string.IsNullOrWhiteSpace(user.Password)) return false;
            if(string.IsNullOrWhiteSpace(user.UserName)) return false;
            UserEntity entity = new UserEntity
            {
                UserName = user.UserName,
                Password = PasswordHelper.EncryptPassword(user.Password)
            };
            Context.Users.Add(entity);
            Context.SaveChanges();
            return true;
        }

        public UserModel Login(string username, string password)
        {
            LoggedInUser = Context.Users.Where(e => e.UserName == username).Select(e => new UserModel
            {
                Id = e.Id,
                UserName = e.UserName,
                Password = e.Password
            }).FirstOrDefault();
            if (LoggedInUser == null) return null;
            if (PasswordHelper.CheckPassword(password, LoggedInUser.Password))
            {
                return LoggedInUser;
            }
            LoggedInUser = null;
            return null;
        }
    }
}