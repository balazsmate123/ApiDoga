using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace User.Models
{
    public class Users
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string? Email { get; set; }
        public DateTime CreatedDate { get; set; }
        
    }
}
