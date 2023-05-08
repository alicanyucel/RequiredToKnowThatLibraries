namespace FluentValidationApp.Web.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string AddressDetail { get; set; }
        public string Province { get; set; }
        public string PostCode { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
