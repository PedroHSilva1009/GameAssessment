using GameAssessment.Interfaces;
using GameAssessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameAssessment.Controllers;
    [ApiController]
    [Route("user")]
    public class UserController : Controller{
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository){
            _userRepository = userRepository;
        }

        [HttpPost("login")]
        public IActionResult login(User reqBody){
            string email = reqBody.email;
            string userName = reqBody.userName;
            string password = reqBody.password;

            var userFound = _userRepository.get().Where(userDb => (userDb.userName ==  userName || userDb.email == email) 
                                                                   && userDb.password == password )
                                                                   .Select(userDb => new{userDb.userId, userDb.userName, 
                                                                   userDb.nickName, userDb.acessLevel});

            if(userFound.Count()<=0){
                 return NotFound("User not found, verify user name or password");
             }

            return Ok(userFound);
        }

        [HttpPost("register")]
        public IActionResult register(User reqBody){
            User userReq = new(Guid.NewGuid().ToString(), reqBody.nickName, reqBody.userName, reqBody.email, 
                                reqBody.password, 0);

            var userFound = _userRepository.get().Where(userDb => userDb.userName == userReq.userName);

            if(userFound.Count()>0){
                return BadRequest("This username is already in use, please use another");
            }

            _userRepository.register(userReq);

            return Ok("User successfully registered");
        }

        [HttpGet("{userName}")]
        public IActionResult findUserByUserName(){
            string userName = HttpContext.Request.RouteValues["userName"].ToString();

            var userFound = _userRepository.get().Where(userDb => userDb.userName == userName);

            if(userFound.Count()<=0){
                return NotFound("User not found");
            }

            return Ok(userFound);
        }

        [HttpGet]
        public IActionResult getAllUsers(){
            var usersFound = _userRepository.get();

             if(usersFound.Count()<=0){
                return NotFound("No registered users");
            }

            return Ok(usersFound);
        }

        [HttpDelete("{userId}")]
        public IActionResult deleteUser(){
            string userId = HttpContext.Request.RouteValues["userId"].ToString();
            var userFound = _userRepository.get().Where(userDb => userDb.userId == userId).ToList();

            if(userFound.Count()<=0){
                return NotFound("This user does not exist");
            }

            var userDelete = userFound[0];

            _userRepository.delete(userDelete);

            return Ok("User deleted");
        }
    }