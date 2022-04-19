using BD.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD.Controller
{
    public class UsersRepository : IUsersRepository
    {
        bool IUsersRepository.Delete(string id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Users> IUsersRepository.GetUsers()
        {
            //SqlConnection sqlConnection = new SqlConnection(AppConection.ConnectionString);
            //sqlConnection.Open();
            IDbConnection db = new SqlConnection(AppConection.ConnectionString); ;
            if(db.State==ConnectionState.Closed)
                db.Open();
            return db.Query<Users>("select ID,E_Mail,Parol", commandType: CommandType.Text);
        }

        bool IUsersRepository.Insert(Users users)
        {
            throw new NotImplementedException();
        }

        bool IUsersRepository.Update(Users users)
        {
            throw new NotImplementedException();
        }
    }
}
