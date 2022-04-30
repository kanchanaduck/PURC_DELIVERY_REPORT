using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace api_purdelivery
{
    public class req_euc_302
    {
        public bool success {get; set;}
        public data[] data { get; set; }

    }

    public class data {
        public string	cd_sply_class	{ get; set; }
        public string	cd_sply	{ get; set; }
        public string	cd_sply_fact	{ get; set; }
        public string	cd_ord_class	{ get; set; }
        public string	no_po	{ get; set; }
        public string	no_split_deiv_sfx	{ get; set; }
        public string	no_parts	{ get; set; }
        public string	no_adj_dim	{ get; set; }
        public string	cd_process	{ get; set; }
        public string	no_draw	{ get; set; }
        public string	cd_chg_hist_all	{ get; set; }
        public string	dt_po	{ get; set; }
        public string	tm_po	{ get; set; }
        public string	qt_ord	{ get; set; }
        public string	dt_delv	{ get; set; }
        public string	tm_delv	{ get; set; }
        public string	dt_rec	{ get; set; }
        public string	tm_rec	{ get; set; }
        public string	qt_rec	{ get; set; }
        public string	dt_acptc	{ get; set; }
        public string	tm_acptc	{ get; set; }
        public string	qt_acptd	{ get; set; }
        public string	qt_ng	{ get; set; }
        public string	cd_delv_place	{ get; set; }
        public string	cd_destin	{ get; set; }
        public string	cd_use_block	{ get; set; }
        public string	cd_ord_resn	{ get; set; }
        public string	cd_insp_type_eiaj	{ get; set; }
        public string	cd_procur_person	{ get; set; }
        public string	no_ord_class	{ get; set; }
        public string	cm_coment	{ get; set; }
        public string	cf_rpt_parts_ord	{ get; set; }
        public string	ck_shortlt1	{ get; set; }
        public string	ck_shortlt2	{ get; set; }
        public string	ck_eod	{ get; set; }
        public string	early_dv	{ get; set; }
        public string	iv_term	{ get; set; }
        public string	tss_result	{ get; set; }
        public string	mk_shortlt	{ get; set; }
        public string	reason_shortlt	{ get; set; }
        public string	detail_shortlt	{ get; set; }
        public string	mk_delay	{ get; set; }
        public string	reason_delay	{ get; set; }
        public string	detail_delay	{ get; set; }
        public string	mk_early	{ get; set; }
        public string	reason_early	{ get; set; }
        public string	detail_early	{ get; set; }
        public string	mk_dv { get; set; }	
        public string	detail_dv	{ get; set; }
        public string	mk_iv	{ get; set; }
        public string	reason_iv	{ get; set; }
        public string	mk_ontime	{ get; set; }
        public string upd_dt { get; set; }		
        public string upd_by { get; set; }			
//--------------------Oversea-------------------------------
        public string	no_arrange	{ get; set; }
        public string	no_invoice	{ get; set; }
        public string	dt_delv_estim	{ get; set; }
        public string	dt_delv_dirct	{ get; set; }
        public string	qt_delv_dirct	{ get; set; }
        public string   dt_delv_bal { get; set; }		
        public string   cd_estim_person { get; set; }			

    }

    public class req_search
    {
        public string Buyer {get; set;}
        public string Vendor {get; set;}
        public string Part_no {get; set;}
        public string NO_PO {get; set;}
        public bool All {get; set;}
        public bool Short_LT {get; set;}
        public bool Delay {get; set;}
        public bool Early {get; set;}
        public bool Early_over_month {get; set;}
        public bool IV_Term {get; set;}
        public bool TSS {get; set;}
        public string Type {get; set;}
        public string DateSH {get; set;}
        public string ToSH {get; set;}
        // public string DateS {get; set;}
        // public string ToS {get; set;}
        

    }
   
    public class up_reason{

        public int[] id {get; set;}
        public string TSS_Result {get; set;}
        public string Reason_Short_LT {get; set;}
        public string Detail_Short_LT_reason {get; set;}
        public string Reason_Delay {get; set;}
        public string Detail_delay_reason {get; set;}
        public string Reason_Early {get; set;}
        public string Detail_Early_reason {get; set;}
        public string Detail_Over_month_reason {get; set;}
        public string Reason_IV {get; set;}
        public string user {get; set;}
    }

    public class req_upfile{
    public IFormFile fileDel_Do { get; set; }
    public IFormFile fileDel_Over { get; set; }
    public IFormFile filePO { get; set; } 
    public IFormFile fileDelay_Do { get; set; }
    public IFormFile fileDelay_Over { get; set; }   
    public IFormFile filePU { get; set; }
    public IFormFile fileDel_Evolio { get; set; }
    public IFormFile fileShortLT { get; set; }
    public string fileDel_Do_name { get; set; }
    public string fileDel_Over_name { get; set; }
    public string filePO_name { get; set; }
    public string fileDelay_Do_name { get; set; }
    public string fileDelay_Over_name { get; set; }
    public string filePU_name { get; set; }
    public string fileDel_Evolio_name { get; set; }
    public string fileShortLT_name { get; set; }
    public string update_by { get; set; }
    public string subject { get; set; }

}

    public class return_subject{
         public string subject { get; set; }
    }
}