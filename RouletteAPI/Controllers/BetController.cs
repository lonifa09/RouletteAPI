using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouletteAPI.Data;
using RouletteAPI.IRepository;
using RouletteAPI.Models;
using System;
using System.Collections.Generic;
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


        [HttpGet("{id:int}", Name = "GetBet")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBet(int id)
        {
            try
            {
                var bet = await _unitOfWork.Bets.GetAll(c => c.PlayerId == id);//, new List<string> { "Bets" });
                var result = _mapper.Map<IList<BetDTO>>(bet);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetBet)}");
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }
        }

        //[Authorize]
        [HttpPost(Name = "PlaceBet")]
        public async Task<IActionResult> PlaceBet([FromBody] CreateBetDTO betDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogInformation($"Invalid request {nameof(PlaceBet)}");
                return BadRequest(ModelState);
            }
            try
            {
                var bet = _mapper.Map<Bet>(betDTO);
                await _unitOfWork.Bets.Insert(bet);
                await _unitOfWork.Save();

                //return CreatedAtRoute("GetBet", new { id = bet.PlayerId});
                return Ok($"Successfully inserted {nameof(PlaceBet)}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(PlaceBet)}");
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }
        }
    }
}
