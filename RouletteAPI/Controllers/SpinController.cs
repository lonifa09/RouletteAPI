using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouletteAPI.IRepository;
using RouletteAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RouletteAPI.Data;
using System.Linq;

namespace RouletteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpinController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<SpinController> _logger;
        private readonly IMapper _mapper;
        public SpinController(IUnitOfWork unitOfWork, ILogger<SpinController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Spin()
        {
            try
            {
                //Spin a random number between wheel numbers
                Random rand = new Random();
                int number = rand.Next(0, 38);
                var wheel = await _unitOfWork.Wheels.Get(c => c.Number == number);
                var bets = await _unitOfWork.Bets.GetAll(c => c.Status == "placed");
                if (bets != null)
                {
                    // process bet on spin and update bet staus
                    foreach (var item in bets)
                    {
                        Spin spin = new Spin()
                        { 
                            WheelId = wheel.WheelId,
                            BetId = item.BetId,
                            SpinDate= DateTime.Now
                        };
                        await _unitOfWork.Spins.Insert(spin);
                        await _unitOfWork.Save();

                        var bet = await _unitOfWork.Bets.Get(c => c.BetId == item.BetId);
                        if (number != item.TableId )
                        {
                            item.Amount = item.Amount - item.Amount;
                            bet.Status = "Loss";
                        }
                        else
                        {
                            item.Amount = item.Amount * 2;
                            bet.Status = "Win";
                        }
                        bet.Amount = item.Amount;
                        _unitOfWork.Bets.Update(bet);
                        await _unitOfWork.Save();
                    }
                    var result = _mapper.Map<WheelDTO>(wheel);
                    return Ok($"The Number is {result.Number} and Color {result.Color}");
                }
                else
                {
                    return Ok("No Bets available");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(Spin)}");
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }
        }

        [HttpGet]
        [Route("ShowPreviousSpins")]
        public async Task<IActionResult> GetSpins()
        {
            try
            {
                var spins = await _unitOfWork.Spins.GetAll();
                var results = _mapper.Map<IList<SpinDTO>>(spins);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetSpins)}");
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }
        }
    }
}
