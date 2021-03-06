﻿using LearningExperience.Models;
using LearningExperience.Models.DTO;
using LearningExperience.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace LearningExperience.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUser(AuthenticateUserDTO user)
        {
            if(!VerifyIfUserExists(user))
            await _userRepository.AddUser(user);
        }

        public IEnumerable<User> GetAll()
        {
            var users = _userRepository.GetAll();
            return users;
        }

        public async Task RemoveUser(AuthenticateUserDTO userRemoved)
        {
            await _userRepository.RemoveUser(userRemoved);
        }

        public async Task UpdateUser(AuthenticateUserDTO user)
        {
            await _userRepository.UpdateUser(user);
        }

        public bool ValidateUser(AuthenticateUserDTO user)
        {
            return _userRepository.ValidateUser(user);
        }

        public User GetUserByLogin(AuthenticateUserDTO user)
        {
            return _userRepository.GetUserByLogin(user);
        }

        private bool VerifyIfUserExists(AuthenticateUserDTO user)
        {
            var userAuth = _userRepository.VerifyIfUserExists(user);

            if (userAuth == null)
                return false;

            return true;
        }

    }
}

