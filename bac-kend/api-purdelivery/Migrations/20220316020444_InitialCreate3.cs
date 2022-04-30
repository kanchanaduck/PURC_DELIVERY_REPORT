using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ship_To",
                table: "T_PU_Original",
                newName: "ship_to");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_PU_Original",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_PU_Original",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "Item_Desc",
                table: "T_PU_Original",
                newName: "item_desc");

            migrationBuilder.RenameColumn(
                name: "ship_To",
                table: "T_PU_Abnormal",
                newName: "ship_to");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_PU_Abnormal",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_PU_Abnormal",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "Item_Desc",
                table: "T_PU_Abnormal",
                newName: "item_desc");

            migrationBuilder.RenameColumn(
                name: "Action",
                table: "T_PU_Abnormal",
                newName: "action");

            migrationBuilder.RenameColumn(
                name: "ship_To",
                table: "T_PU",
                newName: "ship_to");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_PU",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_PU",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "Item_Desc",
                table: "T_PU",
                newName: "item_desc");

            migrationBuilder.RenameColumn(
                name: "approved_Req_amount",
                table: "T_PO_Issue",
                newName: "approved_req_amount");

            migrationBuilder.RenameColumn(
                name: "Update_Person",
                table: "T_PO_Issue",
                newName: "update_person");

            migrationBuilder.RenameColumn(
                name: "Update_Date",
                table: "T_PO_Issue",
                newName: "update_date");

            migrationBuilder.RenameColumn(
                name: "Unit_Price_Reply_Quotation",
                table: "T_PO_Issue",
                newName: "unit_price_reply_quotation");

            migrationBuilder.RenameColumn(
                name: "Unit_Price_Reason_code",
                table: "T_PO_Issue",
                newName: "unit_price_reason_code");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_PO_Issue",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_PO_Issue",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "UNSPSC_Code",
                table: "T_PO_Issue",
                newName: "unspsc_code");

            migrationBuilder.RenameColumn(
                name: "Trade_Condition",
                table: "T_PO_Issue",
                newName: "trade_condition");

            migrationBuilder.RenameColumn(
                name: "Temporary_Unit_Price_Flag",
                table: "T_PO_Issue",
                newName: "temporary_unit_price_flag");

            migrationBuilder.RenameColumn(
                name: "Temporary_Unit_Price",
                table: "T_PO_Issue",
                newName: "temporary_unit_price");

            migrationBuilder.RenameColumn(
                name: "Supp_Selection_Reason_code",
                table: "T_PO_Issue",
                newName: "supp_selection_reason_code");

            migrationBuilder.RenameColumn(
                name: "Supp_Reply_Quotation",
                table: "T_PO_Issue",
                newName: "supp_reply_quotation");

            migrationBuilder.RenameColumn(
                name: "Supp_Comment",
                table: "T_PO_Issue",
                newName: "supp_comment");

            migrationBuilder.RenameColumn(
                name: "Subcontract_Class",
                table: "T_PO_Issue",
                newName: "subcontract_class");

            migrationBuilder.RenameColumn(
                name: "Standard_Unit_Price_Code",
                table: "T_PO_Issue",
                newName: "standard_unit_price_code");

            migrationBuilder.RenameColumn(
                name: "Standard_Unit_Price",
                table: "T_PO_Issue",
                newName: "standard_unit_price");

            migrationBuilder.RenameColumn(
                name: "Source_Document_No",
                table: "T_PO_Issue",
                newName: "source_document_no");

            migrationBuilder.RenameColumn(
                name: "Source_Breakdown_No",
                table: "T_PO_Issue",
                newName: "source_breakdown_no");

            migrationBuilder.RenameColumn(
                name: "Send_Delivery_Actual_Date",
                table: "T_PO_Issue",
                newName: "send_delivery_actual_date");

            migrationBuilder.RenameColumn(
                name: "Risk_Level_Class",
                table: "T_PO_Issue",
                newName: "risk_level_class");

            migrationBuilder.RenameColumn(
                name: "Req_Unit",
                table: "T_PO_Issue",
                newName: "req_unit");

            migrationBuilder.RenameColumn(
                name: "Req_Compny_Name",
                table: "T_PO_Issue",
                newName: "req_compny_name");

            migrationBuilder.RenameColumn(
                name: "Req_Company_Code",
                table: "T_PO_Issue",
                newName: "req_company_code");

            migrationBuilder.RenameColumn(
                name: "Receiving_Creat_Date",
                table: "T_PO_Issue",
                newName: "receiving_creat_date");

            migrationBuilder.RenameColumn(
                name: "Receive_PIC_Name",
                table: "T_PO_Issue",
                newName: "receive_pic_name");

            migrationBuilder.RenameColumn(
                name: "Receive_Creat_PIC",
                table: "T_PO_Issue",
                newName: "receive_creat_pic");

            migrationBuilder.RenameColumn(
                name: "Receipt_Regis_Quantity",
                table: "T_PO_Issue",
                newName: "receipt_regis_quantity");

            migrationBuilder.RenameColumn(
                name: "Receipt_Regis_Person",
                table: "T_PO_Issue",
                newName: "receipt_regis_person");

            migrationBuilder.RenameColumn(
                name: "Receipt_Regis_Date",
                table: "T_PO_Issue",
                newName: "receipt_regis_date");

            migrationBuilder.RenameColumn(
                name: "RFQ_NO",
                table: "T_PO_Issue",
                newName: "rfq_no");

            migrationBuilder.RenameColumn(
                name: "RFQ3",
                table: "T_PO_Issue",
                newName: "rfq3");

            migrationBuilder.RenameColumn(
                name: "RFQ2",
                table: "T_PO_Issue",
                newName: "rfq2");

            migrationBuilder.RenameColumn(
                name: "RFQ1",
                table: "T_PO_Issue",
                newName: "rfq1");

            migrationBuilder.RenameColumn(
                name: "Quotation_Req_Date",
                table: "T_PO_Issue",
                newName: "quotation_req_date");

            migrationBuilder.RenameColumn(
                name: "Quotation_Reply_Date",
                table: "T_PO_Issue",
                newName: "quotation_reply_date");

            migrationBuilder.RenameColumn(
                name: "Quotation_No",
                table: "T_PO_Issue",
                newName: "quotation_no");

            migrationBuilder.RenameColumn(
                name: "Program_Update_Date",
                table: "T_PO_Issue",
                newName: "program_update_date");

            migrationBuilder.RenameColumn(
                name: "PR_Approve_Date",
                table: "T_PO_Issue",
                newName: "pr_approve_date");

            migrationBuilder.RenameColumn(
                name: "Ordered_Person_Name",
                table: "T_PO_Issue",
                newName: "ordered_person_name");

            migrationBuilder.RenameColumn(
                name: "Ordered_Company_Code",
                table: "T_PO_Issue",
                newName: "ordered_company_code");

            migrationBuilder.RenameColumn(
                name: "Order_Sheet_Output_Class",
                table: "T_PO_Issue",
                newName: "order_sheet_output_class");

            migrationBuilder.RenameColumn(
                name: "Order_Remain_Quantity",
                table: "T_PO_Issue",
                newName: "order_remain_quantity");

            migrationBuilder.RenameColumn(
                name: "Order_Reason_Class",
                table: "T_PO_Issue",
                newName: "order_reason_class");

            migrationBuilder.RenameColumn(
                name: "Order_Lead_Time",
                table: "T_PO_Issue",
                newName: "order_lead_time");

            migrationBuilder.RenameColumn(
                name: "Order_Cheapest_Supp_Quotation",
                table: "T_PO_Issue",
                newName: "order_cheapest_supp_quotation");

            migrationBuilder.RenameColumn(
                name: "Order_Approver4",
                table: "T_PO_Issue",
                newName: "order_approver4");

            migrationBuilder.RenameColumn(
                name: "Order_Approver3",
                table: "T_PO_Issue",
                newName: "order_approver3");

            migrationBuilder.RenameColumn(
                name: "Order_Approver2",
                table: "T_PO_Issue",
                newName: "order_approver2");

            migrationBuilder.RenameColumn(
                name: "Order_Approver1",
                table: "T_PO_Issue",
                newName: "order_approver1");

            migrationBuilder.RenameColumn(
                name: "Officlal_UnitPrice_ChangePlan_Date",
                table: "T_PO_Issue",
                newName: "officlal_unitprice_changeplan_date");

            migrationBuilder.RenameColumn(
                name: "OK_Amount",
                table: "T_PO_Issue",
                newName: "ok_amount");

            migrationBuilder.RenameColumn(
                name: "NG_Amount",
                table: "T_PO_Issue",
                newName: "ng_amount");

            migrationBuilder.RenameColumn(
                name: "Maximum_Unit_Price",
                table: "T_PO_Issue",
                newName: "maximum_unit_price");

            migrationBuilder.RenameColumn(
                name: "Lead_Time_Reply_Quotation",
                table: "T_PO_Issue",
                newName: "lead_time_reply_quotation");

            migrationBuilder.RenameColumn(
                name: "Install_Adjust_Flag",
                table: "T_PO_Issue",
                newName: "install_adjust_flag");

            migrationBuilder.RenameColumn(
                name: "Inspec_TimeDay",
                table: "T_PO_Issue",
                newName: "inspec_timeday");

            migrationBuilder.RenameColumn(
                name: "Inspec_Receive_PIC",
                table: "T_PO_Issue",
                newName: "inspec_receive_pic");

            migrationBuilder.RenameColumn(
                name: "Inspec_Receive_Creat_Date",
                table: "T_PO_Issue",
                newName: "inspec_receive_creat_date");

            migrationBuilder.RenameColumn(
                name: "Inspec_PIC_Name",
                table: "T_PO_Issue",
                newName: "inspec_pic_name");

            migrationBuilder.RenameColumn(
                name: "Inspec_CreditDebit_Approver",
                table: "T_PO_Issue",
                newName: "inspec_creditdebit_approver");

            migrationBuilder.RenameColumn(
                name: "Full_Quotation_ReplyNo",
                table: "T_PO_Issue",
                newName: "full_quotation_replyno");

            migrationBuilder.RenameColumn(
                name: "Full_Quotation_No",
                table: "T_PO_Issue",
                newName: "full_quotation_no");

            migrationBuilder.RenameColumn(
                name: "Full_PO_No",
                table: "T_PO_Issue",
                newName: "full_po_no");

            migrationBuilder.RenameColumn(
                name: "Full_Order_No",
                table: "T_PO_Issue",
                newName: "full_order_no");

            migrationBuilder.RenameColumn(
                name: "Full_Maker_Code",
                table: "T_PO_Issue",
                newName: "full_maker_code");

            migrationBuilder.RenameColumn(
                name: "Full_Buyer_Code",
                table: "T_PO_Issue",
                newName: "full_buyer_code");

            migrationBuilder.RenameColumn(
                name: "Full_Budget_Code",
                table: "T_PO_Issue",
                newName: "full_budget_code");

            migrationBuilder.RenameColumn(
                name: "ETD_Actual",
                table: "T_PO_Issue",
                newName: "etd_actual");

            migrationBuilder.RenameColumn(
                name: "ETA_Actual",
                table: "T_PO_Issue",
                newName: "eta_actual");

            migrationBuilder.RenameColumn(
                name: "Discourse_to",
                table: "T_PO_Issue",
                newName: "discourse_to");

            migrationBuilder.RenameColumn(
                name: "Direct_Delivery_Class",
                table: "T_PO_Issue",
                newName: "direct_delivery_class");

            migrationBuilder.RenameColumn(
                name: "Dept_InCharge_Code",
                table: "T_PO_Issue",
                newName: "dept_incharge_code");

            migrationBuilder.RenameColumn(
                name: "Delivery_Time_Flag",
                table: "T_PO_Issue",
                newName: "delivery_time_flag");

            migrationBuilder.RenameColumn(
                name: "Currency_Code",
                table: "T_PO_Issue",
                newName: "currency_code");

            migrationBuilder.RenameColumn(
                name: "Creation_Person",
                table: "T_PO_Issue",
                newName: "creation_person");

            migrationBuilder.RenameColumn(
                name: "Creation_Date",
                table: "T_PO_Issue",
                newName: "creation_date");

            migrationBuilder.RenameColumn(
                name: "Company_PIC_Receiving",
                table: "T_PO_Issue",
                newName: "company_pic_receiving");

            migrationBuilder.RenameColumn(
                name: "Company_PIC_Inspection",
                table: "T_PO_Issue",
                newName: "company_pic_inspection");

            migrationBuilder.RenameColumn(
                name: "Chemical_Subs_No",
                table: "T_PO_Issue",
                newName: "chemical_subs_no");

            migrationBuilder.RenameColumn(
                name: "Check",
                table: "T_PO_Issue",
                newName: "check");

            migrationBuilder.RenameColumn(
                name: "Catalog_Validity",
                table: "T_PO_Issue",
                newName: "catalog_validity");

            migrationBuilder.RenameColumn(
                name: "Cancel_date",
                table: "T_PO_Issue",
                newName: "cancel_date");

            migrationBuilder.RenameColumn(
                name: "Buyer_Name",
                table: "T_PO_Issue",
                newName: "buyer_name");

            migrationBuilder.RenameColumn(
                name: "Attached_File_Name",
                table: "T_PO_Issue",
                newName: "attached_file_name");

            migrationBuilder.RenameColumn(
                name: "Attached_File_Flag",
                table: "T_PO_Issue",
                newName: "attached_file_flag");

            migrationBuilder.RenameColumn(
                name: "Arrival_Req_Date_Plan",
                table: "T_PO_Issue",
                newName: "arrival_req_date_plan");

            migrationBuilder.RenameColumn(
                name: "Arrival_Method",
                table: "T_PO_Issue",
                newName: "arrival_method");

            migrationBuilder.RenameColumn(
                name: "Approver_MSG2",
                table: "T_PO_Issue",
                newName: "approver_msg2");

            migrationBuilder.RenameColumn(
                name: "Approver_MSG1",
                table: "T_PO_Issue",
                newName: "approver_msg1");

            migrationBuilder.RenameColumn(
                name: "Accounting_Month",
                table: "T_PO_Issue",
                newName: "accounting_month");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_Oversea",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_Oversea",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "TSS_Result",
                table: "T_Oversea",
                newName: "tss_result");

            migrationBuilder.RenameColumn(
                name: "TM_REC",
                table: "T_Oversea",
                newName: "tm_rec");

            migrationBuilder.RenameColumn(
                name: "TM_PO",
                table: "T_Oversea",
                newName: "tm_po");

            migrationBuilder.RenameColumn(
                name: "TM_DELV",
                table: "T_Oversea",
                newName: "tm_delv");

            migrationBuilder.RenameColumn(
                name: "Reason_ShortLT",
                table: "T_Oversea",
                newName: "reason_shortlt");

            migrationBuilder.RenameColumn(
                name: "Reason_IV",
                table: "T_Oversea",
                newName: "reason_iv");

            migrationBuilder.RenameColumn(
                name: "Reason_Early",
                table: "T_Oversea",
                newName: "reason_early");

            migrationBuilder.RenameColumn(
                name: "Reason_Delay",
                table: "T_Oversea",
                newName: "reason_delay");

            migrationBuilder.RenameColumn(
                name: "QT_REC",
                table: "T_Oversea",
                newName: "qt_rec");

            migrationBuilder.RenameColumn(
                name: "QT_ORD",
                table: "T_Oversea",
                newName: "qt_ord");

            migrationBuilder.RenameColumn(
                name: "QT_NG",
                table: "T_Oversea",
                newName: "qt_ng");

            migrationBuilder.RenameColumn(
                name: "QT_DELV_DIRCT",
                table: "T_Oversea",
                newName: "qt_delv_dirct");

            migrationBuilder.RenameColumn(
                name: "NO_SPLIT_DEIV_SFX",
                table: "T_Oversea",
                newName: "no_split_deiv_sfx");

            migrationBuilder.RenameColumn(
                name: "NO_PO",
                table: "T_Oversea",
                newName: "no_po");

            migrationBuilder.RenameColumn(
                name: "NO_PARTS",
                table: "T_Oversea",
                newName: "no_parts");

            migrationBuilder.RenameColumn(
                name: "NO_INVOICE",
                table: "T_Oversea",
                newName: "no_invoice");

            migrationBuilder.RenameColumn(
                name: "NO_DRAW",
                table: "T_Oversea",
                newName: "no_draw");

            migrationBuilder.RenameColumn(
                name: "NO_ARRANGE",
                table: "T_Oversea",
                newName: "no_arrange");

            migrationBuilder.RenameColumn(
                name: "NO_ADJ_DIM",
                table: "T_Oversea",
                newName: "no_adj_dim");

            migrationBuilder.RenameColumn(
                name: "MK_ShortLT",
                table: "T_Oversea",
                newName: "mk_shortlt");

            migrationBuilder.RenameColumn(
                name: "MK_ONTIME",
                table: "T_Oversea",
                newName: "mk_ontime");

            migrationBuilder.RenameColumn(
                name: "MK_IV",
                table: "T_Oversea",
                newName: "mk_iv");

            migrationBuilder.RenameColumn(
                name: "MK_Early",
                table: "T_Oversea",
                newName: "mk_early");

            migrationBuilder.RenameColumn(
                name: "MK_Delay",
                table: "T_Oversea",
                newName: "mk_delay");

            migrationBuilder.RenameColumn(
                name: "MK_DV",
                table: "T_Oversea",
                newName: "mk_dv");

            migrationBuilder.RenameColumn(
                name: "IV_TERM",
                table: "T_Oversea",
                newName: "iv_term");

            migrationBuilder.RenameColumn(
                name: "EARLY_DV",
                table: "T_Oversea",
                newName: "early_dv");

            migrationBuilder.RenameColumn(
                name: "Detail_delay",
                table: "T_Oversea",
                newName: "detail_delay");

            migrationBuilder.RenameColumn(
                name: "Detail_ShortLT",
                table: "T_Oversea",
                newName: "detail_shortlt");

            migrationBuilder.RenameColumn(
                name: "Detail_Early",
                table: "T_Oversea",
                newName: "detail_early");

            migrationBuilder.RenameColumn(
                name: "Detail_DV",
                table: "T_Oversea",
                newName: "detail_dv");

            migrationBuilder.RenameColumn(
                name: "DT_REC",
                table: "T_Oversea",
                newName: "dt_rec");

            migrationBuilder.RenameColumn(
                name: "DT_PO",
                table: "T_Oversea",
                newName: "dt_po");

            migrationBuilder.RenameColumn(
                name: "DT_DELV_ESTIM",
                table: "T_Oversea",
                newName: "dt_delv_estim");

            migrationBuilder.RenameColumn(
                name: "DT_DELV_DIRCT",
                table: "T_Oversea",
                newName: "dt_delv_dirct");

            migrationBuilder.RenameColumn(
                name: "DT_DELV_BAL",
                table: "T_Oversea",
                newName: "dt_delv_bal");

            migrationBuilder.RenameColumn(
                name: "DT_DELV",
                table: "T_Oversea",
                newName: "dt_delv");

            migrationBuilder.RenameColumn(
                name: "CM_COMENT",
                table: "T_Oversea",
                newName: "cm_coment");

            migrationBuilder.RenameColumn(
                name: "CK_ShortLT2",
                table: "T_Oversea",
                newName: "ck_shortlt2");

            migrationBuilder.RenameColumn(
                name: "CK_ShortLT1",
                table: "T_Oversea",
                newName: "ck_shortlt1");

            migrationBuilder.RenameColumn(
                name: "CK_EOD",
                table: "T_Oversea",
                newName: "ck_eod");

            migrationBuilder.RenameColumn(
                name: "CF_RPT_PARTS_ORD",
                table: "T_Oversea",
                newName: "cf_rpt_parts_ord");

            migrationBuilder.RenameColumn(
                name: "CD_USE_BLOCK",
                table: "T_Oversea",
                newName: "cd_use_block");

            migrationBuilder.RenameColumn(
                name: "CD_SPLY_FACT",
                table: "T_Oversea",
                newName: "cd_sply_fact");

            migrationBuilder.RenameColumn(
                name: "CD_SPLY_CLASS",
                table: "T_Oversea",
                newName: "cd_sply_class");

            migrationBuilder.RenameColumn(
                name: "CD_SPLY",
                table: "T_Oversea",
                newName: "cd_sply");

            migrationBuilder.RenameColumn(
                name: "CD_PROCESS",
                table: "T_Oversea",
                newName: "cd_process");

            migrationBuilder.RenameColumn(
                name: "CD_ORD_RESN",
                table: "T_Oversea",
                newName: "cd_ord_resn");

            migrationBuilder.RenameColumn(
                name: "CD_INSP_TYPE_EIAJ",
                table: "T_Oversea",
                newName: "cd_insp_type_eiaj");

            migrationBuilder.RenameColumn(
                name: "CD_ESTIM_PERSON",
                table: "T_Oversea",
                newName: "cd_estim_person");

            migrationBuilder.RenameColumn(
                name: "CD_DESTIN",
                table: "T_Oversea",
                newName: "cd_destin");

            migrationBuilder.RenameColumn(
                name: "CD_DELV_PLACE",
                table: "T_Oversea",
                newName: "cd_delv_place");

            migrationBuilder.RenameColumn(
                name: "CD_CHG_HIST_ALL",
                table: "T_Oversea",
                newName: "cd_chg_hist_all");

            migrationBuilder.RenameColumn(
                name: "waybill_No",
                table: "T_Delay_ShortLT",
                newName: "waybill_no");

            migrationBuilder.RenameColumn(
                name: "waybill_Date",
                table: "T_Delay_ShortLT",
                newName: "waybill_date");

            migrationBuilder.RenameColumn(
                name: "theme_ID",
                table: "T_Delay_ShortLT",
                newName: "theme_id");

            migrationBuilder.RenameColumn(
                name: "supp_Item_code",
                table: "T_Delay_ShortLT",
                newName: "supp_item_code");

            migrationBuilder.RenameColumn(
                name: "revision_No",
                table: "T_Delay_ShortLT",
                newName: "revision_no");

            migrationBuilder.RenameColumn(
                name: "receive_Number",
                table: "T_Delay_ShortLT",
                newName: "receive_number");

            migrationBuilder.RenameColumn(
                name: "payment_amount_includeTax",
                table: "T_Delay_ShortLT",
                newName: "payment_amount_includetax");

            migrationBuilder.RenameColumn(
                name: "payment_amount_excludeTax",
                table: "T_Delay_ShortLT",
                newName: "payment_amount_excludetax");

            migrationBuilder.RenameColumn(
                name: "organi_Code_Capitalizing",
                table: "T_Delay_ShortLT",
                newName: "organi_code_capitalizing");

            migrationBuilder.RenameColumn(
                name: "order_Date",
                table: "T_Delay_ShortLT",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "nvoice_No",
                table: "T_Delay_ShortLT",
                newName: "nvoice_no");

            migrationBuilder.RenameColumn(
                name: "invoice_No_Domestic",
                table: "T_Delay_ShortLT",
                newName: "invoice_no_domestic");

            migrationBuilder.RenameColumn(
                name: "invoice_Date",
                table: "T_Delay_ShortLT",
                newName: "invoice_date");

            migrationBuilder.RenameColumn(
                name: "inspection_YN",
                table: "T_Delay_ShortLT",
                newName: "inspection_yn");

            migrationBuilder.RenameColumn(
                name: "delivery_SlipNo",
                table: "T_Delay_ShortLT",
                newName: "delivery_slipno");

            migrationBuilder.RenameColumn(
                name: "code_Fixed_Assets",
                table: "T_Delay_ShortLT",
                newName: "code_fixed_assets");

            migrationBuilder.RenameColumn(
                name: "code_Budget_FixedAssets",
                table: "T_Delay_ShortLT",
                newName: "code_budget_fixedassets");

            migrationBuilder.RenameColumn(
                name: "check_ShortLT",
                table: "T_Delay_ShortLT",
                newName: "check_shortlt");

            migrationBuilder.RenameColumn(
                name: "check_EOD",
                table: "T_Delay_ShortLT",
                newName: "check_eod");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_Delay_ShortLT",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_Delay_ShortLT",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "UNSPSC_code",
                table: "T_Delay_ShortLT",
                newName: "unspsc_code");

            migrationBuilder.RenameColumn(
                name: "Supp_Site_code",
                table: "T_Delay_ShortLT",
                newName: "supp_site_code");

            migrationBuilder.RenameColumn(
                name: "Received_qty",
                table: "T_Delay_ShortLT",
                newName: "received_qty");

            migrationBuilder.RenameColumn(
                name: "RFQ_Number",
                table: "T_Delay_ShortLT",
                newName: "rfq_number");

            migrationBuilder.RenameColumn(
                name: "ProMo_No",
                table: "T_Delay_ShortLT",
                newName: "promo_no");

            migrationBuilder.RenameColumn(
                name: "PIC_receiving_acceptance",
                table: "T_Delay_ShortLT",
                newName: "pic_receiving_acceptance");

            migrationBuilder.RenameColumn(
                name: "Item_Desc",
                table: "T_Delay_ShortLT",
                newName: "item_desc");

            migrationBuilder.RenameColumn(
                name: "Inhouse_Order",
                table: "T_Delay_ShortLT",
                newName: "inhouse_order");

            migrationBuilder.RenameColumn(
                name: "Cost_item",
                table: "T_Delay_ShortLT",
                newName: "cost_item");

            migrationBuilder.RenameColumn(
                name: "CHAMP_reserve2",
                table: "T_Delay_ShortLT",
                newName: "champ_reserve2");

            migrationBuilder.RenameColumn(
                name: "CHAMP_reserve1",
                table: "T_Delay_ShortLT",
                newName: "champ_reserve1");

            migrationBuilder.RenameColumn(
                name: "request_Email",
                table: "T_Delay_Oversea",
                newName: "request_email");

            migrationBuilder.RenameColumn(
                name: "inspectionYN",
                table: "T_Delay_Oversea",
                newName: "inspectionyn");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_telephone",
                table: "T_Delay_Oversea",
                newName: "buyer_pic_telephone");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_mailddress",
                table: "T_Delay_Oversea",
                newName: "buyer_pic_mailddress");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_company_name",
                table: "T_Delay_Oversea",
                newName: "buyer_pic_company_name");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_belong_name",
                table: "T_Delay_Oversea",
                newName: "buyer_pic_belong_name");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_Delay_Oversea",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_Delay_Oversea",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "Today",
                table: "T_Delay_Oversea",
                newName: "today");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "T_Delay_Oversea",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Resp_SupplierCPT",
                table: "T_Delay_Oversea",
                newName: "resp_suppliercpt");

            migrationBuilder.RenameColumn(
                name: "Requisitioner",
                table: "T_Delay_Oversea",
                newName: "requisitioner");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "T_Delay_Oversea",
                newName: "remarks");

            migrationBuilder.RenameColumn(
                name: "Remark_and_Reason",
                table: "T_Delay_Oversea",
                newName: "remark_and_reason");

            migrationBuilder.RenameColumn(
                name: "Promised_Date",
                table: "T_Delay_Oversea",
                newName: "promised_date");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "T_Delay_Oversea",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "PO_Shipm_Number",
                table: "T_Delay_Oversea",
                newName: "po_shipm_number");

            migrationBuilder.RenameColumn(
                name: "PO_Number",
                table: "T_Delay_Oversea",
                newName: "po_number");

            migrationBuilder.RenameColumn(
                name: "PO_Line_Number",
                table: "T_Delay_Oversea",
                newName: "po_line_number");

            migrationBuilder.RenameColumn(
                name: "Order_Date",
                table: "T_Delay_Oversea",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "Item_Desc",
                table: "T_Delay_Oversea",
                newName: "item_desc");

            migrationBuilder.RenameColumn(
                name: "Delay",
                table: "T_Delay_Oversea",
                newName: "delay");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "T_Delay_Oversea",
                newName: "currency");

            migrationBuilder.RenameColumn(
                name: "request_Email",
                table: "T_Delay_Domestic",
                newName: "request_email");

            migrationBuilder.RenameColumn(
                name: "inspectionYN",
                table: "T_Delay_Domestic",
                newName: "inspectionyn");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_telephone",
                table: "T_Delay_Domestic",
                newName: "buyer_pic_telephone");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_mailddress",
                table: "T_Delay_Domestic",
                newName: "buyer_pic_mailddress");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_company_name",
                table: "T_Delay_Domestic",
                newName: "buyer_pic_company_name");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_belong_name",
                table: "T_Delay_Domestic",
                newName: "buyer_pic_belong_name");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_Delay_Domestic",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_Delay_Domestic",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "Today",
                table: "T_Delay_Domestic",
                newName: "today");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "T_Delay_Domestic",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Resp_SupplierCPT",
                table: "T_Delay_Domestic",
                newName: "resp_suppliercpt");

            migrationBuilder.RenameColumn(
                name: "Requisitioner",
                table: "T_Delay_Domestic",
                newName: "requisitioner");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "T_Delay_Domestic",
                newName: "remarks");

            migrationBuilder.RenameColumn(
                name: "Remark_and_Reason",
                table: "T_Delay_Domestic",
                newName: "remark_and_reason");

            migrationBuilder.RenameColumn(
                name: "Promised_Date",
                table: "T_Delay_Domestic",
                newName: "promised_date");

            migrationBuilder.RenameColumn(
                name: "PO_Shipm_Number",
                table: "T_Delay_Domestic",
                newName: "po_shipm_number");

            migrationBuilder.RenameColumn(
                name: "PO_Number",
                table: "T_Delay_Domestic",
                newName: "po_number");

            migrationBuilder.RenameColumn(
                name: "PO_Line_Number",
                table: "T_Delay_Domestic",
                newName: "po_line_number");

            migrationBuilder.RenameColumn(
                name: "Order_Date",
                table: "T_Delay_Domestic",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "Item_Desc",
                table: "T_Delay_Domestic",
                newName: "item_desc");

            migrationBuilder.RenameColumn(
                name: "Delay",
                table: "T_Delay_Domestic",
                newName: "delay");

            migrationBuilder.RenameColumn(
                name: "Byer_PIC",
                table: "T_Delay_Domestic",
                newName: "byer_pic");

            migrationBuilder.RenameColumn(
                name: "request_Email",
                table: "T_Control_Oversea",
                newName: "request_email");

            migrationBuilder.RenameColumn(
                name: "inspectionYN",
                table: "T_Control_Oversea",
                newName: "inspectionyn");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_telephone",
                table: "T_Control_Oversea",
                newName: "buyer_pic_telephone");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_mailddress",
                table: "T_Control_Oversea",
                newName: "buyer_pic_mailddress");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_company_name",
                table: "T_Control_Oversea",
                newName: "buyer_pic_company_name");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_belong_name",
                table: "T_Control_Oversea",
                newName: "buyer_pic_belong_name");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_Control_Oversea",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_Control_Oversea",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "Today",
                table: "T_Control_Oversea",
                newName: "today");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "T_Control_Oversea",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Requisitioner",
                table: "T_Control_Oversea",
                newName: "requisitioner");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "T_Control_Oversea",
                newName: "remarks");

            migrationBuilder.RenameColumn(
                name: "Promised_Date",
                table: "T_Control_Oversea",
                newName: "promised_date");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "T_Control_Oversea",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "PO_Shipm_Number",
                table: "T_Control_Oversea",
                newName: "po_shipm_number");

            migrationBuilder.RenameColumn(
                name: "PO_Number",
                table: "T_Control_Oversea",
                newName: "po_number");

            migrationBuilder.RenameColumn(
                name: "PO_Line_Number",
                table: "T_Control_Oversea",
                newName: "po_line_number");

            migrationBuilder.RenameColumn(
                name: "Order_Date",
                table: "T_Control_Oversea",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "LT",
                table: "T_Control_Oversea",
                newName: "lt");

            migrationBuilder.RenameColumn(
                name: "Item_Desc",
                table: "T_Control_Oversea",
                newName: "item_desc");

            migrationBuilder.RenameColumn(
                name: "Delay",
                table: "T_Control_Oversea",
                newName: "delay");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "T_Control_Oversea",
                newName: "currency");

            migrationBuilder.RenameColumn(
                name: "Check",
                table: "T_Control_Oversea",
                newName: "check");

            migrationBuilder.RenameColumn(
                name: "Vendor_Name",
                table: "T_Control_Evalio",
                newName: "vendor_name");

            migrationBuilder.RenameColumn(
                name: "Vendor_Code",
                table: "T_Control_Evalio",
                newName: "vendor_code");

            migrationBuilder.RenameColumn(
                name: "Unit_Price",
                table: "T_Control_Evalio",
                newName: "unit_price");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "T_Control_Evalio",
                newName: "unit");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_Control_Evalio",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_Control_Evalio",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "Today",
                table: "T_Control_Evalio",
                newName: "today");

            migrationBuilder.RenameColumn(
                name: "Resp_supplierCPT",
                table: "T_Control_Evalio",
                newName: "resp_suppliercpt");

            migrationBuilder.RenameColumn(
                name: "Remark_and_Reason",
                table: "T_Control_Evalio",
                newName: "remark_and_reason");

            migrationBuilder.RenameColumn(
                name: "Remain",
                table: "T_Control_Evalio",
                newName: "remain");

            migrationBuilder.RenameColumn(
                name: "Received",
                table: "T_Control_Evalio",
                newName: "received");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "T_Control_Evalio",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Prepareby",
                table: "T_Control_Evalio",
                newName: "prepareby");

            migrationBuilder.RenameColumn(
                name: "PR_No",
                table: "T_Control_Evalio",
                newName: "pr_no");

            migrationBuilder.RenameColumn(
                name: "PO_No",
                table: "T_Control_Evalio",
                newName: "po_no");

            migrationBuilder.RenameColumn(
                name: "No",
                table: "T_Control_Evalio",
                newName: "no");

            migrationBuilder.RenameColumn(
                name: "LT",
                table: "T_Control_Evalio",
                newName: "lt");

            migrationBuilder.RenameColumn(
                name: "Item_Name",
                table: "T_Control_Evalio",
                newName: "item_name");

            migrationBuilder.RenameColumn(
                name: "Item",
                table: "T_Control_Evalio",
                newName: "item");

            migrationBuilder.RenameColumn(
                name: "IssueDate",
                table: "T_Control_Evalio",
                newName: "issuedate");

            migrationBuilder.RenameColumn(
                name: "Expense_Code",
                table: "T_Control_Evalio",
                newName: "expense_code");

            migrationBuilder.RenameColumn(
                name: "Equipment_Budget_Code",
                table: "T_Control_Evalio",
                newName: "equipment_budget_code");

            migrationBuilder.RenameColumn(
                name: "Delivery_Date",
                table: "T_Control_Evalio",
                newName: "delivery_date");

            migrationBuilder.RenameColumn(
                name: "Delay",
                table: "T_Control_Evalio",
                newName: "delay");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "T_Control_Evalio",
                newName: "currency");

            migrationBuilder.RenameColumn(
                name: "Center_Name",
                table: "T_Control_Evalio",
                newName: "center_name");

            migrationBuilder.RenameColumn(
                name: "Center_Code",
                table: "T_Control_Evalio",
                newName: "center_code");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "T_Control_Domestic",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_PU_Original",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_PU_Original",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "ship_to",
                table: "T_PU_Original",
                newName: "ship_To");

            migrationBuilder.RenameColumn(
                name: "item_desc",
                table: "T_PU_Original",
                newName: "Item_Desc");

            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_PU_Abnormal",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_PU_Abnormal",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "ship_to",
                table: "T_PU_Abnormal",
                newName: "ship_To");

            migrationBuilder.RenameColumn(
                name: "item_desc",
                table: "T_PU_Abnormal",
                newName: "Item_Desc");

            migrationBuilder.RenameColumn(
                name: "action",
                table: "T_PU_Abnormal",
                newName: "Action");

            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_PU",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_PU",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "ship_to",
                table: "T_PU",
                newName: "ship_To");

            migrationBuilder.RenameColumn(
                name: "item_desc",
                table: "T_PU",
                newName: "Item_Desc");

            migrationBuilder.RenameColumn(
                name: "update_person",
                table: "T_PO_Issue",
                newName: "Update_Person");

            migrationBuilder.RenameColumn(
                name: "update_date",
                table: "T_PO_Issue",
                newName: "Update_Date");

            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_PO_Issue",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_PO_Issue",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "unspsc_code",
                table: "T_PO_Issue",
                newName: "UNSPSC_Code");

            migrationBuilder.RenameColumn(
                name: "unit_price_reply_quotation",
                table: "T_PO_Issue",
                newName: "Unit_Price_Reply_Quotation");

            migrationBuilder.RenameColumn(
                name: "unit_price_reason_code",
                table: "T_PO_Issue",
                newName: "Unit_Price_Reason_code");

            migrationBuilder.RenameColumn(
                name: "trade_condition",
                table: "T_PO_Issue",
                newName: "Trade_Condition");

            migrationBuilder.RenameColumn(
                name: "temporary_unit_price_flag",
                table: "T_PO_Issue",
                newName: "Temporary_Unit_Price_Flag");

            migrationBuilder.RenameColumn(
                name: "temporary_unit_price",
                table: "T_PO_Issue",
                newName: "Temporary_Unit_Price");

            migrationBuilder.RenameColumn(
                name: "supp_selection_reason_code",
                table: "T_PO_Issue",
                newName: "Supp_Selection_Reason_code");

            migrationBuilder.RenameColumn(
                name: "supp_reply_quotation",
                table: "T_PO_Issue",
                newName: "Supp_Reply_Quotation");

            migrationBuilder.RenameColumn(
                name: "supp_comment",
                table: "T_PO_Issue",
                newName: "Supp_Comment");

            migrationBuilder.RenameColumn(
                name: "subcontract_class",
                table: "T_PO_Issue",
                newName: "Subcontract_Class");

            migrationBuilder.RenameColumn(
                name: "standard_unit_price_code",
                table: "T_PO_Issue",
                newName: "Standard_Unit_Price_Code");

            migrationBuilder.RenameColumn(
                name: "standard_unit_price",
                table: "T_PO_Issue",
                newName: "Standard_Unit_Price");

            migrationBuilder.RenameColumn(
                name: "source_document_no",
                table: "T_PO_Issue",
                newName: "Source_Document_No");

            migrationBuilder.RenameColumn(
                name: "source_breakdown_no",
                table: "T_PO_Issue",
                newName: "Source_Breakdown_No");

            migrationBuilder.RenameColumn(
                name: "send_delivery_actual_date",
                table: "T_PO_Issue",
                newName: "Send_Delivery_Actual_Date");

            migrationBuilder.RenameColumn(
                name: "risk_level_class",
                table: "T_PO_Issue",
                newName: "Risk_Level_Class");

            migrationBuilder.RenameColumn(
                name: "rfq_no",
                table: "T_PO_Issue",
                newName: "RFQ_NO");

            migrationBuilder.RenameColumn(
                name: "rfq3",
                table: "T_PO_Issue",
                newName: "RFQ3");

            migrationBuilder.RenameColumn(
                name: "rfq2",
                table: "T_PO_Issue",
                newName: "RFQ2");

            migrationBuilder.RenameColumn(
                name: "rfq1",
                table: "T_PO_Issue",
                newName: "RFQ1");

            migrationBuilder.RenameColumn(
                name: "req_unit",
                table: "T_PO_Issue",
                newName: "Req_Unit");

            migrationBuilder.RenameColumn(
                name: "req_compny_name",
                table: "T_PO_Issue",
                newName: "Req_Compny_Name");

            migrationBuilder.RenameColumn(
                name: "req_company_code",
                table: "T_PO_Issue",
                newName: "Req_Company_Code");

            migrationBuilder.RenameColumn(
                name: "receiving_creat_date",
                table: "T_PO_Issue",
                newName: "Receiving_Creat_Date");

            migrationBuilder.RenameColumn(
                name: "receive_pic_name",
                table: "T_PO_Issue",
                newName: "Receive_PIC_Name");

            migrationBuilder.RenameColumn(
                name: "receive_creat_pic",
                table: "T_PO_Issue",
                newName: "Receive_Creat_PIC");

            migrationBuilder.RenameColumn(
                name: "receipt_regis_quantity",
                table: "T_PO_Issue",
                newName: "Receipt_Regis_Quantity");

            migrationBuilder.RenameColumn(
                name: "receipt_regis_person",
                table: "T_PO_Issue",
                newName: "Receipt_Regis_Person");

            migrationBuilder.RenameColumn(
                name: "receipt_regis_date",
                table: "T_PO_Issue",
                newName: "Receipt_Regis_Date");

            migrationBuilder.RenameColumn(
                name: "quotation_req_date",
                table: "T_PO_Issue",
                newName: "Quotation_Req_Date");

            migrationBuilder.RenameColumn(
                name: "quotation_reply_date",
                table: "T_PO_Issue",
                newName: "Quotation_Reply_Date");

            migrationBuilder.RenameColumn(
                name: "quotation_no",
                table: "T_PO_Issue",
                newName: "Quotation_No");

            migrationBuilder.RenameColumn(
                name: "program_update_date",
                table: "T_PO_Issue",
                newName: "Program_Update_Date");

            migrationBuilder.RenameColumn(
                name: "pr_approve_date",
                table: "T_PO_Issue",
                newName: "PR_Approve_Date");

            migrationBuilder.RenameColumn(
                name: "ordered_person_name",
                table: "T_PO_Issue",
                newName: "Ordered_Person_Name");

            migrationBuilder.RenameColumn(
                name: "ordered_company_code",
                table: "T_PO_Issue",
                newName: "Ordered_Company_Code");

            migrationBuilder.RenameColumn(
                name: "order_sheet_output_class",
                table: "T_PO_Issue",
                newName: "Order_Sheet_Output_Class");

            migrationBuilder.RenameColumn(
                name: "order_remain_quantity",
                table: "T_PO_Issue",
                newName: "Order_Remain_Quantity");

            migrationBuilder.RenameColumn(
                name: "order_reason_class",
                table: "T_PO_Issue",
                newName: "Order_Reason_Class");

            migrationBuilder.RenameColumn(
                name: "order_lead_time",
                table: "T_PO_Issue",
                newName: "Order_Lead_Time");

            migrationBuilder.RenameColumn(
                name: "order_cheapest_supp_quotation",
                table: "T_PO_Issue",
                newName: "Order_Cheapest_Supp_Quotation");

            migrationBuilder.RenameColumn(
                name: "order_approver4",
                table: "T_PO_Issue",
                newName: "Order_Approver4");

            migrationBuilder.RenameColumn(
                name: "order_approver3",
                table: "T_PO_Issue",
                newName: "Order_Approver3");

            migrationBuilder.RenameColumn(
                name: "order_approver2",
                table: "T_PO_Issue",
                newName: "Order_Approver2");

            migrationBuilder.RenameColumn(
                name: "order_approver1",
                table: "T_PO_Issue",
                newName: "Order_Approver1");

            migrationBuilder.RenameColumn(
                name: "ok_amount",
                table: "T_PO_Issue",
                newName: "OK_Amount");

            migrationBuilder.RenameColumn(
                name: "officlal_unitprice_changeplan_date",
                table: "T_PO_Issue",
                newName: "Officlal_UnitPrice_ChangePlan_Date");

            migrationBuilder.RenameColumn(
                name: "ng_amount",
                table: "T_PO_Issue",
                newName: "NG_Amount");

            migrationBuilder.RenameColumn(
                name: "maximum_unit_price",
                table: "T_PO_Issue",
                newName: "Maximum_Unit_Price");

            migrationBuilder.RenameColumn(
                name: "lead_time_reply_quotation",
                table: "T_PO_Issue",
                newName: "Lead_Time_Reply_Quotation");

            migrationBuilder.RenameColumn(
                name: "install_adjust_flag",
                table: "T_PO_Issue",
                newName: "Install_Adjust_Flag");

            migrationBuilder.RenameColumn(
                name: "inspec_timeday",
                table: "T_PO_Issue",
                newName: "Inspec_TimeDay");

            migrationBuilder.RenameColumn(
                name: "inspec_receive_pic",
                table: "T_PO_Issue",
                newName: "Inspec_Receive_PIC");

            migrationBuilder.RenameColumn(
                name: "inspec_receive_creat_date",
                table: "T_PO_Issue",
                newName: "Inspec_Receive_Creat_Date");

            migrationBuilder.RenameColumn(
                name: "inspec_pic_name",
                table: "T_PO_Issue",
                newName: "Inspec_PIC_Name");

            migrationBuilder.RenameColumn(
                name: "inspec_creditdebit_approver",
                table: "T_PO_Issue",
                newName: "Inspec_CreditDebit_Approver");

            migrationBuilder.RenameColumn(
                name: "full_quotation_replyno",
                table: "T_PO_Issue",
                newName: "Full_Quotation_ReplyNo");

            migrationBuilder.RenameColumn(
                name: "full_quotation_no",
                table: "T_PO_Issue",
                newName: "Full_Quotation_No");

            migrationBuilder.RenameColumn(
                name: "full_po_no",
                table: "T_PO_Issue",
                newName: "Full_PO_No");

            migrationBuilder.RenameColumn(
                name: "full_order_no",
                table: "T_PO_Issue",
                newName: "Full_Order_No");

            migrationBuilder.RenameColumn(
                name: "full_maker_code",
                table: "T_PO_Issue",
                newName: "Full_Maker_Code");

            migrationBuilder.RenameColumn(
                name: "full_buyer_code",
                table: "T_PO_Issue",
                newName: "Full_Buyer_Code");

            migrationBuilder.RenameColumn(
                name: "full_budget_code",
                table: "T_PO_Issue",
                newName: "Full_Budget_Code");

            migrationBuilder.RenameColumn(
                name: "etd_actual",
                table: "T_PO_Issue",
                newName: "ETD_Actual");

            migrationBuilder.RenameColumn(
                name: "eta_actual",
                table: "T_PO_Issue",
                newName: "ETA_Actual");

            migrationBuilder.RenameColumn(
                name: "discourse_to",
                table: "T_PO_Issue",
                newName: "Discourse_to");

            migrationBuilder.RenameColumn(
                name: "direct_delivery_class",
                table: "T_PO_Issue",
                newName: "Direct_Delivery_Class");

            migrationBuilder.RenameColumn(
                name: "dept_incharge_code",
                table: "T_PO_Issue",
                newName: "Dept_InCharge_Code");

            migrationBuilder.RenameColumn(
                name: "delivery_time_flag",
                table: "T_PO_Issue",
                newName: "Delivery_Time_Flag");

            migrationBuilder.RenameColumn(
                name: "currency_code",
                table: "T_PO_Issue",
                newName: "Currency_Code");

            migrationBuilder.RenameColumn(
                name: "creation_person",
                table: "T_PO_Issue",
                newName: "Creation_Person");

            migrationBuilder.RenameColumn(
                name: "creation_date",
                table: "T_PO_Issue",
                newName: "Creation_Date");

            migrationBuilder.RenameColumn(
                name: "company_pic_receiving",
                table: "T_PO_Issue",
                newName: "Company_PIC_Receiving");

            migrationBuilder.RenameColumn(
                name: "company_pic_inspection",
                table: "T_PO_Issue",
                newName: "Company_PIC_Inspection");

            migrationBuilder.RenameColumn(
                name: "chemical_subs_no",
                table: "T_PO_Issue",
                newName: "Chemical_Subs_No");

            migrationBuilder.RenameColumn(
                name: "check",
                table: "T_PO_Issue",
                newName: "Check");

            migrationBuilder.RenameColumn(
                name: "catalog_validity",
                table: "T_PO_Issue",
                newName: "Catalog_Validity");

            migrationBuilder.RenameColumn(
                name: "cancel_date",
                table: "T_PO_Issue",
                newName: "Cancel_date");

            migrationBuilder.RenameColumn(
                name: "buyer_name",
                table: "T_PO_Issue",
                newName: "Buyer_Name");

            migrationBuilder.RenameColumn(
                name: "attached_file_name",
                table: "T_PO_Issue",
                newName: "Attached_File_Name");

            migrationBuilder.RenameColumn(
                name: "attached_file_flag",
                table: "T_PO_Issue",
                newName: "Attached_File_Flag");

            migrationBuilder.RenameColumn(
                name: "arrival_req_date_plan",
                table: "T_PO_Issue",
                newName: "Arrival_Req_Date_Plan");

            migrationBuilder.RenameColumn(
                name: "arrival_method",
                table: "T_PO_Issue",
                newName: "Arrival_Method");

            migrationBuilder.RenameColumn(
                name: "approver_msg2",
                table: "T_PO_Issue",
                newName: "Approver_MSG2");

            migrationBuilder.RenameColumn(
                name: "approver_msg1",
                table: "T_PO_Issue",
                newName: "Approver_MSG1");

            migrationBuilder.RenameColumn(
                name: "approved_req_amount",
                table: "T_PO_Issue",
                newName: "approved_Req_amount");

            migrationBuilder.RenameColumn(
                name: "accounting_month",
                table: "T_PO_Issue",
                newName: "Accounting_Month");

            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_Oversea",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_Oversea",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "tss_result",
                table: "T_Oversea",
                newName: "TSS_Result");

            migrationBuilder.RenameColumn(
                name: "tm_rec",
                table: "T_Oversea",
                newName: "TM_REC");

            migrationBuilder.RenameColumn(
                name: "tm_po",
                table: "T_Oversea",
                newName: "TM_PO");

            migrationBuilder.RenameColumn(
                name: "tm_delv",
                table: "T_Oversea",
                newName: "TM_DELV");

            migrationBuilder.RenameColumn(
                name: "reason_shortlt",
                table: "T_Oversea",
                newName: "Reason_ShortLT");

            migrationBuilder.RenameColumn(
                name: "reason_iv",
                table: "T_Oversea",
                newName: "Reason_IV");

            migrationBuilder.RenameColumn(
                name: "reason_early",
                table: "T_Oversea",
                newName: "Reason_Early");

            migrationBuilder.RenameColumn(
                name: "reason_delay",
                table: "T_Oversea",
                newName: "Reason_Delay");

            migrationBuilder.RenameColumn(
                name: "qt_rec",
                table: "T_Oversea",
                newName: "QT_REC");

            migrationBuilder.RenameColumn(
                name: "qt_ord",
                table: "T_Oversea",
                newName: "QT_ORD");

            migrationBuilder.RenameColumn(
                name: "qt_ng",
                table: "T_Oversea",
                newName: "QT_NG");

            migrationBuilder.RenameColumn(
                name: "qt_delv_dirct",
                table: "T_Oversea",
                newName: "QT_DELV_DIRCT");

            migrationBuilder.RenameColumn(
                name: "no_split_deiv_sfx",
                table: "T_Oversea",
                newName: "NO_SPLIT_DEIV_SFX");

            migrationBuilder.RenameColumn(
                name: "no_po",
                table: "T_Oversea",
                newName: "NO_PO");

            migrationBuilder.RenameColumn(
                name: "no_parts",
                table: "T_Oversea",
                newName: "NO_PARTS");

            migrationBuilder.RenameColumn(
                name: "no_invoice",
                table: "T_Oversea",
                newName: "NO_INVOICE");

            migrationBuilder.RenameColumn(
                name: "no_draw",
                table: "T_Oversea",
                newName: "NO_DRAW");

            migrationBuilder.RenameColumn(
                name: "no_arrange",
                table: "T_Oversea",
                newName: "NO_ARRANGE");

            migrationBuilder.RenameColumn(
                name: "no_adj_dim",
                table: "T_Oversea",
                newName: "NO_ADJ_DIM");

            migrationBuilder.RenameColumn(
                name: "mk_shortlt",
                table: "T_Oversea",
                newName: "MK_ShortLT");

            migrationBuilder.RenameColumn(
                name: "mk_ontime",
                table: "T_Oversea",
                newName: "MK_ONTIME");

            migrationBuilder.RenameColumn(
                name: "mk_iv",
                table: "T_Oversea",
                newName: "MK_IV");

            migrationBuilder.RenameColumn(
                name: "mk_early",
                table: "T_Oversea",
                newName: "MK_Early");

            migrationBuilder.RenameColumn(
                name: "mk_dv",
                table: "T_Oversea",
                newName: "MK_DV");

            migrationBuilder.RenameColumn(
                name: "mk_delay",
                table: "T_Oversea",
                newName: "MK_Delay");

            migrationBuilder.RenameColumn(
                name: "iv_term",
                table: "T_Oversea",
                newName: "IV_TERM");

            migrationBuilder.RenameColumn(
                name: "early_dv",
                table: "T_Oversea",
                newName: "EARLY_DV");

            migrationBuilder.RenameColumn(
                name: "dt_rec",
                table: "T_Oversea",
                newName: "DT_REC");

            migrationBuilder.RenameColumn(
                name: "dt_po",
                table: "T_Oversea",
                newName: "DT_PO");

            migrationBuilder.RenameColumn(
                name: "dt_delv_estim",
                table: "T_Oversea",
                newName: "DT_DELV_ESTIM");

            migrationBuilder.RenameColumn(
                name: "dt_delv_dirct",
                table: "T_Oversea",
                newName: "DT_DELV_DIRCT");

            migrationBuilder.RenameColumn(
                name: "dt_delv_bal",
                table: "T_Oversea",
                newName: "DT_DELV_BAL");

            migrationBuilder.RenameColumn(
                name: "dt_delv",
                table: "T_Oversea",
                newName: "DT_DELV");

            migrationBuilder.RenameColumn(
                name: "detail_shortlt",
                table: "T_Oversea",
                newName: "Detail_ShortLT");

            migrationBuilder.RenameColumn(
                name: "detail_early",
                table: "T_Oversea",
                newName: "Detail_Early");

            migrationBuilder.RenameColumn(
                name: "detail_dv",
                table: "T_Oversea",
                newName: "Detail_DV");

            migrationBuilder.RenameColumn(
                name: "detail_delay",
                table: "T_Oversea",
                newName: "Detail_delay");

            migrationBuilder.RenameColumn(
                name: "cm_coment",
                table: "T_Oversea",
                newName: "CM_COMENT");

            migrationBuilder.RenameColumn(
                name: "ck_shortlt2",
                table: "T_Oversea",
                newName: "CK_ShortLT2");

            migrationBuilder.RenameColumn(
                name: "ck_shortlt1",
                table: "T_Oversea",
                newName: "CK_ShortLT1");

            migrationBuilder.RenameColumn(
                name: "ck_eod",
                table: "T_Oversea",
                newName: "CK_EOD");

            migrationBuilder.RenameColumn(
                name: "cf_rpt_parts_ord",
                table: "T_Oversea",
                newName: "CF_RPT_PARTS_ORD");

            migrationBuilder.RenameColumn(
                name: "cd_use_block",
                table: "T_Oversea",
                newName: "CD_USE_BLOCK");

            migrationBuilder.RenameColumn(
                name: "cd_sply_fact",
                table: "T_Oversea",
                newName: "CD_SPLY_FACT");

            migrationBuilder.RenameColumn(
                name: "cd_sply_class",
                table: "T_Oversea",
                newName: "CD_SPLY_CLASS");

            migrationBuilder.RenameColumn(
                name: "cd_sply",
                table: "T_Oversea",
                newName: "CD_SPLY");

            migrationBuilder.RenameColumn(
                name: "cd_process",
                table: "T_Oversea",
                newName: "CD_PROCESS");

            migrationBuilder.RenameColumn(
                name: "cd_ord_resn",
                table: "T_Oversea",
                newName: "CD_ORD_RESN");

            migrationBuilder.RenameColumn(
                name: "cd_insp_type_eiaj",
                table: "T_Oversea",
                newName: "CD_INSP_TYPE_EIAJ");

            migrationBuilder.RenameColumn(
                name: "cd_estim_person",
                table: "T_Oversea",
                newName: "CD_ESTIM_PERSON");

            migrationBuilder.RenameColumn(
                name: "cd_destin",
                table: "T_Oversea",
                newName: "CD_DESTIN");

            migrationBuilder.RenameColumn(
                name: "cd_delv_place",
                table: "T_Oversea",
                newName: "CD_DELV_PLACE");

            migrationBuilder.RenameColumn(
                name: "cd_chg_hist_all",
                table: "T_Oversea",
                newName: "CD_CHG_HIST_ALL");

            migrationBuilder.RenameColumn(
                name: "waybill_no",
                table: "T_Delay_ShortLT",
                newName: "waybill_No");

            migrationBuilder.RenameColumn(
                name: "waybill_date",
                table: "T_Delay_ShortLT",
                newName: "waybill_Date");

            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_Delay_ShortLT",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_Delay_ShortLT",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "unspsc_code",
                table: "T_Delay_ShortLT",
                newName: "UNSPSC_code");

            migrationBuilder.RenameColumn(
                name: "theme_id",
                table: "T_Delay_ShortLT",
                newName: "theme_ID");

            migrationBuilder.RenameColumn(
                name: "supp_site_code",
                table: "T_Delay_ShortLT",
                newName: "Supp_Site_code");

            migrationBuilder.RenameColumn(
                name: "supp_item_code",
                table: "T_Delay_ShortLT",
                newName: "supp_Item_code");

            migrationBuilder.RenameColumn(
                name: "rfq_number",
                table: "T_Delay_ShortLT",
                newName: "RFQ_Number");

            migrationBuilder.RenameColumn(
                name: "revision_no",
                table: "T_Delay_ShortLT",
                newName: "revision_No");

            migrationBuilder.RenameColumn(
                name: "received_qty",
                table: "T_Delay_ShortLT",
                newName: "Received_qty");

            migrationBuilder.RenameColumn(
                name: "receive_number",
                table: "T_Delay_ShortLT",
                newName: "receive_Number");

            migrationBuilder.RenameColumn(
                name: "promo_no",
                table: "T_Delay_ShortLT",
                newName: "ProMo_No");

            migrationBuilder.RenameColumn(
                name: "pic_receiving_acceptance",
                table: "T_Delay_ShortLT",
                newName: "PIC_receiving_acceptance");

            migrationBuilder.RenameColumn(
                name: "payment_amount_includetax",
                table: "T_Delay_ShortLT",
                newName: "payment_amount_includeTax");

            migrationBuilder.RenameColumn(
                name: "payment_amount_excludetax",
                table: "T_Delay_ShortLT",
                newName: "payment_amount_excludeTax");

            migrationBuilder.RenameColumn(
                name: "organi_code_capitalizing",
                table: "T_Delay_ShortLT",
                newName: "organi_Code_Capitalizing");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "T_Delay_ShortLT",
                newName: "order_Date");

            migrationBuilder.RenameColumn(
                name: "nvoice_no",
                table: "T_Delay_ShortLT",
                newName: "nvoice_No");

            migrationBuilder.RenameColumn(
                name: "item_desc",
                table: "T_Delay_ShortLT",
                newName: "Item_Desc");

            migrationBuilder.RenameColumn(
                name: "invoice_no_domestic",
                table: "T_Delay_ShortLT",
                newName: "invoice_No_Domestic");

            migrationBuilder.RenameColumn(
                name: "invoice_date",
                table: "T_Delay_ShortLT",
                newName: "invoice_Date");

            migrationBuilder.RenameColumn(
                name: "inspection_yn",
                table: "T_Delay_ShortLT",
                newName: "inspection_YN");

            migrationBuilder.RenameColumn(
                name: "inhouse_order",
                table: "T_Delay_ShortLT",
                newName: "Inhouse_Order");

            migrationBuilder.RenameColumn(
                name: "delivery_slipno",
                table: "T_Delay_ShortLT",
                newName: "delivery_SlipNo");

            migrationBuilder.RenameColumn(
                name: "cost_item",
                table: "T_Delay_ShortLT",
                newName: "Cost_item");

            migrationBuilder.RenameColumn(
                name: "code_fixed_assets",
                table: "T_Delay_ShortLT",
                newName: "code_Fixed_Assets");

            migrationBuilder.RenameColumn(
                name: "code_budget_fixedassets",
                table: "T_Delay_ShortLT",
                newName: "code_Budget_FixedAssets");

            migrationBuilder.RenameColumn(
                name: "check_shortlt",
                table: "T_Delay_ShortLT",
                newName: "check_ShortLT");

            migrationBuilder.RenameColumn(
                name: "check_eod",
                table: "T_Delay_ShortLT",
                newName: "check_EOD");

            migrationBuilder.RenameColumn(
                name: "champ_reserve2",
                table: "T_Delay_ShortLT",
                newName: "CHAMP_reserve2");

            migrationBuilder.RenameColumn(
                name: "champ_reserve1",
                table: "T_Delay_ShortLT",
                newName: "CHAMP_reserve1");

            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_Delay_Oversea",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_Delay_Oversea",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "today",
                table: "T_Delay_Oversea",
                newName: "Today");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "T_Delay_Oversea",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "resp_suppliercpt",
                table: "T_Delay_Oversea",
                newName: "Resp_SupplierCPT");

            migrationBuilder.RenameColumn(
                name: "requisitioner",
                table: "T_Delay_Oversea",
                newName: "Requisitioner");

            migrationBuilder.RenameColumn(
                name: "request_email",
                table: "T_Delay_Oversea",
                newName: "request_Email");

            migrationBuilder.RenameColumn(
                name: "remarks",
                table: "T_Delay_Oversea",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "remark_and_reason",
                table: "T_Delay_Oversea",
                newName: "Remark_and_Reason");

            migrationBuilder.RenameColumn(
                name: "promised_date",
                table: "T_Delay_Oversea",
                newName: "Promised_Date");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "T_Delay_Oversea",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "po_shipm_number",
                table: "T_Delay_Oversea",
                newName: "PO_Shipm_Number");

            migrationBuilder.RenameColumn(
                name: "po_number",
                table: "T_Delay_Oversea",
                newName: "PO_Number");

            migrationBuilder.RenameColumn(
                name: "po_line_number",
                table: "T_Delay_Oversea",
                newName: "PO_Line_Number");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "T_Delay_Oversea",
                newName: "Order_Date");

            migrationBuilder.RenameColumn(
                name: "item_desc",
                table: "T_Delay_Oversea",
                newName: "Item_Desc");

            migrationBuilder.RenameColumn(
                name: "inspectionyn",
                table: "T_Delay_Oversea",
                newName: "inspectionYN");

            migrationBuilder.RenameColumn(
                name: "delay",
                table: "T_Delay_Oversea",
                newName: "Delay");

            migrationBuilder.RenameColumn(
                name: "currency",
                table: "T_Delay_Oversea",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_telephone",
                table: "T_Delay_Oversea",
                newName: "buyer_PIC_telephone");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_mailddress",
                table: "T_Delay_Oversea",
                newName: "buyer_PIC_mailddress");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_company_name",
                table: "T_Delay_Oversea",
                newName: "buyer_PIC_company_name");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_belong_name",
                table: "T_Delay_Oversea",
                newName: "buyer_PIC_belong_name");

            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_Delay_Domestic",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_Delay_Domestic",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "today",
                table: "T_Delay_Domestic",
                newName: "Today");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "T_Delay_Domestic",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "resp_suppliercpt",
                table: "T_Delay_Domestic",
                newName: "Resp_SupplierCPT");

            migrationBuilder.RenameColumn(
                name: "requisitioner",
                table: "T_Delay_Domestic",
                newName: "Requisitioner");

            migrationBuilder.RenameColumn(
                name: "request_email",
                table: "T_Delay_Domestic",
                newName: "request_Email");

            migrationBuilder.RenameColumn(
                name: "remarks",
                table: "T_Delay_Domestic",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "remark_and_reason",
                table: "T_Delay_Domestic",
                newName: "Remark_and_Reason");

            migrationBuilder.RenameColumn(
                name: "promised_date",
                table: "T_Delay_Domestic",
                newName: "Promised_Date");

            migrationBuilder.RenameColumn(
                name: "po_shipm_number",
                table: "T_Delay_Domestic",
                newName: "PO_Shipm_Number");

            migrationBuilder.RenameColumn(
                name: "po_number",
                table: "T_Delay_Domestic",
                newName: "PO_Number");

            migrationBuilder.RenameColumn(
                name: "po_line_number",
                table: "T_Delay_Domestic",
                newName: "PO_Line_Number");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "T_Delay_Domestic",
                newName: "Order_Date");

            migrationBuilder.RenameColumn(
                name: "item_desc",
                table: "T_Delay_Domestic",
                newName: "Item_Desc");

            migrationBuilder.RenameColumn(
                name: "inspectionyn",
                table: "T_Delay_Domestic",
                newName: "inspectionYN");

            migrationBuilder.RenameColumn(
                name: "delay",
                table: "T_Delay_Domestic",
                newName: "Delay");

            migrationBuilder.RenameColumn(
                name: "byer_pic",
                table: "T_Delay_Domestic",
                newName: "Byer_PIC");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_telephone",
                table: "T_Delay_Domestic",
                newName: "buyer_PIC_telephone");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_mailddress",
                table: "T_Delay_Domestic",
                newName: "buyer_PIC_mailddress");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_company_name",
                table: "T_Delay_Domestic",
                newName: "buyer_PIC_company_name");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_belong_name",
                table: "T_Delay_Domestic",
                newName: "buyer_PIC_belong_name");

            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_Control_Oversea",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_Control_Oversea",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "today",
                table: "T_Control_Oversea",
                newName: "Today");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "T_Control_Oversea",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "requisitioner",
                table: "T_Control_Oversea",
                newName: "Requisitioner");

            migrationBuilder.RenameColumn(
                name: "request_email",
                table: "T_Control_Oversea",
                newName: "request_Email");

            migrationBuilder.RenameColumn(
                name: "remarks",
                table: "T_Control_Oversea",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "promised_date",
                table: "T_Control_Oversea",
                newName: "Promised_Date");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "T_Control_Oversea",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "po_shipm_number",
                table: "T_Control_Oversea",
                newName: "PO_Shipm_Number");

            migrationBuilder.RenameColumn(
                name: "po_number",
                table: "T_Control_Oversea",
                newName: "PO_Number");

            migrationBuilder.RenameColumn(
                name: "po_line_number",
                table: "T_Control_Oversea",
                newName: "PO_Line_Number");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "T_Control_Oversea",
                newName: "Order_Date");

            migrationBuilder.RenameColumn(
                name: "lt",
                table: "T_Control_Oversea",
                newName: "LT");

            migrationBuilder.RenameColumn(
                name: "item_desc",
                table: "T_Control_Oversea",
                newName: "Item_Desc");

            migrationBuilder.RenameColumn(
                name: "inspectionyn",
                table: "T_Control_Oversea",
                newName: "inspectionYN");

            migrationBuilder.RenameColumn(
                name: "delay",
                table: "T_Control_Oversea",
                newName: "Delay");

            migrationBuilder.RenameColumn(
                name: "currency",
                table: "T_Control_Oversea",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "check",
                table: "T_Control_Oversea",
                newName: "Check");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_telephone",
                table: "T_Control_Oversea",
                newName: "buyer_PIC_telephone");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_mailddress",
                table: "T_Control_Oversea",
                newName: "buyer_PIC_mailddress");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_company_name",
                table: "T_Control_Oversea",
                newName: "buyer_PIC_company_name");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_belong_name",
                table: "T_Control_Oversea",
                newName: "buyer_PIC_belong_name");

            migrationBuilder.RenameColumn(
                name: "vendor_name",
                table: "T_Control_Evalio",
                newName: "Vendor_Name");

            migrationBuilder.RenameColumn(
                name: "vendor_code",
                table: "T_Control_Evalio",
                newName: "Vendor_Code");

            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_Control_Evalio",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_Control_Evalio",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "unit_price",
                table: "T_Control_Evalio",
                newName: "Unit_Price");

            migrationBuilder.RenameColumn(
                name: "unit",
                table: "T_Control_Evalio",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "today",
                table: "T_Control_Evalio",
                newName: "Today");

            migrationBuilder.RenameColumn(
                name: "resp_suppliercpt",
                table: "T_Control_Evalio",
                newName: "Resp_supplierCPT");

            migrationBuilder.RenameColumn(
                name: "remark_and_reason",
                table: "T_Control_Evalio",
                newName: "Remark_and_Reason");

            migrationBuilder.RenameColumn(
                name: "remain",
                table: "T_Control_Evalio",
                newName: "Remain");

            migrationBuilder.RenameColumn(
                name: "received",
                table: "T_Control_Evalio",
                newName: "Received");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "T_Control_Evalio",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "prepareby",
                table: "T_Control_Evalio",
                newName: "Prepareby");

            migrationBuilder.RenameColumn(
                name: "pr_no",
                table: "T_Control_Evalio",
                newName: "PR_No");

            migrationBuilder.RenameColumn(
                name: "po_no",
                table: "T_Control_Evalio",
                newName: "PO_No");

            migrationBuilder.RenameColumn(
                name: "no",
                table: "T_Control_Evalio",
                newName: "No");

            migrationBuilder.RenameColumn(
                name: "lt",
                table: "T_Control_Evalio",
                newName: "LT");

            migrationBuilder.RenameColumn(
                name: "item_name",
                table: "T_Control_Evalio",
                newName: "Item_Name");

            migrationBuilder.RenameColumn(
                name: "item",
                table: "T_Control_Evalio",
                newName: "Item");

            migrationBuilder.RenameColumn(
                name: "issuedate",
                table: "T_Control_Evalio",
                newName: "IssueDate");

            migrationBuilder.RenameColumn(
                name: "expense_code",
                table: "T_Control_Evalio",
                newName: "Expense_Code");

            migrationBuilder.RenameColumn(
                name: "equipment_budget_code",
                table: "T_Control_Evalio",
                newName: "Equipment_Budget_Code");

            migrationBuilder.RenameColumn(
                name: "delivery_date",
                table: "T_Control_Evalio",
                newName: "Delivery_Date");

            migrationBuilder.RenameColumn(
                name: "delay",
                table: "T_Control_Evalio",
                newName: "Delay");

            migrationBuilder.RenameColumn(
                name: "currency",
                table: "T_Control_Evalio",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "center_name",
                table: "T_Control_Evalio",
                newName: "Center_Name");

            migrationBuilder.RenameColumn(
                name: "center_code",
                table: "T_Control_Evalio",
                newName: "Center_Code");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "T_Control_Domestic",
                newName: "id");
        }
    }
}
