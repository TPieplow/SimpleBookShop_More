namespace BookShop_More.Interfaces
{
    public interface ICustomers
    {
        string Address { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        int Id { get; set; }
        string LastName { get; set; }
        bool? MembershipStatus { get; set; }
        string Phone { get; set; }
    }
}

