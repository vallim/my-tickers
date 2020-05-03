using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using my_tickers.Domains;
using my_tickers.Services.Contracts;

namespace my_tickers.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class TickersController : ControllerBase
    {
        private readonly ITickersService _tickersService;

        public TickersController(ITickersService tickersService)
        {
            _tickersService = tickersService;
        }

        [HttpGet]
        public ActionResult<List<Ticker>> GetAll()
        {
            var tickers = _tickersService.GetAll();
            
            return Ok(tickers);
        }
    }
}