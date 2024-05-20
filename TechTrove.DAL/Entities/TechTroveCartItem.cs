using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechTrove.DAL.Entities
{
    public class TechTroveCartItem : Entity
    {
        [ForeignKey("TechTroveCartId")]
        public int TechTroveCartId { get; set; }
        [ForeignKey("TechTroveProductId")]
        public int TechTroveProductId { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public TechTroveCart TechTroveCart { get; set; }
        public TechTroveProduct TechTroveProduct { get; set; }
    }
}
