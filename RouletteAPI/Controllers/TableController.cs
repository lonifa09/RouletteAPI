using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RouletteAPI.IRepository;
using RouletteAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RouletteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<TableController> _logger;
        private readonly IMapper _mapper;
        public TableController(IUnitOfWork unitOfWork, ILogger<TableController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> GetTables()
        //{
        //    try
        //    {
        //        var tables = await _unitOfWork.Tables.GetAll();
        //        var results = _mapper.Map<IList<TableDTO>>(tables);
        //        return Ok(results);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Something went wrong in the {nameof(GetTables)}");
        //        return StatusCode(500, "Internal Server Error, Please Try Again Later");
        //    }
        //}

        //[HttpGet("{id:int}")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> GetTable(int id)
        //{
        //    try
        //    {
        //        var table = await _unitOfWork.Tables.Get(c => c.TableId == id, new List<string> { "Bets" });
        //        var result = _mapper.Map<TableDTO>(table);
        //        return Ok(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, $"Something went wrong in the {nameof(GetTable)}");
        //        return StatusCode(500, "Internal Server Error, Please Try Again Later");
        //    }
        //}
    }
}
