namespace TechTrove.DAL.Entities
{
    public class TechTroveUser : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumberConfirmed { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string EmailConfirmed { get; set; }
        public string Role { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<TechTroveOrder> TechTroveOrders { get; set; }
        public virtual TechTroveCart TechTroveCart { get; set; }
    }
}
