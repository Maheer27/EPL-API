using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace Services.Users
{
    public interface IUserService
    {
        bool AddUser(AddUserVM UserVM);
        public IEnumerable<GetuserdataVM> GetUsers();
        public Task<string>  Login(LoginUserVM loginuser);


    }
}
