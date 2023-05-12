namespace FluentValidationApp.Web.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string İsim { get; set; }
        public string Eposta { get; set; }
        public int Yaş { get; set; }
        public string FullName { get; set; }
        public string Number { get; set; }
        public DateTime Expiration { get; set; }
    }
}
