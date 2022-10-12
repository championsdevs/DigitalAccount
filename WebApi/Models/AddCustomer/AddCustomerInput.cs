namespace WebApi.Models.AddCustomer
{
    public class AddCustomerInput
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;

        public bool IsValid()
        {
            return Name != string.Empty &&
                Email != string.Empty && Email.Contains("@") && Email.Contains(".") &&
                Document != string.Empty;
        }
    }
}
