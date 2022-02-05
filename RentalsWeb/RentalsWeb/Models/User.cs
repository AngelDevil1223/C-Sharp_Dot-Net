using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliaksandrWeb.Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
        }
        public Guid Id { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
