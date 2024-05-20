namespace TechTrove.DAL.Entities
{
    public class TechTroveCategory : Entity
    {
        public string Name { get; set; }
        public ICollection<TechTroveProduct> TechTroveProducts { get; set; }
    }
}
