using System.ComponentModel.DataAnnotations.Schema;
using TechTrove.DAL.Constants;

namespace TechTrove.DAL.Entities
{
    public class TechTroveCart : Entity
    {
        [ForeignKey("TechTroveUserId")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public CartEnum CartStatus { get; set; }
        public int TechTroveUserId { get; set; }
        public TechTroveUser TechTroveUser { get; set; }
        public ICollection<TechTroveCartItem> TechTroveCartItems { get; set; }
    }
}
