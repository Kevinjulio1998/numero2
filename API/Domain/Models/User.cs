using Microsoft.AspNetCore.Identity;
using System;

namespace Domain.Models
{
    public class User : IdentityUser<Guid>
    {

        public int TypeDocumentId { get; set; }

        public string Document { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public TypeDocument TypeDocument { get; set; }
    }
}
