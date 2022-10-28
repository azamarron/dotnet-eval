using dotnet_eval.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_eval.Services.UserServices
{
    public class UserService:IUserService
    {
        private static List<User> UserList = new List<User>();

        public void AddUser(User newUser)
        {
            newUser.Id = UserList.Count + 1;
            UserList.Add(newUser);
        }

        public List<User> GetUser(int id)
        {
            return UserList;
        }

        public void UpdateUser(User userToUpdate)
        {
            User userUpdated = new User();
            foreach (User user in UserList)
            {
                if (user.Id == userToUpdate.Id)
                {
                    user.Name = userToUpdate.Name;
                    user.Email = userToUpdate.Email;
                    user.Phone = userToUpdate.Phone;
                    user.Kind = userToUpdate.Kind;
                    userUpdated = user;
                }
            }
        }

        public void UpdateUserKind(int id, UserKind kind)
        {
            User itemUpdated = new User();
            foreach (User user in UserList)
            {
                if (user.Id == id)
                {
                    user.Kind = kind;
                }
            }
        }

    }
}