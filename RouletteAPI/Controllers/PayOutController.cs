using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouletteAPI.Data;
using RouletteAPI.IRepository;
using RouletteAPI.Models;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;

namespace RouletteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PayOutController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<PayOutController> _logger;
        private readonly IMapper _mapper;
        public PayOutController(IUnitOfWork unitOfWork, ILogger<PayOutController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> PayOuts()
        {
            try
            {
                var bets = await _unitOfWork.Bets.GetAll(c => c.Status == "Win");
                if (bets.Count() != 0)
                {
                    foreach (var item in bets)
                    {
                        PayOut pay = new PayOut()
                        {
                            BetId = item.BetId,
                            PayOutDate = DateTime.Now,
                            Amount = item.Amount,
                            
                        };
                        await _unitOfWork.PayOuts.Insert(pay);
                        await _unitOfWork.Save();

                        var bet = await _unitOfWork.Bets.Get(c => c.BetId == item.BetId);
                        bet.Status = "Paid";
                        _unitOfWork.Bets.Update(bet);
                        await _unitOfWork.Save();
                    }

                    var payOuts = await _unitOfWork.PayOuts.GetAll();
                    var results = _mapper.Map<IList<CreatePayOutDTO>>(payOuts);
                    return Ok(results);
                }
                else
                {
                    return Ok("No PayOuts Made");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(PayOuts)}");
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }
        }
    }
}
