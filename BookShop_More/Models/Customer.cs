using BookShop_More.Interfaces;

namespace BookShop_More.Models;

public class Customers : ICustomers
{
    public int Id { get; set; }
    public bool? MembershipStatus { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Address { get; set; } = null!;
}
