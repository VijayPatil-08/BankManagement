using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BankManagmentSystem.Models;
using BankManagmentSystem.ServiceProvider;


namespace BankManagmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUserService _serviceProvider;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(UsersController));
        public UsersController(IUserService serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        

        // GET: api/Users/5
        [HttpGet("{id}")]
        public IActionResult GetUserDetails(string id)
        {
            _log4net.Info("Customer ID " + id + " Entered For Searching");
            _log4net.Info("Calling GetCustomer method of service from controller");
            var user = _serviceProvider.GetUserDetails(id);

            if (user == null)
            {
                return NotFound();
            }
            _log4net.Info("Returns Customer " + user);
            return Ok(user);
        }



        [HttpPost("Login")]
        public IActionResult AuthenticateUser([FromBody] Login credential)
        {
            string username = credential.username;

            string password = credential.password;
            _log4net.Info("UserName " + username + " and Password " + password + " Entered For Authentication");
            //checks usernname and password
            if (username == null || password == null)
            {
                _log4net.Info("Login failed");
                return BadRequest("Check Username or Password it is Invalid");
            }
            _log4net.Info("Calling AuthenticateUser method of service from controller");
            User user = _serviceProvider.AuthenticateUser(username, password);

            return Ok(user);
        }

        [HttpPost("Register")]
        public IActionResult AddUserDetails([FromBody] User user)
        {
            _log4net.Info(" Entered For Registration");
            if (user == null)
            {
                _log4net.Info("Registration failed");
                return BadRequest("Please enter data");
            }
            else
            {
                _log4net.Info("Calling AddCustomer method of service from controller");
                _serviceProvider.AddUserDetails(user);
                _log4net.Info("Returns Customer " + user);
                return Ok("User Added Successfully");
            }

        }



        //// POST: api/Users
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //Update details
        [HttpPut("{id}")]
        public IActionResult UpdateUserDetails(string id,[FromBody] User user)      //this function is to update user details 
        {
            _log4net.Info("Customer ID " + id + " Entered For Updating user details");
            if (id != user.UserId)
            {
                return BadRequest();
            }
            else
            {
                _log4net.Info("Calling UpdateCustomer method of service from controller");
                _serviceProvider.UpdateUserDetails(id, user);
                _log4net.Info("Customer Updated");
                return Ok("User Details Updated Successfully");
            }
        }

    }
}
