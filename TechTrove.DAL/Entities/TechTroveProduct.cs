using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTrove.DAL.Entities
{
    public class TechTroveProduct : Entity
    {
        [ForeignKey("TechTroveCategoryId")]
        public int TechTroveCategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public TechTroveCartItem TechTroveCartItem { get; set; }
        public TechTroveCategory TechTroveCategory { get; set; }
        public TechTroveOrderLine TechTroveOrderLine { get; set; }
    }
}
