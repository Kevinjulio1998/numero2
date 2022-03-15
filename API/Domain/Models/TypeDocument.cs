using System.Collections.Generic;

namespace Domain.Models
{
    public class TypeDocument
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
