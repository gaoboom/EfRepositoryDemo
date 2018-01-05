using Domain.CoreModels;
using Domain.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.BusinessLogic
{
    public class UserBusinessLogic
    {
        //私有变量定义部分，有用到其它的仓储就在这里定义
        private readonly IUserRepository _userRepository;

        //构造函数部分，实例化时将仓储上下文置入
        public UserBusinessLogic(IRepositoryContext repositoryContext,IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //业务逻辑部分

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
    }
}