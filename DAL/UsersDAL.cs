using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Dapper;

namespace DAL
{
    public class UsersDAL
    {
        public static List<Users> FetchList()
        {
            string sql = "SELECT [Id], [Username], [Password], [FirstName], [LastName] FROM [Users]";
            using (var con = ConnectionUtil.GetConnection())
            {
                return con.Query<Users>(sql).ToList();
            }
        }
    }
}
