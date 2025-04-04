using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DataLayer.Models;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BinaApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _configuration;

        public AcountController(UserManager<User> userManager, RoleManager<Role> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] Register model)
        {

           
            var user = new User();
            user.UserName = model.UserName;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Password = model.Password;    
            user.Email = model.Email;

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return Ok(new { message = "User registered succesfully" });
            }
            return BadRequest(result.Errors);

            if(await _roleManager.RoleExistsAsync("User"))
            {
                await _userManager.AddToRoleAsync(user, "User");
            }
            return Ok("Qeydiyyat ugurla tamamlandi");
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] Login model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub,user.UserName!),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                };
                authClaims.AddRange(userRoles.Select(role => new Claim(ClaimTypes.Role, role)));
                var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    expires: DateTime.Now.AddMinutes(double.Parse(_configuration["Jwt:ExpiryMinutes"]!)),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!)),
                    SecurityAlgorithms.HmacSha256
                    )
                 );
                return Ok(new { Token = new JwtSecurityTokenHandler().WriteToken(token) });
            }
            return Unauthorized();
        }
        [HttpPost("add-role")]
        public async Task<IActionResult> AddRole([FromBody] string role)
        {
            if(!await _roleManager.RoleExistsAsync(role))
            {
                var result = await _roleManager.CreateAsync(new Role());

                if (result.Succeeded)
                {
                    return Ok(new { message = "Role added succesfully" });
                }
                return BadRequest(result.Errors);
            }
            return BadRequest("Role alredy exists");
        }
        [HttpPost("assign-role")]
        public async Task<IActionResult> AssignRole([FromBody] User model)
        {
            var user = await _userManager.FindByNameAsync(model.FirstName);

            if (user == null)
            {
                return BadRequest("User not found");
            }

            var result = await _userManager.AddToRoleAsync(user, "User");

            if (result.Succeeded)
            {
                return Ok(new { message = "Role assigned succesfully" });
            }
            return BadRequest(result.Errors);
        }
    }
}
