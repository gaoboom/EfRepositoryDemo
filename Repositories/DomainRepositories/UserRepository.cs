using Domain.CoreModels;
using Domain.RepositoryInterface;
using Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.DomainRepositories
{
    public class UserRepository : EfRepo<User>, IUserRepository
    {
        //私有变量定义部分，如果该仓储需要用到其它仓储，则在此处定义

        //构造函数，上述的私有变量需要在构造函数中赋值
        public UserRepository(IRepositoryContext context) : base(context)
        {
        }

        //业务逻辑部分
        public List<User> GetAllUsers()
        {
            List<User> userList = GetAll().ToList();
            return userList;
        }
    }
}
