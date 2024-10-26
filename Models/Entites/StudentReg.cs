using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentRegistration.Core.Models.Entites
{
    public class StudentReg
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "Varchar(30)")]
        public string StudentName { get; set; }

        public int Age { get; set; }

        [Column(TypeName = "Varchar(30)")]
        public string Email { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string MobileNumber { get; set; }

        [Column(TypeName = "Varchar(30)")]
        public string Country { get; set; }

        [Column(TypeName = "Varchar(30)")]
        public string State { get; set; }

        [Column(TypeName = "Varchar(30)")]
        public string City { get; set; }

        [Column(TypeName = "Varchar(300)")]
        public string Address { get; set; }
    }
}
