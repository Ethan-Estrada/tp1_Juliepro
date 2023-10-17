using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuliePro_DataModels.Entities
{
    public class Objective
    {
        public int Id { get; set; }
        [StringLength(15, MinimumLength = 5)]
        public string Name { get; set; }
        [Range(2,10)]
        public double LostWeight { get; set; }
        [Range(2,45)]
        public Double DistanceKm { get; set; }
        public DateTime AchievedDate { get; set; }
        [ForeignKey("Customer_Id")]
        public int Customer_Id { get; set; }
    }
}
