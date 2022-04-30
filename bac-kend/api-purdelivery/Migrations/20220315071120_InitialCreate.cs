using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Control_Domestic",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Line_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Shipm_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_details_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_wdw_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_incharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_belong_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_mailddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier_site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_order_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_balanced_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    balanced_order_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspectionYN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspection_dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark_risk_degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Promised_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Today = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name_Requis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    requester_telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Control_Domestic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Control_Evalio",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PR_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delivery_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Today = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resp_supplierCPT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark_and_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Received = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit_Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendor_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vendor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prepareby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Center_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Center_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expense_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipment_Budget_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Control_Evalio", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Control_Oversea",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Line_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Shipm_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_details_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_wdw_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_incharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_belong_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_mailddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier_site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_order_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_balanced_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    balanced_order_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspectionYN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspection_dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark_risk_degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_shipping_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Promised_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Today = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transportation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requisitioner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    requester_telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Control_Oversea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Delay_Domestic",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Line_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Shipm_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_details_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_wdw_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_incharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_belong_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_mailddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier_site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_order_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_balanced_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    balanced_order_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspectionYN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspection_dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark_risk_degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Promised_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Today = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resp_SupplierCPT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark_and_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Byer_PIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requisitioner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    requester_telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Delay_Domestic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Delay_Oversea",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Line_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PO_Shipm_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_details_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_incharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_belong_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    buyer_PIC_mailddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier_site = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_order_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_balanced_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    balanced_order_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspectionYN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspection_dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    remark_risk_degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_shipping_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Promised_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Today = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resp_SupplierCPT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark_and_Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transportation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requisitioner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_dept = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    requester_telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    request_Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Delay_Oversea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Delay_ShortLT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    req_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_order_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receive_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    branch_number_debit_credit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    partition_debit_credit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RFQ_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supp_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supp_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supp_Site_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    partition_delivery_slip_output = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supp_Item_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    partition_subcontractor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    itemclass_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UNSPSC_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    class_commodity_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    wdw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    charge_to = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    charge_to_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ledg_act = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost_item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ctrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inhouse_Order = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    code_Budget_FixedAssets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    code_Fixed_Assets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    organi_Code_Capitalizing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country_origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProMo_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    regis_chemical_item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    theme_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    revision_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    temporary_up = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspection_YN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reason_notapplicable_master = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    shipped_location_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payment_terms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    promised_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    received_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receive_acceptance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    check_ShortLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    check_EOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cause = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creation_date_receiving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creation_date_acceptance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fiscal_month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stnd_price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_unit_price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payable_unit_price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_req_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_order_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Received_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receive_accep_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estimated_amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payment_amount_excludeTax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    consumption_taxamount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payment_amount_includeTax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tax_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    waybill_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nvoice_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    chargeable_free_charge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trade_terms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trade_point = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transportation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    waybill_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    invoice_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_SlipNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    invoice_No_Domestic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total_other_charge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    responsibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_req_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location_code_pur_req = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dept_code_pur_req = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dept_pur_req = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dept_code_pur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dept_pur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_incharge_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_incharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    charge_received_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    charge_received = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    charge_acceptance_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PIC_receiving_acceptance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    error_flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transaction_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_update_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_update_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creation_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHAMP_reserve1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHAMP_reserve2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Delay_ShortLT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Domestic",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CD_SPLY_CLASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_SPLY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_SPLY_FACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_ORD_CLASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_PO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_SPLIT_DEIV_SFX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_PARTS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_ADJ_DIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_PROCESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_DRAW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_CHG_HIST_ALL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_PO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TM_PO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QT_ORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_DELV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TM_DELV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_REC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TM_REC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QT_REC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_ACPTC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TM_ACPTC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QT_ACPTD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QT_NG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_DELV_PLACE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_DESTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_USE_BLOCK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_ORD_RESN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_INSP_TYPE_EIAJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_PROCUR_PERSON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_ORD_CLASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CM_COMENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CF_RPT_PARTS_ORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CK_ShortLT1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CK_ShortLT2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CK_EOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EARLY_DV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IV_TERM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TSS_Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_ShortLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason_ShortLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail_ShortLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_Delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason_Delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail_delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_Early = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason_Early = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail_Early = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_DV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail_DV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_IV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason_IV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_ONTIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Domestic", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_Oversea",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CD_SPLY_CLASS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_SPLY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_ARRANGE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_SPLY_FACT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_PO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_INVOICE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_SPLIT_DEIV_SFX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_PARTS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_ADJ_DIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_PROCESS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NO_DRAW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_CHG_HIST_ALL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_PO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TM_PO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QT_ORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_DELV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TM_DELV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_DELV_ESTIM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_DELV_DIRCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QT_DELV_DIRCT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_DELV_BAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_REC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TM_REC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QT_REC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QT_NG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_DELV_PLACE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_DESTIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_USE_BLOCK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_INSP_TYPE_EIAJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_ESTIM_PERSON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CF_RPT_PARTS_ORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CD_ORD_RESN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CM_COMENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CK_ShortLT1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CK_ShortLT2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CK_EOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EARLY_DV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IV_TERM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TSS_Result = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_ShortLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason_ShortLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail_ShortLT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_Delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason_Delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail_delay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_Early = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason_Early = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail_Early = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_DV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Detail_DV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_IV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason_IV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MK_ONTIME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Oversea", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_PO_Issue",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    item_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    requested_quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit_price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    item_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expense_from = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    account_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expense_item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    control = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit_order = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    supplier_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    approver_info = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_receive_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    budget_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asset_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usage_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receive_at = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_due_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inspection_category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    approved_Req_amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ordered_quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    finish_flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contact_person = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amount_delivered = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OK_Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NG_Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cancel_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temporary_Unit_Price_Flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Temporary_Unit_Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Standard_Unit_Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Check = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Req_Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Req_Company_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ordered_Company_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company_PIC_Receiving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company_PIC_Inspection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quotation_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Full_PO_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Full_Order_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Full_Maker_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Full_Budget_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Full_Buyer_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chemical_Subs_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UNSPSC_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supp_Selection_Reason_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit_Price_Reason_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Standard_Unit_Price_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Buyer_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Approver1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Approver2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Approver3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Approver4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PR_Approve_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RFQ1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RFQ2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RFQ3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attached_File_Flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attached_File_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subcontract_Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Reason_Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Install_Adjust_Flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receipt_Regis_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receipt_Regis_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receipt_Regis_Person = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approver_MSG1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approver_MSG2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receiving_Creat_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inspec_Receive_Creat_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receive_Creat_PIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inspec_Receive_PIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Update_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Update_Person = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creation_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creation_Person = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Sheet_Output_Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dept_InCharge_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Accounting_Month = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Req_Compny_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ordered_Person_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Receive_PIC_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inspec_PIC_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catalog_Validity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Full_Quotation_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Full_Quotation_ReplyNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quotation_Req_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quotation_Reply_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Officlal_UnitPrice_ChangePlan_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maximum_Unit_Price = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direct_Delivery_Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Lead_Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supp_Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inspec_TimeDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit_Price_Reply_Quotation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lead_Time_Reply_Quotation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supp_Reply_Quotation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Cheapest_Supp_Quotation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inspec_CreditDebit_Approver = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Delivery_Time_Flag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order_Remain_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Risk_Level_Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arrival_Req_Date_Plan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETD_Actual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ETA_Actual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Send_Delivery_Actual_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arrival_Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trade_Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_Document_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_Breakdown_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discourse_to = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RFQ_NO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Program_Update_Date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PO_Issue", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_PU",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    req_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_details_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_wdw_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_incharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_req_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ship_To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_passed_after_reception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receive_date_pur_req = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_delivery_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PU", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_PU_Abnormal",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    req_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_details_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_wdw_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_incharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_req_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ship_To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_passed_after_reception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receive_date_pur_req = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_delivery_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PU_Abnormal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "T_PU_Original",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    req_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_details_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_company_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    order_wdw_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_incharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maker_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pur_req_qty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ship_To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_passed_after_reception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    receive_date_pur_req = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    req_delivery_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UPD_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UPD_BY = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PU_Original", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_Control_Domestic");

            migrationBuilder.DropTable(
                name: "T_Control_Evalio");

            migrationBuilder.DropTable(
                name: "T_Control_Oversea");

            migrationBuilder.DropTable(
                name: "T_Delay_Domestic");

            migrationBuilder.DropTable(
                name: "T_Delay_Oversea");

            migrationBuilder.DropTable(
                name: "T_Delay_ShortLT");

            migrationBuilder.DropTable(
                name: "T_Domestic");

            migrationBuilder.DropTable(
                name: "T_Oversea");

            migrationBuilder.DropTable(
                name: "T_PO_Issue");

            migrationBuilder.DropTable(
                name: "T_PU");

            migrationBuilder.DropTable(
                name: "T_PU_Abnormal");

            migrationBuilder.DropTable(
                name: "T_PU_Original");
        }
    }
}
