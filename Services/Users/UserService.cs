using Services.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;
using Models;
using ViewModel.Exestention_Methods;
using Microsoft.AspNetCore.Identity;

namespace Services.Users
{
    public class UserService : IUserService
    {
        private readonly Irepository<User> UserRepo;
        UserManager<User> UserManager;
        UserService(Irepository<User> userRepo, Irepository<Transaction> brokerrepo, UserManager<User> userManager)
        {
            UserRepo = userRepo;
            UserManager = userManager;
        }

        public bool AddUser(AddUserVM UserVM)
        {
            UserRepo.Add(UserVM.UserVM_User());
            return true;

         }

        public IEnumerable<GetuserdataVM> GetUsers()
        {
         return  UserRepo.GetAll().Select(w => w.GetUserDatatoVM());
        }

        public  async  Task<string> Login(LoginUserVM loginuser)
        {
            var res=UserRepo.Find(u=>u.Mobile==loginuser.mobile);
            if (res == null)
            {
                return "";
            }
            if (await UserManager.CheckPasswordAsync(res, loginuser.passwrod))
            {
                return "Success";
            }
            return "";

        }
    }
}
