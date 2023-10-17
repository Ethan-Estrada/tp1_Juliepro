using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuliePro_DataModels.Entities
{
    public class Equipment
    {
        public int Id { get; set; }
        [StringLength(45, MinimumLength = 5)]
        public string Name { get; set; }
    }
}
