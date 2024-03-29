using System;
using System.ComponentModel.DataAnnotations;

namespace api_purdelivery
{
    public class T_PO_Issue
    {
        public int ID { get; set; }
        public string subject { get; set; }
        public string item_name { get; set; }
        public string requested_quantity { get; set; }
        public string unit_price { get; set; }
        public string item_code { get; set; }
        public string expense_from { get; set; }
        public string account_code { get; set; }
        public string expense_item { get; set; }
        public string control { get; set; }
        public string unit_order { get; set; }
        public string supplier_code { get; set; }
        public string supplier_name { get; set; }
        public string req_code { get; set; }
        public string req_info { get; set; }
        public string req_email { get; set; }
        public string req_date { get; set; }
        public string approver_info { get; set; }
        public string req_receive_date { get; set; }
        public string order_date { get; set; }
        public string order_number { get; set; }
        public string budget_code { get; set; }
        public string asset_code { get; set; }
        public string usage_at { get; set; }
        public string receive_at { get; set; }
        public string req_due_date { get; set; }
        public string delivery_date { get; set; }
        public string model { get; set; }
        public string inspection_category { get; set; }
        public string approved_req_amount { get; set; }
        public string ordered_quantity { get; set; }
        public string finish_flag { get; set; }
        public string maker_name { get; set; }
        public string contact_person { get; set; }
        public string amount_delivered { get; set; }
        public string ok_amount { get; set; }
        public string ng_amount { get; set; }
        public string cancel_date { get; set; }
        public string temporary_unit_price_flag { get; set; }
        public string temporary_unit_price { get; set; }
        public string standard_unit_price { get; set; }
        public string check { get; set; }
        public string req_unit { get; set; }
        public string req_company_code { get; set; }
        public string ordered_company_code { get; set; }
        public string company_pic_receiving { get; set; }
        public string company_pic_inspection { get; set; }
        public string quotation_no { get; set; }
        public string full_po_no { get; set; }
        public string full_order_no { get; set; }
        public string full_maker_code { get; set; }
        public string full_budget_code { get; set; }
        public string full_buyer_code { get; set; }
        public string chemical_subs_no { get; set; }
        public string unspsc_code { get; set; }
        public string supp_selection_reason_code { get; set; }
        public string unit_price_reason_code { get; set; }
        public string standard_unit_price_code { get; set; }
        public string buyer_name { get; set; }
        public string order_approver1 { get; set; }
        public string order_approver2 { get; set; }
        public string order_approver3 { get; set; }
        public string order_approver4 { get; set; }
        public string pr_approve_date { get; set; }
        public string rfq1 { get; set; }
        public string rfq2 { get; set; }
        public string rfq3 { get; set; }
        public string attached_file_flag { get; set; }
        public string attached_file_name { get; set; }
        public string subcontract_class { get; set; }
        public string order_reason_class { get; set; }
        public string install_adjust_flag { get; set; }
        public string receipt_regis_date { get; set; }
        public string receipt_regis_quantity { get; set; }
        public string receipt_regis_person { get; set; }
        public string approver_msg1 { get; set; }
        public string approver_msg2 { get; set; }
        public string receiving_creat_date { get; set; }
        public string inspec_receive_creat_date { get; set; }
        public string receive_creat_pic { get; set; }
        public string inspec_receive_pic { get; set; }
        public string update_date { get; set; }
        public string update_person { get; set; }
        public string creation_date { get; set; }
        public string creation_person { get; set; }
        public string order_sheet_output_class { get; set; }
        public string dept_incharge_code { get; set; }
        public string currency_code { get; set; }
        public string accounting_month { get; set; }
        public string req_compny_name { get; set; }
        public string ordered_person_name { get; set; }
        public string receive_pic_name { get; set; }
        public string inspec_pic_name { get; set; }
        public string catalog_validity { get; set; }
        public string full_quotation_no { get; set; }
        public string full_quotation_replyno { get; set; }
        public string quotation_req_date { get; set; }
        public string quotation_reply_date { get; set; }
        public string officlal_unitprice_changeplan_date { get; set; }
        public string maximum_unit_price { get; set; }
        public string direct_delivery_class { get; set; }
        public string order_lead_time { get; set; }
        public string supp_comment { get; set; }
        public string inspec_timeday { get; set; }
        public string unit_price_reply_quotation { get; set; }
        public string lead_time_reply_quotation { get; set; }
        public string supp_reply_quotation { get; set; }
        public string order_cheapest_supp_quotation { get; set; }
        public string inspec_creditdebit_approver { get; set; }
        public string delivery_time_flag { get; set; }
        public string order_remain_quantity { get; set; }
        public string risk_level_class { get; set; }
        public string arrival_req_date_plan { get; set; }
        public string etd_actual { get; set; }
        public string eta_actual { get; set; }
        public string send_delivery_actual_date { get; set; }
        public string arrival_method { get; set; }
        public string trade_condition { get; set; }
        public string source_document_no { get; set; }
        public string source_breakdown_no { get; set; }
        public string discourse_to { get; set; }
        public string rfq_no { get; set; }
        public string program_update_date { get; set; }
         public DateTime? upd_dt { get; set; } 
        public string upd_by { get; set; } 

    }
}