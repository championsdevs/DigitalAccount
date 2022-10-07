namespace Domain.Entities
{
    public class Customer
    {
        public Customer(string name, string email, string document)
        {
            Name = name;
            Email = email;
            Document = document;
        } 

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Document { get; private set; }
    }
}
