using BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Controller
{
    public interface IUsersRepository
    {
        IEnumerable<Users> GetUsers();
        bool Insert(Users users);
        bool Update(Users users);
        bool Delete(string id);

    }
}
