using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouletteAPI.Data;
using RouletteAPI.IRepository;
using System;
using System.Threading.Tasks;

namespace RouletteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger<BetController> _logger;
        private readonly IMapper _mapper;
        public BetController(IUnitOfWork unitOfWork, ILogger<BetController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }


        //[HttpPost]
        //public async Task<IActionResult> PlaceBet()
        //{
        //    try
        //    {

        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Something went wrong in the {nameof(PlaceBet)}");
        //        return StatusCode(500, "Internal Server Error, Please Try Again Later");
        //    }
        //}
    }
}
