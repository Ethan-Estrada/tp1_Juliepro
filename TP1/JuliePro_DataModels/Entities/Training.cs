using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuliePro_DataModels.Entities
{
    public class Training
    {
        public int Id { get; set; }
        [StringLength(30, MinimumLength = 5)]
        public string Name { get; set; }
        [StringLength(25, MinimumLength = 10)]
        public string Category { get; set; }
    }
}
