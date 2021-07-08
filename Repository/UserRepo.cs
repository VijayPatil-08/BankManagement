using BankManagmentSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankManagmentSystem.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly UserDbContext _userDbContext;

        public  UserRepo(UserDbContext context)
        {
            _userDbContext = context;
        }

        public string AddUserDetails(User entity)
        {
            _userDbContext.Users.Add(entity);

            _userDbContext.SaveChanges();
            return ("Customer Added");
        }

        public User AuthenticateUser(string username, string password)
        {
            try
            {
                User member = GetMember(username, password);
                return member;
            }
            catch (Exception e)
            {
                return new User();
            }
        }

        public User GetUserDetails(string id)
        {

            return _userDbContext.Users.FirstOrDefault(x => x.UserId == id);

        }

        public string UpdateUserDetails(string id, User user)
        {
            _userDbContext.Entry(user).State = EntityState.Modified;
            
            _userDbContext.SaveChanges(); //to save changes in database
           
            return ("Customer Updated");

        }
        private User GetMember(string username, string password)
        {
            return _userDbContext.Users.First(u => u.username == username && u.password == password);
        }

    }
}
