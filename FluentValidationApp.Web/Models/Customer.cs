namespace FluentValidationApp.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        // Do want use for this way Customer.Address[1].Name Use IList interface
        public IList<Address> Address { get; set; }
        public Gender Gender { get; set; }
        public CreditCard CreditCard { get; set; }
        public string GetFullName()
        {
            return $"{Name}-{Email}-{Age}";
        }
    }
}
