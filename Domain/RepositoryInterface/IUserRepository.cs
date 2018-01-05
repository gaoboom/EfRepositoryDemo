﻿using Domain.CoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterface
{
    public interface IUserRepository:IRepository<User>
    {
        List<User> GetAllUsers();
    }
}
