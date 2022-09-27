using System;
using System.ComponentModel.DataAnnotations;

namespace api_purdelivery
{
    public class T_PU_Abnormal
    {
        public int ID { get; set; }
        public string subject { get; set; }
        public string req_no { get; set; }
        public string req_details_no { get; set; }
        public string order_company_code { get; set; }
        public string order_wdw_code { get; set; }
        public string pur_incharge { get; set; }
        public string item_desc { get; set; }
        public string maker_code { get; set; }
        public string maker_name { get; set; }
        public string type { get; set; }
        public string pur_req_qty { get; set; }
        public string unit   { get; set; }
        public string ship_to { get; set; }
        public string status { get; set; }
        public string date_passed_after_reception { get; set; }
        public string receive_date_pur_req { get; set; }
        public string req_delivery_date { get; set; }
        public string action { get; set; }
        public DateTime? upd_dt { get; set; } 
        public string upd_by { get; set; } 
        public string input_by { get; set; }
        public DateTime? input_dt { get; set; }     
    }
}