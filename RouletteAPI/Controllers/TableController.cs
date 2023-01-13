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

        [HttpGet]
        public async Task<IActionResult> GetTables()
        {
            try
            {
                var tables = await _unitOfWork.Tables.GetAll();
                var result = _mapper.Map<IList<TableDTO>>(tables);
                return Ok(tables);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetTables)}");
                return StatusCode(500, "Internal Server Error, Please Try Again Later");
            }
        }
    }
}
