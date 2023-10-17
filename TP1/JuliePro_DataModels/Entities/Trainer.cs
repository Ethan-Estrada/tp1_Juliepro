using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuliePro_DataModels.Entities
{
    public class Trainer
    {
        public int Id { get; set; }
        [StringLength(45, MinimumLength = 3)]
        public string FirstName { get; set; }
        [StringLength(45, MinimumLength = 3)]
        public string LastName { get; set; }
        public string AuthorEmail { get; set; }
        public string Biographie { get; set; }
        [MaxLength(40)]
        [DataType(DataType.ImageUrl)]
        public string? Photo { get; set; }
        public int Speciality_Id { get; set; }
        [ForeignKey("Speciality_Id")]
        public virtual Speciality? Speciality { get; set; }
        public bool Active { get; set; }

    }
}
