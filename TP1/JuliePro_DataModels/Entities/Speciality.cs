using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuliePro_DataModels.Entities
{
    public class Speciality
    {
        public int Id { get; set; }
        [StringLength(35, MinimumLength = 5)]
        public string Name { get; set; }

        public virtual List<Trainer> Trainers { get; set; } = new List<Trainer>();

    }
}
