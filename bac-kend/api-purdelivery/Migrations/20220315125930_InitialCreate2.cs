using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_Domestic",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_Domestic",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "TSS_Result",
                table: "T_Domestic",
                newName: "tss_result");

            migrationBuilder.RenameColumn(
                name: "TM_REC",
                table: "T_Domestic",
                newName: "tm_rec");

            migrationBuilder.RenameColumn(
                name: "TM_PO",
                table: "T_Domestic",
                newName: "tm_po");

            migrationBuilder.RenameColumn(
                name: "TM_DELV",
                table: "T_Domestic",
                newName: "tm_delv");

            migrationBuilder.RenameColumn(
                name: "TM_ACPTC",
                table: "T_Domestic",
                newName: "tm_acptc");

            migrationBuilder.RenameColumn(
                name: "Reason_ShortLT",
                table: "T_Domestic",
                newName: "reason_shortlt");

            migrationBuilder.RenameColumn(
                name: "Reason_IV",
                table: "T_Domestic",
                newName: "reason_iv");

            migrationBuilder.RenameColumn(
                name: "Reason_Early",
                table: "T_Domestic",
                newName: "reason_early");

            migrationBuilder.RenameColumn(
                name: "Reason_Delay",
                table: "T_Domestic",
                newName: "reason_delay");

            migrationBuilder.RenameColumn(
                name: "QT_REC",
                table: "T_Domestic",
                newName: "qt_rec");

            migrationBuilder.RenameColumn(
                name: "QT_ORD",
                table: "T_Domestic",
                newName: "qt_ord");

            migrationBuilder.RenameColumn(
                name: "QT_NG",
                table: "T_Domestic",
                newName: "qt_ng");

            migrationBuilder.RenameColumn(
                name: "QT_ACPTD",
                table: "T_Domestic",
                newName: "qt_acptd");

            migrationBuilder.RenameColumn(
                name: "NO_SPLIT_DEIV_SFX",
                table: "T_Domestic",
                newName: "no_split_deiv_sfx");

            migrationBuilder.RenameColumn(
                name: "NO_PO",
                table: "T_Domestic",
                newName: "no_po");

            migrationBuilder.RenameColumn(
                name: "NO_PARTS",
                table: "T_Domestic",
                newName: "no_parts");

            migrationBuilder.RenameColumn(
                name: "NO_ORD_CLASS",
                table: "T_Domestic",
                newName: "no_ord_class");

            migrationBuilder.RenameColumn(
                name: "NO_DRAW",
                table: "T_Domestic",
                newName: "no_draw");

            migrationBuilder.RenameColumn(
                name: "NO_ADJ_DIM",
                table: "T_Domestic",
                newName: "no_adj_dim");

            migrationBuilder.RenameColumn(
                name: "MK_ShortLT",
                table: "T_Domestic",
                newName: "mk_shortlt");

            migrationBuilder.RenameColumn(
                name: "MK_ONTIME",
                table: "T_Domestic",
                newName: "mk_ontime");

            migrationBuilder.RenameColumn(
                name: "MK_IV",
                table: "T_Domestic",
                newName: "mk_iv");

            migrationBuilder.RenameColumn(
                name: "MK_Early",
                table: "T_Domestic",
                newName: "mk_early");

            migrationBuilder.RenameColumn(
                name: "MK_Delay",
                table: "T_Domestic",
                newName: "mk_delay");

            migrationBuilder.RenameColumn(
                name: "MK_DV",
                table: "T_Domestic",
                newName: "mk_dv");

            migrationBuilder.RenameColumn(
                name: "IV_TERM",
                table: "T_Domestic",
                newName: "iv_term");

            migrationBuilder.RenameColumn(
                name: "EARLY_DV",
                table: "T_Domestic",
                newName: "early_dv");

            migrationBuilder.RenameColumn(
                name: "Detail_delay",
                table: "T_Domestic",
                newName: "detail_delay");

            migrationBuilder.RenameColumn(
                name: "Detail_ShortLT",
                table: "T_Domestic",
                newName: "detail_shortlt");

            migrationBuilder.RenameColumn(
                name: "Detail_Early",
                table: "T_Domestic",
                newName: "detail_early");

            migrationBuilder.RenameColumn(
                name: "Detail_DV",
                table: "T_Domestic",
                newName: "detail_dv");

            migrationBuilder.RenameColumn(
                name: "DT_REC",
                table: "T_Domestic",
                newName: "dt_rec");

            migrationBuilder.RenameColumn(
                name: "DT_PO",
                table: "T_Domestic",
                newName: "dt_po");

            migrationBuilder.RenameColumn(
                name: "DT_DELV",
                table: "T_Domestic",
                newName: "dt_delv");

            migrationBuilder.RenameColumn(
                name: "DT_ACPTC",
                table: "T_Domestic",
                newName: "dt_acptc");

            migrationBuilder.RenameColumn(
                name: "CM_COMENT",
                table: "T_Domestic",
                newName: "cm_coment");

            migrationBuilder.RenameColumn(
                name: "CK_ShortLT2",
                table: "T_Domestic",
                newName: "ck_shortlt2");

            migrationBuilder.RenameColumn(
                name: "CK_ShortLT1",
                table: "T_Domestic",
                newName: "ck_shortlt1");

            migrationBuilder.RenameColumn(
                name: "CK_EOD",
                table: "T_Domestic",
                newName: "ck_eod");

            migrationBuilder.RenameColumn(
                name: "CF_RPT_PARTS_ORD",
                table: "T_Domestic",
                newName: "cf_rpt_parts_ord");

            migrationBuilder.RenameColumn(
                name: "CD_USE_BLOCK",
                table: "T_Domestic",
                newName: "cd_use_block");

            migrationBuilder.RenameColumn(
                name: "CD_SPLY_FACT",
                table: "T_Domestic",
                newName: "cd_sply_fact");

            migrationBuilder.RenameColumn(
                name: "CD_SPLY_CLASS",
                table: "T_Domestic",
                newName: "cd_sply_class");

            migrationBuilder.RenameColumn(
                name: "CD_SPLY",
                table: "T_Domestic",
                newName: "cd_sply");

            migrationBuilder.RenameColumn(
                name: "CD_PROCUR_PERSON",
                table: "T_Domestic",
                newName: "cd_procur_person");

            migrationBuilder.RenameColumn(
                name: "CD_PROCESS",
                table: "T_Domestic",
                newName: "cd_process");

            migrationBuilder.RenameColumn(
                name: "CD_ORD_RESN",
                table: "T_Domestic",
                newName: "cd_ord_resn");

            migrationBuilder.RenameColumn(
                name: "CD_ORD_CLASS",
                table: "T_Domestic",
                newName: "cd_ord_class");

            migrationBuilder.RenameColumn(
                name: "CD_INSP_TYPE_EIAJ",
                table: "T_Domestic",
                newName: "cd_insp_type_eiaj");

            migrationBuilder.RenameColumn(
                name: "CD_DESTIN",
                table: "T_Domestic",
                newName: "cd_destin");

            migrationBuilder.RenameColumn(
                name: "CD_DELV_PLACE",
                table: "T_Domestic",
                newName: "cd_delv_place");

            migrationBuilder.RenameColumn(
                name: "CD_CHG_HIST_ALL",
                table: "T_Domestic",
                newName: "cd_chg_hist_all");

            migrationBuilder.RenameColumn(
                name: "request_Email",
                table: "T_Control_Domestic",
                newName: "request_email");

            migrationBuilder.RenameColumn(
                name: "inspectionYN",
                table: "T_Control_Domestic",
                newName: "inspectionyn");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_telephone",
                table: "T_Control_Domestic",
                newName: "buyer_pic_telephone");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_mailddress",
                table: "T_Control_Domestic",
                newName: "buyer_pic_mailddress");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_company_name",
                table: "T_Control_Domestic",
                newName: "buyer_pic_company_name");

            migrationBuilder.RenameColumn(
                name: "buyer_PIC_belong_name",
                table: "T_Control_Domestic",
                newName: "buyer_pic_belong_name");

            migrationBuilder.RenameColumn(
                name: "UPD_DT",
                table: "T_Control_Domestic",
                newName: "upd_dt");

            migrationBuilder.RenameColumn(
                name: "UPD_BY",
                table: "T_Control_Domestic",
                newName: "upd_by");

            migrationBuilder.RenameColumn(
                name: "Today",
                table: "T_Control_Domestic",
                newName: "today");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "T_Control_Domestic",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Remarks",
                table: "T_Control_Domestic",
                newName: "remarks");

            migrationBuilder.RenameColumn(
                name: "Promised_Date",
                table: "T_Control_Domestic",
                newName: "promised_date");

            migrationBuilder.RenameColumn(
                name: "PO_Shipm_Number",
                table: "T_Control_Domestic",
                newName: "po_shipm_number");

            migrationBuilder.RenameColumn(
                name: "PO_Number",
                table: "T_Control_Domestic",
                newName: "po_number");

            migrationBuilder.RenameColumn(
                name: "PO_Line_Number",
                table: "T_Control_Domestic",
                newName: "po_line_number");

            migrationBuilder.RenameColumn(
                name: "Order_Date",
                table: "T_Control_Domestic",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "Name_Requis",
                table: "T_Control_Domestic",
                newName: "name_requis");

            migrationBuilder.RenameColumn(
                name: "LT",
                table: "T_Control_Domestic",
                newName: "lt");

            migrationBuilder.RenameColumn(
                name: "Item_Desc",
                table: "T_Control_Domestic",
                newName: "item_desc");

            migrationBuilder.RenameColumn(
                name: "Delay",
                table: "T_Control_Domestic",
                newName: "delay");

            migrationBuilder.RenameColumn(
                name: "Check",
                table: "T_Control_Domestic",
                newName: "check");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "T_Control_Domestic",
                newName: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_Domestic",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_Domestic",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "tss_result",
                table: "T_Domestic",
                newName: "TSS_Result");

            migrationBuilder.RenameColumn(
                name: "tm_rec",
                table: "T_Domestic",
                newName: "TM_REC");

            migrationBuilder.RenameColumn(
                name: "tm_po",
                table: "T_Domestic",
                newName: "TM_PO");

            migrationBuilder.RenameColumn(
                name: "tm_delv",
                table: "T_Domestic",
                newName: "TM_DELV");

            migrationBuilder.RenameColumn(
                name: "tm_acptc",
                table: "T_Domestic",
                newName: "TM_ACPTC");

            migrationBuilder.RenameColumn(
                name: "reason_shortlt",
                table: "T_Domestic",
                newName: "Reason_ShortLT");

            migrationBuilder.RenameColumn(
                name: "reason_iv",
                table: "T_Domestic",
                newName: "Reason_IV");

            migrationBuilder.RenameColumn(
                name: "reason_early",
                table: "T_Domestic",
                newName: "Reason_Early");

            migrationBuilder.RenameColumn(
                name: "reason_delay",
                table: "T_Domestic",
                newName: "Reason_Delay");

            migrationBuilder.RenameColumn(
                name: "qt_rec",
                table: "T_Domestic",
                newName: "QT_REC");

            migrationBuilder.RenameColumn(
                name: "qt_ord",
                table: "T_Domestic",
                newName: "QT_ORD");

            migrationBuilder.RenameColumn(
                name: "qt_ng",
                table: "T_Domestic",
                newName: "QT_NG");

            migrationBuilder.RenameColumn(
                name: "qt_acptd",
                table: "T_Domestic",
                newName: "QT_ACPTD");

            migrationBuilder.RenameColumn(
                name: "no_split_deiv_sfx",
                table: "T_Domestic",
                newName: "NO_SPLIT_DEIV_SFX");

            migrationBuilder.RenameColumn(
                name: "no_po",
                table: "T_Domestic",
                newName: "NO_PO");

            migrationBuilder.RenameColumn(
                name: "no_parts",
                table: "T_Domestic",
                newName: "NO_PARTS");

            migrationBuilder.RenameColumn(
                name: "no_ord_class",
                table: "T_Domestic",
                newName: "NO_ORD_CLASS");

            migrationBuilder.RenameColumn(
                name: "no_draw",
                table: "T_Domestic",
                newName: "NO_DRAW");

            migrationBuilder.RenameColumn(
                name: "no_adj_dim",
                table: "T_Domestic",
                newName: "NO_ADJ_DIM");

            migrationBuilder.RenameColumn(
                name: "mk_shortlt",
                table: "T_Domestic",
                newName: "MK_ShortLT");

            migrationBuilder.RenameColumn(
                name: "mk_ontime",
                table: "T_Domestic",
                newName: "MK_ONTIME");

            migrationBuilder.RenameColumn(
                name: "mk_iv",
                table: "T_Domestic",
                newName: "MK_IV");

            migrationBuilder.RenameColumn(
                name: "mk_early",
                table: "T_Domestic",
                newName: "MK_Early");

            migrationBuilder.RenameColumn(
                name: "mk_dv",
                table: "T_Domestic",
                newName: "MK_DV");

            migrationBuilder.RenameColumn(
                name: "mk_delay",
                table: "T_Domestic",
                newName: "MK_Delay");

            migrationBuilder.RenameColumn(
                name: "iv_term",
                table: "T_Domestic",
                newName: "IV_TERM");

            migrationBuilder.RenameColumn(
                name: "early_dv",
                table: "T_Domestic",
                newName: "EARLY_DV");

            migrationBuilder.RenameColumn(
                name: "dt_rec",
                table: "T_Domestic",
                newName: "DT_REC");

            migrationBuilder.RenameColumn(
                name: "dt_po",
                table: "T_Domestic",
                newName: "DT_PO");

            migrationBuilder.RenameColumn(
                name: "dt_delv",
                table: "T_Domestic",
                newName: "DT_DELV");

            migrationBuilder.RenameColumn(
                name: "dt_acptc",
                table: "T_Domestic",
                newName: "DT_ACPTC");

            migrationBuilder.RenameColumn(
                name: "detail_shortlt",
                table: "T_Domestic",
                newName: "Detail_ShortLT");

            migrationBuilder.RenameColumn(
                name: "detail_early",
                table: "T_Domestic",
                newName: "Detail_Early");

            migrationBuilder.RenameColumn(
                name: "detail_dv",
                table: "T_Domestic",
                newName: "Detail_DV");

            migrationBuilder.RenameColumn(
                name: "detail_delay",
                table: "T_Domestic",
                newName: "Detail_delay");

            migrationBuilder.RenameColumn(
                name: "cm_coment",
                table: "T_Domestic",
                newName: "CM_COMENT");

            migrationBuilder.RenameColumn(
                name: "ck_shortlt2",
                table: "T_Domestic",
                newName: "CK_ShortLT2");

            migrationBuilder.RenameColumn(
                name: "ck_shortlt1",
                table: "T_Domestic",
                newName: "CK_ShortLT1");

            migrationBuilder.RenameColumn(
                name: "ck_eod",
                table: "T_Domestic",
                newName: "CK_EOD");

            migrationBuilder.RenameColumn(
                name: "cf_rpt_parts_ord",
                table: "T_Domestic",
                newName: "CF_RPT_PARTS_ORD");

            migrationBuilder.RenameColumn(
                name: "cd_use_block",
                table: "T_Domestic",
                newName: "CD_USE_BLOCK");

            migrationBuilder.RenameColumn(
                name: "cd_sply_fact",
                table: "T_Domestic",
                newName: "CD_SPLY_FACT");

            migrationBuilder.RenameColumn(
                name: "cd_sply_class",
                table: "T_Domestic",
                newName: "CD_SPLY_CLASS");

            migrationBuilder.RenameColumn(
                name: "cd_sply",
                table: "T_Domestic",
                newName: "CD_SPLY");

            migrationBuilder.RenameColumn(
                name: "cd_procur_person",
                table: "T_Domestic",
                newName: "CD_PROCUR_PERSON");

            migrationBuilder.RenameColumn(
                name: "cd_process",
                table: "T_Domestic",
                newName: "CD_PROCESS");

            migrationBuilder.RenameColumn(
                name: "cd_ord_resn",
                table: "T_Domestic",
                newName: "CD_ORD_RESN");

            migrationBuilder.RenameColumn(
                name: "cd_ord_class",
                table: "T_Domestic",
                newName: "CD_ORD_CLASS");

            migrationBuilder.RenameColumn(
                name: "cd_insp_type_eiaj",
                table: "T_Domestic",
                newName: "CD_INSP_TYPE_EIAJ");

            migrationBuilder.RenameColumn(
                name: "cd_destin",
                table: "T_Domestic",
                newName: "CD_DESTIN");

            migrationBuilder.RenameColumn(
                name: "cd_delv_place",
                table: "T_Domestic",
                newName: "CD_DELV_PLACE");

            migrationBuilder.RenameColumn(
                name: "cd_chg_hist_all",
                table: "T_Domestic",
                newName: "CD_CHG_HIST_ALL");

            migrationBuilder.RenameColumn(
                name: "upd_dt",
                table: "T_Control_Domestic",
                newName: "UPD_DT");

            migrationBuilder.RenameColumn(
                name: "upd_by",
                table: "T_Control_Domestic",
                newName: "UPD_BY");

            migrationBuilder.RenameColumn(
                name: "today",
                table: "T_Control_Domestic",
                newName: "Today");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "T_Control_Domestic",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "request_email",
                table: "T_Control_Domestic",
                newName: "request_Email");

            migrationBuilder.RenameColumn(
                name: "remarks",
                table: "T_Control_Domestic",
                newName: "Remarks");

            migrationBuilder.RenameColumn(
                name: "promised_date",
                table: "T_Control_Domestic",
                newName: "Promised_Date");

            migrationBuilder.RenameColumn(
                name: "po_shipm_number",
                table: "T_Control_Domestic",
                newName: "PO_Shipm_Number");

            migrationBuilder.RenameColumn(
                name: "po_number",
                table: "T_Control_Domestic",
                newName: "PO_Number");

            migrationBuilder.RenameColumn(
                name: "po_line_number",
                table: "T_Control_Domestic",
                newName: "PO_Line_Number");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "T_Control_Domestic",
                newName: "Order_Date");

            migrationBuilder.RenameColumn(
                name: "name_requis",
                table: "T_Control_Domestic",
                newName: "Name_Requis");

            migrationBuilder.RenameColumn(
                name: "lt",
                table: "T_Control_Domestic",
                newName: "LT");

            migrationBuilder.RenameColumn(
                name: "item_desc",
                table: "T_Control_Domestic",
                newName: "Item_Desc");

            migrationBuilder.RenameColumn(
                name: "inspectionyn",
                table: "T_Control_Domestic",
                newName: "inspectionYN");

            migrationBuilder.RenameColumn(
                name: "delay",
                table: "T_Control_Domestic",
                newName: "Delay");

            migrationBuilder.RenameColumn(
                name: "check",
                table: "T_Control_Domestic",
                newName: "Check");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_telephone",
                table: "T_Control_Domestic",
                newName: "buyer_PIC_telephone");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_mailddress",
                table: "T_Control_Domestic",
                newName: "buyer_PIC_mailddress");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_company_name",
                table: "T_Control_Domestic",
                newName: "buyer_PIC_company_name");

            migrationBuilder.RenameColumn(
                name: "buyer_pic_belong_name",
                table: "T_Control_Domestic",
                newName: "buyer_PIC_belong_name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "T_Control_Domestic",
                newName: "ID");
        }
    }
}
