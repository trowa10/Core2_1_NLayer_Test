using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS.DOMAIN
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string Gender { get; set; }
        [Column(TypeName = "dateTime")]
        public DateTime DateOfBirth { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Email { get; set; }     
    }
}
