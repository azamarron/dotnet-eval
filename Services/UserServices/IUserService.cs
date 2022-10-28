using dotnet_eval.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_eval.Services.UserServices
{
    public interface IUserService
    {
        void AddUser(User newUser);
        List<User> GetUser(int id);
        void UpdateUser(User userToUpdate);
        public void UpdateUserKind(int id, UserKind kind);
    }
}