﻿using LearningExperience.Models;
using LearningExperience.Models.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LearningExperience.Services
{
    public interface IUserService
    {
        Task AddUser(AuthenticateUserDTO user);
        IEnumerable<User> GetAll();
        Task RemoveUser(AuthenticateUserDTO user);
        Task UpdateUser(AuthenticateUserDTO user);
        bool ValidateUser(AuthenticateUserDTO user);
        User GetUserByLogin(AuthenticateUserDTO user);
    }
}

