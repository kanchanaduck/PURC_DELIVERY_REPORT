using System;
using System.ComponentModel.DataAnnotations;

namespace api_purdelivery
{
    public class T_Control_Evalio
    {
        public int ID { get; set; }
        public string subject { get; set; }
        public string pr_no { get; set; }
        public string po_no { get; set; }
        public string issuedate { get; set; }
        public string delivery_date { get; set; }
        public string today { get; set; }
        public string delay { get; set; }
        public string lt { get; set; }
        public string resp_suppliercpt { get; set; }
        public string remark_and_reason { get; set; }
        public string no { get; set; }
        public string item { get; set; }
        public string item_name { get; set; }
        public string quantity { get; set; }
        public string received { get; set; }
        public string remain { get; set; }
        public string unit { get; set; }
        public string unit_price { get; set; }
        public string currency { get; set; }
        public string vendor_code { get; set; }
        public string vendor_name { get; set; }
        public string prepareby { get; set; }
        public string center_code { get; set; }
        public string center_name { get; set; }
        public string expense_code { get; set; }
        public string equipment_budget_code { get; set; }
        public DateTime? upd_dt { get; set; } 
        public string upd_by { get; set; } 
        public string input_by { get; set; }
        public DateTime? input_dt { get; set; } 
    }
}