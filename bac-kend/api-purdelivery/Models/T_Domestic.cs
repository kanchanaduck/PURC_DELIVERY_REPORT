using System;
using System.ComponentModel.DataAnnotations;

namespace api_purdelivery
{
    public class T_Domestic
    {
        public int ID	{ get; set; }
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
        public DateTime? upd_dt { get; set; }		
        public string upd_by { get; set; }			

    }
}