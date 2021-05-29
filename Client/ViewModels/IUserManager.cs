using ChorriSaludService.Shared.Models;
using System;
using System.Threading.Tasks;

namespace ChorriSaludService.Client.ViewModels
{
    public interface IUserManager
    {
        public delegate void CallBack();
        //Obtiene un User  y realiza operaciones
        //login, logout, get user , update user
        public Task LoginUser(User user, Action action);
        public Task LogOutUser(Action action);
        public Task<object> GetUser(long id);
        public Task UpdateUser(User user,Action action);
        public Task UpdateUser(User user);
        public Task AddUser(User user,Action action);

    }
}