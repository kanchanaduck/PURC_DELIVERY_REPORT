using System;
using System.ComponentModel.DataAnnotations;

namespace api_purdelivery
{
    public class T_Oversea
    {
        public int ID { get; set; }
        public string cd_sply_class { get; set; }
        public string cd_fact { get; set; }
        public string cd_sply { get; set; }
        public string no_arrange { get; set; }
        public string cd_sply_fact { get; set; }
        public string cd_ord_class { get; set; }
        public string no_po { get; set; }
        public string no_cust_clea { get; set; }
        public string no_invoice { get; set; }
        public string mk_po_chk_digit { get; set; }
        public string no_split_deiv_sfx { get; set; }
        public string no_parts { get; set; }
        public string no_adj_dim { get; set; }
        public string cd_process { get; set; }
        public string no_draw { get; set; }
        public string cd_chg_hist_all { get; set; }
        public string no_chg_hist { get; set; }
        public string no_chg_hist_sfx { get; set; }
        public string no_invent_cntl_poi { get; set; }
        public string dt_po { get; set; }
        public string tm_po { get; set; }
        public string qt_ord { get; set; }
        public string dt_delv { get; set; }
        public string tm_delv { get; set; }
        public string dt_delv_estim { get; set; }
        public string dt_delv_dirct { get; set; }
        public string qt_delv_dirct { get; set; }
        public string dt_delv_bal { get; set; }
        public string dt_rec { get; set; }
        public string tm_rec { get; set; }
        public string qt_rec { get; set; }
        public string qt_und_insp { get; set; }
        public string qt_climacs_insp { get; set; }
        public string qt_ng { get; set; }
        public string cr_delv_lot { get; set; }
        public string qt_insp_cmpl { get; set; }
        public string cd_delv_place { get; set; }
        public string cd_delv_place_offici { get; set; }
        public string cd_destin { get; set; }
        public string cd_use_block { get; set; }
        public string cd_piece { get; set; }
        public string cd_insp_type_eiaj { get; set; }
        public string cd_procur_person { get; set; }
        public string cd_estim_person { get; set; }
        public string cf_rpt_parts_ord { get; set; }
        public string cd_curr { get; set; }
        public string no_ord_class { get; set; }
        public string cf_sply_type { get; set; }
        public string nm_parts_eng { get; set; }
        public string cd_kind_parts { get; set; }
        public string cd_ctry_orig { get; set; }
        public string cd_cosmos_maker { get; set; }
        public string cm_coment { get; set; }
        public string cf_child_base { get; set; }
        public string dt_oblig_purch { get; set; }
        public string no_container { get; set; }
        public string dt_entry { get; set; }
        public string nm_entry_person { get; set; }
        public string dt_renew { get; set; }
        public string nm_renew_person { get; set; }
        public string cd_ord_resn { get; set; }
        public string nm_sply_eng { get; set; }
        public string remark { get; set; }
        public string ck_shortlt1 { get; set; }
        public string ck_shortlt2 { get; set; }
        public string ck_eod { get; set; }
        public string early_dv { get; set; }
        public string iv_term { get; set; }
        public string tss_result { get; set; }
        public string mk_shortlt { get; set; }
        public string reason_shortlt { get; set; }
        public string detail_shortlt { get; set; }
        public string mk_delay { get; set; }
        public string reason_delay { get; set; }
        public string detail_delay { get; set; }
        public string mk_early { get; set; }
        public string reason_early { get; set; }
        public string detail_early { get; set; }
        public string mk_dv { get; set; }
        public string detail_dv { get; set; }
        public string mk_iv { get; set; }
        public string reason_iv { get; set; }
        public string mk_ontime { get; set; }
        public DateTime? upd_dt { get; set; } 
        public string upd_by { get; set; } 
        public string buyer_input { get; set; }
        public DateTime? buyer_date { get; set; }
        public string leader_result { get; set; }
        public string leader_check { get; set; }
        public DateTime? leader_date { get; set; }
        public string manager_result { get; set; }
        public string manager_check { get; set; }
        public DateTime? manager_date { get; set; }
        public string other_result { get; set; }
        public string other_check { get; set; }
        public DateTime? other_date { get; set; }
        public string purc_result { get; set; }
        public string purc_check { get; set; }
        public DateTime? purc_date { get; set; }

    }

}