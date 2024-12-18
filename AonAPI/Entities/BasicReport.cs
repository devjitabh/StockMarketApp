using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AonAPI.Entities
{
    public class BasicReport
    {
        [Key]
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Symbol { get; set; }
        [Column("%Change")]
        public decimal? Change { get; set; }
        public decimal? Cost { get; set; }
        public decimal? TotalCost { get; set; }

}
}
