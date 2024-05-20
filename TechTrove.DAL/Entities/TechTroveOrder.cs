using System.ComponentModel.DataAnnotations.Schema;

namespace TechTrove.DAL.Entities
{
    public class TechTroveOrder : Entity
    {
        [ForeignKey("TechTroveUserId")]
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public int TechTroveUserId { get; set; }
        public TechTroveUser TechTroveUser { get; set; }
        public ICollection<TechTroveOrderLine> TechTroveOrderLines { get; set; }
    }
}
