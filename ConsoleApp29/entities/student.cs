using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29.entities
{
    [Table("student",Schema ="dbo")]
    internal class student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        [StringLength(50, MinimumLength = 10)]
        public required string  fname { get; set; }//[required] attribute in database
        //required keyword at application
        public string ?lname { get; set; }
        public int ?age { get; set; }
        public string? address { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string? email { get; set; }
        [Phone]

        public string? phonenumber { get; set; }
        [PasswordPropertyText]
        [NotMapped]
        public string? password { get; set; }
    }
}
