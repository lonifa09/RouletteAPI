using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouletteAPI.Data;
using RouletteAPI.IRepository;
using RouletteAPI.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RouletteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApiUser> _useManager;
        //private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;
        public AccountController(UserManager<ApiUser> userManager,
            //SignInManager<Player> signInManager,
            IUnitOfWork unitOfWork, 
            ILogger<AccountController> logger, 
            IMapper mapper)
        {
            _useManager= userManager;
            //_unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        //[HttpPost]
        //[Route("register")]
        //public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
        //{
        //    _logger.LogInformation($"Registration attempt for {userDTO.Email}");
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    try
        //    {
        //        var user = _mapper.Map<ApiUser>(userDTO);
        //        user.UserName = userDTO.Email;
        //        var result = await _useManager.CreateAsync(user);

        //        if (!result.Succeeded) 
        //        {
        //            foreach (var error in result.Errors)
        //            {
        //                ModelState.AddModelError(error.Code, error.Description);
        //            }
        //            return BadRequest($"User Registration Attempt Failed");
        //        }

        //        await _useManager.AddToRoleAsync(user, userDTO.Roles.FirstOrDefault().Name);
        //        return Accepted();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Something went wrong in the {nameof(Register)}");
        //        return StatusCode(500, "Internal Server Error, Please Try Again Later");

        //    }
        //}

        //[HttpPost]
        //[Route("login")]
        //public async Task<IActionResult> Login([FromBody] LoginUserDTO userDTO)
        //{
        //    _logger.LogInformation($"Login attempt for {userDTO.Email}");
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    try
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(userDTO.Email, userDTO.Password, false, false);

        //        if (!result.Succeeded)
        //        {
        //            return Unauthorized(userDTO);
        //        }

        //        return Accepted();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Something went wrong in the {nameof(Register)}");
        //        return StatusCode(500, "Internal Server Error, Please Try Again Later");

        //    }
        //}
    }
}
