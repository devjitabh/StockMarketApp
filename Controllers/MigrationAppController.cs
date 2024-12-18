using AonAPI.Data;
using AonAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AonAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MigrationAppController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public MigrationAppController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<StocksUSAColumnar>> GetUSAStocksData()
        {
            var stockData= await _dataContext.StocksUSAColumnar.Select(a => new StocksUSAColumnar
            {
                Id=a.Id,
                Description=a.Description,
                Change=a.Change,               
                Symbol=a.Symbol,
                Cost=a.Cost,
                TotalCost=a.TotalCost
            }).ToListAsync();

            return Ok(stockData);
        }
    }
}
    