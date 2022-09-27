using System;
using System.ComponentModel.DataAnnotations;


namespace api_purdelivery
{
    public class T_Delay_Oversea
    {
        public int ID { get; set; }
        public string subject { get; set; }
        public string status { get; set; }
        public string po_number { get; set; }
        public string po_line_number { get; set; }
        public string po_shipm_number { get; set; }
        public string req_no { get; set; }
        public string req_details_no { get; set; }
        public string order_company_code { get; set; }
        public string order_company_name { get; set; }
        public string pur_incharge { get; set; }
        public string buyer_pic_company_name { get; set; }
        public string buyer_pic_belong_name { get; set; }
        public string buyer_pic_telephone { get; set; }
        public string buyer_pic_mailddress { get; set; }
        public string supplier { get; set; }
        public string supplier_site { get; set; }
        public string item_desc { get; set; }
        public string maker_code { get; set; }
        public string maker_name { get; set; }
        public string type { get; set; }
        public string price { get; set; }
        public string currency { get; set; }
        public string pur_order_qty { get; set; }
        public string delivery_qty { get; set; }
        public string delivery_balanced_qty { get; set; }
        public string balanced_order_qty { get; set; }
        public string unit   { get; set; }
        public string inspectionyn { get; set; }
        public string inspection_dept { get; set; }
        public string remark_risk_degree { get; set; }
        public string order_date { get; set; }
        public string req_shipping_date { get; set; }
        public string promised_date { get; set; }
        public string today { get; set; }
        public string delay { get; set; }
        public string resp_suppliercpt { get; set; }
        public string remark_and_reason { get; set; }
        public string transportation { get; set; }
        public string requisitioner { get; set; }
        public string request_company { get; set; }
        public string request_dept { get; set; }
        public string requester_telephone { get; set; }
        public string request_email { get; set; }
        public string remarks { get; set; }
        public DateTime? upd_dt { get; set; } 
        public string upd_by { get; set; } 
        public string input_by { get; set; }
        public DateTime? input_dt { get; set; } 
    }
}