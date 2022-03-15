namespace Domain.Models
{
    public class UserSignUpResource
    {
        public int TypeDocumentId { get; set; }

        public string Document { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
