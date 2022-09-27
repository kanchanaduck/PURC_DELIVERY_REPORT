using System;
using System.ComponentModel.DataAnnotations;

namespace api_purdelivery
{
    public class T_Reason_Oversea_ShortLT
    {
        public int id { get; set; }
        public string reason { get; set; }
         public string remark { get; set; }
        public DateTime? upd_dt { get; set; } 
        public string upd_by { get; set; } 

    }
}