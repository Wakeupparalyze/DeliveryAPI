using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Delivery;
using Microsoft.EntityFrameworkCore;
using DeliveryAPI.DTO;

namespace DeliveryAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly User02Context _context;

        public UserController(User02Context context)
        {
            _context = context;
        }
        [HttpPost("UserLogin")]
        public ActionResult<UserDTO> UserLogin(LoginUser loginUser)
        {

            User user = _context.Users.Include(s => s.Role).FirstOrDefault(a => a.Login == loginUser.Login && a.Password == loginUser.Password);
            if (user != null)
            {
                return new UserDTO
                {
                    Id = user.Id,
                    Login = user.Login,
                    Password = user.Password,
                    Name = user.Name,
                    Lastname = user.Lastname,
                    RoleId = user.RoleId,
                    CreatedAt = user.CreatedAt,
                    UpdatedAt = user.UpdatedAt,
                    Role = user.Role.Title
                };
            }
            else
            {
                return BadRequest("Неправильный логин или пароль");
            }

        }
    }
}
