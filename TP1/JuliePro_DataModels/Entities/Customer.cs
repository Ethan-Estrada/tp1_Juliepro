using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuliePro_DataModels.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(45, MinimumLength = 3)]
        public string FirstName { get; set; }
        [StringLength(45, MinimumLength = 3)]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string AuthorEmail { get; set; }
        [StringLength(40)]
        public string Photo { get; set; }
        public DateTime BirthDate { get; set; }
        [Range(100,400)]
        public Double StartWeight { get; set; }
        [ForeignKey("Trainer_Id")]
        public int Trainer_Id { get; set; }
        [ForeignKey("ScheduledSession_Id")]
        public int ScheduledSession_Id { get; set; }
    }
}
