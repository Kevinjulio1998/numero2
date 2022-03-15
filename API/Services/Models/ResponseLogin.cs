using System;

namespace Services.Models
{
    public class ResponseLogin
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StatusCode { get; set; }
    }
}
