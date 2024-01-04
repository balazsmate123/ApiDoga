using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace User.Models
{
    public class BankAccounts
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public int? Balance{ get; set; }
        [Column(TypeName = "varchar(30)")]
        public int? Numbers { get; set; }
        public Guid UsersId { get; set; }
        public Users Users { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
