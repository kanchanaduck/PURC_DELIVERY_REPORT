using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_purdelivery
{
    public class T_KPI
    {
        public int year { get; set; }
        [DataType(DataType.Date)]
        public string monthly { get; set; }
        public string dept { get; set; }
        [Display(Name = "KPI")]
        [Range(0, 100.00)]
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? kpi { get; set; }
        public DateTime? created_dt { get; set; } 
        public string created_by { get; set; }  
        public DateTime? updated_dt { get; set; } 
        public string updated_by { get; set; }     
    }
}