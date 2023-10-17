using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuliePro_DataModels.Entities
{
    public class ScheduledSession
    {
        public int Id { get; set; }
        [StringLength(35, MinimumLength = 10)]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Range(20, 90)]
        public int DurationMin { get; set; }
        public bool WithTrainer { get; set; }
        public bool Complete { get; set; }
        [ForeignKey("Training_Id")]
        public int Training_Id { get; set; }
    }
}
