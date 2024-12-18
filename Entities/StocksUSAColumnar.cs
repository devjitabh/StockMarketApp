using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AonAPI.Entities
{    
    public class StocksUSAColumnar
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Symbol { get; set; }
        public string? EX { get; set; }       
        public DateTime? DATE { get; set; }
        public string? DAYOFWEEK { get; set; }
        [Column("Market CapnNEW")]
        public decimal? MarketCapnNEW { get; set; }
        [Column("%Change")]
        public decimal? Change { get; set; }
        [Column("% In The Money")]
        public decimal? InTheMoney { get; set; }
        [Column("% Out Of The Money")]
        public string?OutOfTheMoney { get; set; }
        [Column("Cost")]
        public decimal? Cost { get; set; }
        [Column("Total Cost")]
        public decimal? TotalCost { get; set; }


    }
}
