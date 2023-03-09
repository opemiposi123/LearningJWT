using LearningJWT.Implementation.Service;
using LearningJWT.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningJWT.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService; 
        }

        //[Authorize(Roles = "Administrator")]
        [HttpGet("user/create")]
        public IActionResult CreateUser() =>
                  View();

        //[Authorize(Roles = "Administrator")]
        [HttpPost("user/create")]
        public async Task<IActionResult> CreateUser([FromForm] UserModelDto createStudent)
        {
            try
            {
                var response = await _userService.Create(createStudent);
                return RedirectToAction("ViewUser", "User");
            }
            catch
            {
                return Ok(new
                {
                    status = "error",
                    message = "Something happened. Please try again later."
                });
            }

        }

        /// <summary>
        /// [Authorize(Roles = "Administrator")]
        /// </summary>
        /// <returns></returns>
        [HttpGet("student")]
        public async Task<IActionResult> ViewUser()
        {
            var instances =
            await _userService.LoadAllUser();
            return View(instances);
        }
    }
}
