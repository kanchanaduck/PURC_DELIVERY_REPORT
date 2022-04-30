using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Http;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Configuration;  
using System.Data.SqlClient;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api_purdelivery;
using System.Data;

namespace api_purdelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class input_domesticController : ControllerBase
    {
        private readonly IConfiguration _config;        
        private readonly DataBaseContext _context;
        public input_domesticController(IConfiguration config,DataBaseContext context )
        {
            _config = config;
            _context = context;

        }
        // GET: api/input_domestic
        [HttpGet("get_domestic")]
        public async Task<ActionResult<IEnumerable<T_Domestic>>> GetT_Domestic()
        {
            return await _context.T_Domestic.ToListAsync();
        }
        [HttpPost("gett_euc_domestic")]
        public async Task<ActionResult<IEnumerable<T_Domestic>>> GetT_EUC_Domestic(string dt)
        {
            var Qry = "SELECT * FROM J302_PUR_DELIVERY WHERE DT_ACPTC = '"+ dt + "' ";
            var httpClient = new HttpClient();
             Console.WriteLine(dt);
              Console.WriteLine(Qry);
                HttpContent body = new StringContent("{\"command\" : \"" + Qry + "\"} ", Encoding.UTF8, "application/json");
                HttpResponseMessage data = await httpClient.PostAsync("http://cptsvs531:1000/middleware/oracle/euc", body);
                //data.EnsureSuccessStatusCode();
                var dataCallApi = await httpClient.PostAsync("http://cptsvs531:1000/middleware/oracle/euc", body);
                string result = await data.Content.ReadAsStringAsync();

                req_euc_302 dtEUC = JsonConvert.DeserializeObject<req_euc_302>(result.ToString());
                List<data> DataVendor = new List<data>(dtEUC.data);
              

            DataTable datatable = new DataTable();

           		        datatable.Columns.Add("cd_sply_class", typeof(string));
                        datatable.Columns.Add("cd_sply", typeof(string));
                        datatable.Columns.Add("cd_sply_fact", typeof(string));
                        datatable.Columns.Add("cd_ord_class", typeof(string));
                        datatable.Columns.Add("no_po", typeof(string));
                        datatable.Columns.Add("no_split_deiv_sfx", typeof(string));
                        datatable.Columns.Add("no_parts", typeof(string));
                        datatable.Columns.Add("no_adj_dim", typeof(string));
                        datatable.Columns.Add("cd_process", typeof(string));
                        datatable.Columns.Add("no_draw", typeof(string));
                        datatable.Columns.Add("cd_chg_hist_all", typeof(string));
                        datatable.Columns.Add("dt_po", typeof(string));
                        datatable.Columns.Add("tm_po", typeof(string));
                        datatable.Columns.Add("qt_ord", typeof(string));
                        datatable.Columns.Add("dt_delv", typeof(string));
                        datatable.Columns.Add("tm_delv", typeof(string));
                        datatable.Columns.Add("dt_rec", typeof(string));
                        datatable.Columns.Add("tm_rec", typeof(string));
                        datatable.Columns.Add("qt_rec", typeof(string));
                        datatable.Columns.Add("dt_acptc", typeof(string));
                        datatable.Columns.Add("tm_acptc", typeof(string));
                        datatable.Columns.Add("qt_acptd", typeof(string));
                        datatable.Columns.Add("qt_ng", typeof(string));
                        datatable.Columns.Add("cd_delv_place", typeof(string));
                        datatable.Columns.Add("cd_destin", typeof(string));
                        datatable.Columns.Add("cd_use_block", typeof(string));
                        datatable.Columns.Add("cd_ord_resn", typeof(string));
                        datatable.Columns.Add("cd_insp_type_eiaj", typeof(string));
                        datatable.Columns.Add("cd_procur_person", typeof(string));
                        datatable.Columns.Add("no_ord_class", typeof(string));
                        datatable.Columns.Add("cm_coment", typeof(string));
                        datatable.Columns.Add("cf_rpt_parts_ord", typeof(string));               
                        datatable.Columns.Add("ck_shortlt1", typeof(string));
                        datatable.Columns.Add("ck_shortlt2", typeof(string));
                        datatable.Columns.Add("ck_eod", typeof(string));
                        datatable.Columns.Add("early_dv", typeof(string));
                        datatable.Columns.Add("iv_term", typeof(string));
                        datatable.Columns.Add("tss_result", typeof(string));
                        datatable.Columns.Add("mk_shortlt", typeof(string));
                        datatable.Columns.Add("reason_shortlt", typeof(string));
                        datatable.Columns.Add("detail_shortlt", typeof(string));
                        datatable.Columns.Add("mk_delay", typeof(string));
                        datatable.Columns.Add("reason_delay", typeof(string));
                        datatable.Columns.Add("detail_delay", typeof(string));
                        datatable.Columns.Add("mk_early", typeof(string));
                        datatable.Columns.Add("reason_early", typeof(string));
                        datatable.Columns.Add("detail_early", typeof(string));
                        datatable.Columns.Add("mk_dv", typeof(string));	
                        datatable.Columns.Add("detail_dv", typeof(string));
                        datatable.Columns.Add("mk_iv", typeof(string));
                        datatable.Columns.Add("reason_iv", typeof(string));
                        datatable.Columns.Add("mk_ontime", typeof(string));
                        datatable.Columns.Add("upd_dt", typeof(string));		
                        datatable.Columns.Add("upd_by", typeof(string));

            foreach (data item in DataVendor)
            {
                datatable.Rows.Add( 
                        item.cd_sply_class,
                        item.cd_sply,
                        item.cd_sply_fact,
                        item.cd_ord_class,
                        item.no_po,
                        item.no_split_deiv_sfx,
                        item.no_parts,
                        item.no_adj_dim,
                        item.cd_process,
                        item.no_draw,
                        item.cd_chg_hist_all,
                        item.dt_po,
                        item.tm_po,
                        item.qt_ord,
                        item.dt_delv,
                        item.tm_delv,
                        item.dt_rec,
                        item.tm_rec,
                        item.qt_rec,
                        item.dt_acptc,
                        item.tm_acptc,
                        item.qt_acptd,
                        item.qt_ng,
                        item.cd_delv_place,
                        item.cd_destin,
                        item.cd_use_block,
                        item.cd_ord_resn,
                        item.cd_insp_type_eiaj,
                        item.cd_procur_person,
                        item.no_ord_class,
                        item.cm_coment,
                        item.cf_rpt_parts_ord,
                        item.ck_shortlt1,
                        item.ck_shortlt2,
                        item.ck_eod,
                        item.early_dv,
                        item.iv_term,
                        item.tss_result,
                        item.mk_shortlt,
                        item.reason_shortlt,
                        item.detail_shortlt,
                        item.mk_delay,
                        item.reason_delay,
                        item.detail_delay,
                        item.mk_early,
                        item.reason_early,
                        item.detail_early,
                        item.mk_dv,	
                        item.detail_dv,
                        item.mk_iv,
                        item.reason_iv,
                        item.mk_ontime,
                        item.upd_dt,		
                        item.upd_by );
            }
            string SqlConnectionStr = _config.GetConnectionString("ConnStr109");
            using (SqlConnection destinationConnection = new SqlConnection(SqlConnectionStr))
            {
              using (SqlBulkCopy bc= new SqlBulkCopy(destinationConnection))
              {
                        bc.DestinationTableName = "T_Domestic";
                        bc.ColumnMappings.Add("cd_sply_class", "cd_sply_class");
                        bc.ColumnMappings.Add("cd_sply", "cd_sply");
                        bc.ColumnMappings.Add("cd_sply_fact", "cd_sply_fact");
                        bc.ColumnMappings.Add("cd_ord_class", "cd_ord_class");
                        bc.ColumnMappings.Add("no_po", "no_po");
                        bc.ColumnMappings.Add("no_split_deiv_sfx", "no_split_deiv_sfx");
                        bc.ColumnMappings.Add("no_parts", "no_parts");
                        bc.ColumnMappings.Add("no_adj_dim", "no_adj_dim");
                        bc.ColumnMappings.Add("cd_process", "cd_process");
                        bc.ColumnMappings.Add("no_draw", "no_draw");
                        bc.ColumnMappings.Add("cd_chg_hist_all", "cd_chg_hist_all");
                        bc.ColumnMappings.Add("dt_po", "dt_po");
                        bc.ColumnMappings.Add("tm_po", "tm_po");
                        bc.ColumnMappings.Add("qt_ord", "qt_ord");
                        bc.ColumnMappings.Add("dt_delv", "dt_delv");
                        bc.ColumnMappings.Add("tm_delv", "tm_delv");
                        bc.ColumnMappings.Add("dt_rec", "dt_rec");
                        bc.ColumnMappings.Add("tm_rec", "tm_rec");
                        bc.ColumnMappings.Add("qt_rec", "qt_rec");
                        bc.ColumnMappings.Add("dt_acptc", "dt_acptc");
                        bc.ColumnMappings.Add("tm_acptc", "tm_acptc");
                        bc.ColumnMappings.Add("qt_acptd", "qt_acptd");
                        bc.ColumnMappings.Add("qt_ng", "qt_ng");
                        bc.ColumnMappings.Add("cd_delv_place", "cd_delv_place");
                        bc.ColumnMappings.Add("cd_destin", "cd_destin");
                        bc.ColumnMappings.Add("cd_use_block", "cd_use_block");
                        bc.ColumnMappings.Add("cd_ord_resn", "cd_ord_resn");
                        bc.ColumnMappings.Add("cd_insp_type_eiaj", "cd_insp_type_eiaj");
                        bc.ColumnMappings.Add("cd_procur_person", "cd_procur_person");
                        bc.ColumnMappings.Add("no_ord_class", "no_ord_class");
                        bc.ColumnMappings.Add("cm_coment", "cm_coment");
                        bc.ColumnMappings.Add("cf_rpt_parts_ord", "cf_rpt_parts_ord");
                        bc.ColumnMappings.Add("ck_shortlt1", "ck_shortlt1");
                        bc.ColumnMappings.Add("ck_shortlt2", "ck_shortlt2");
                        bc.ColumnMappings.Add("ck_eod", "ck_eod");
                        bc.ColumnMappings.Add("early_dv", "early_dv");
                        bc.ColumnMappings.Add("iv_term", "iv_term");
                        bc.ColumnMappings.Add("tss_result", "tss_result");
                        bc.ColumnMappings.Add("mk_shortlt", "mk_shortlt");
                        bc.ColumnMappings.Add("reason_shortlt", "reason_shortlt");
                        bc.ColumnMappings.Add("detail_shortlt", "detail_shortlt");
                        bc.ColumnMappings.Add("mk_delay", "mk_delay");
                        bc.ColumnMappings.Add("reason_delay", "reason_delay");
                        bc.ColumnMappings.Add("detail_delay", "detail_delay");
                        bc.ColumnMappings.Add("mk_early", "mk_early");
                        bc.ColumnMappings.Add("reason_early", "reason_early");
                        bc.ColumnMappings.Add("detail_early", "detail_early");
                        bc.ColumnMappings.Add("mk_dv", "mk_dv");	
                        bc.ColumnMappings.Add("detail_dv", "detail_dv");
                        bc.ColumnMappings.Add("mk_iv", "mk_iv");
                        bc.ColumnMappings.Add("reason_iv", "reason_iv");
                        bc.ColumnMappings.Add("mk_ontime", "mk_ontime");
                        bc.ColumnMappings.Add("upd_dt", "upd_dt");		
                        bc.ColumnMappings.Add("upd_by", "upd_by");		
                        destinationConnection.Open();
                        bc.WriteToServer(datatable);
                        destinationConnection.Close();
              }
            }

            var someX = (from s in  _context.T_Domestic
                        where s.dt_acptc == dt && 
                        ( !string.IsNullOrEmpty(s.mk_shortlt) || 
                        !string.IsNullOrEmpty(s.mk_delay) ||
                        !string.IsNullOrEmpty(s.mk_early) ||
                        !string.IsNullOrEmpty(s.mk_dv) ||
                        !string.IsNullOrEmpty(s.mk_iv) )
                        // (s.mk_shortlt = 'x' || s.mk_delay = 'x' || s.mk_early = 'x' || s.mk_dv = 'x' || s.mk_iv = 'x' )
                        select  s.ID).ToList();
                        
            foreach (var x in someX)
            {
                 T_Input_Domestic newDT = new T_Input_Domestic();
                        newDT.id_input = x ;
                        newDT.dt_date = dt ;
                        newDT.status_check = _config.GetValue<string>("status:wait_buyer");
                   
                    await  _context.T_Input_Domestic.AddAsync(newDT);
            }
             await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("get_domestic_search")]
        public ActionResult GetT_domestic_search([FromBody]req_search data)
        {
         string Qry = "";
         string all_data = "SELECT * FROM T_Domestic where DT_REC BETWEEN '" + data.DateSH + "' and '" + data.ToSH + "'";

            if(data.Buyer != ""){ all_data = all_data + " and cd_procur_person = '"+ data.Buyer + "'" ;}
            if(data.Vendor != ""){ all_data = all_data + " and cd_sply = '"+ data.Vendor + "'" ;}
            if(data.Part_no != ""){ all_data = all_data + " and no_parts = '"+ data.Part_no + "'" ;}
            if(data.NO_PO != ""){ all_data = all_data + " and no_po = '"+ data.NO_PO + "'" ;}
            Qry = all_data;

            if(data.Short_LT){ Qry = Qry + " union " +  all_data +  " and mk_shortlt is not null " ;}
            if(data.Delay){ Qry = Qry +  " union " +  all_data +  " and mk_delay is not null " ;}
            if(data.Early){ Qry = Qry +  " union " +  all_data +  " and mk_early is not null " ;}
            if(data.Early_over_month){ Qry =  Qry + " union " +  all_data +  " and mk_dv is not null " ;}
            if(data.IV_Term){ Qry = Qry +  " union " +  all_data +  " and mk_iv is not null " ;}
            
            Console.WriteLine(Qry);
            List<T_Domestic> lst_domestic = new List<T_Domestic>();
            string SqlConnectionStr = _config.GetConnectionString("ConnStr109");
            using (SqlConnection con = new SqlConnection(SqlConnectionStr))
            {   
                con.Open();
                string query = Qry;
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();
                
                while(reader.Read())
                {
                    T_Domestic TData  = new T_Domestic();
                    TData.ID = Convert.ToInt32(reader["ID"]) ;
                    TData.cd_sply_class = (reader["cd_sply_class"] != DBNull.Value ? Convert.ToString(reader["cd_sply_class"]):null);
                    TData.cd_sply = (reader["cd_sply"] != DBNull.Value ? Convert.ToString(reader["cd_sply"]):null);
                    TData.cd_sply_fact = (reader["cd_sply_fact"] != DBNull.Value ? Convert.ToString(reader["cd_sply_fact"]):null);
                    TData.cd_ord_class = (reader["cd_ord_class"] != DBNull.Value ? Convert.ToString(reader["cd_ord_class"]):null);
                    TData.no_po = (reader["no_po"] != DBNull.Value ? Convert.ToString(reader["no_po"]):null);
                    TData.no_split_deiv_sfx = (reader["no_split_deiv_sfx"] != DBNull.Value ? Convert.ToString(reader["no_split_deiv_sfx"]):null);
                    TData.no_parts = (reader["no_parts"] != DBNull.Value ? Convert.ToString(reader["no_parts"]):null);
                    TData.no_adj_dim = (reader["no_adj_dim"] != DBNull.Value ? Convert.ToString(reader["no_adj_dim"]):null);
                    TData.cd_process = (reader["cd_process"] != DBNull.Value ? Convert.ToString(reader["cd_process"]):null);
                    TData.no_draw = (reader["no_draw"] != DBNull.Value ? Convert.ToString(reader["no_draw"]):null);
                    TData.cd_chg_hist_all = (reader["cd_chg_hist_all"] != DBNull.Value ? Convert.ToString(reader["cd_chg_hist_all"]):null);
                    TData.dt_po = (reader["dt_po"] != DBNull.Value ? Convert.ToString(reader["dt_po"]):null);
                    TData.tm_po = (reader["tm_po"] != DBNull.Value ? Convert.ToString(reader["tm_po"]):null);
                    TData.qt_ord = (reader["qt_ord"] != DBNull.Value ? Convert.ToString(reader["qt_ord"]):null);
                    TData.dt_delv = (reader["dt_delv"] != DBNull.Value ? Convert.ToString(reader["dt_delv"]):null);
                    TData.tm_delv = (reader["tm_delv"] != DBNull.Value ? Convert.ToString(reader["tm_delv"]):null);
                    TData.dt_rec = (reader["dt_rec"] != DBNull.Value ? Convert.ToString(reader["dt_rec"]):null);
                    TData.tm_rec = (reader["tm_rec"] != DBNull.Value ? Convert.ToString(reader["tm_rec"]):null);
                    TData.qt_rec = (reader["qt_rec"] != DBNull.Value ? Convert.ToString(reader["qt_rec"]):null);
                    TData.dt_acptc = (reader["dt_acptc"] != DBNull.Value ? Convert.ToString(reader["dt_acptc"]):null);
                    TData.tm_acptc = (reader["tm_acptc"] != DBNull.Value ? Convert.ToString(reader["tm_acptc"]):null);
                    TData.qt_acptd = (reader["qt_acptd"] != DBNull.Value ? Convert.ToString(reader["qt_acptd"]):null);
                    TData.qt_ng = (reader["qt_ng"] != DBNull.Value ? Convert.ToString(reader["qt_ng"]):null);
                    TData.cd_delv_place = (reader["cd_delv_place"] != DBNull.Value ? Convert.ToString(reader["cd_delv_place"]):null);
                    TData.cd_destin = (reader["cd_destin"] != DBNull.Value ? Convert.ToString(reader["cd_destin"]):null);
                    TData.cd_use_block = (reader["cd_use_block"] != DBNull.Value ? Convert.ToString(reader["cd_use_block"]):null);
                    TData.cd_ord_resn = (reader["cd_ord_resn"] != DBNull.Value ? Convert.ToString(reader["cd_ord_resn"]):null);
                    TData.cd_insp_type_eiaj = (reader["cd_insp_type_eiaj"] != DBNull.Value ? Convert.ToString(reader["cd_insp_type_eiaj"]):null);
                    TData.cd_procur_person = (reader["cd_procur_person"] != DBNull.Value ? Convert.ToString(reader["cd_procur_person"]):null);
                    TData.no_ord_class = (reader["no_ord_class"] != DBNull.Value ? Convert.ToString(reader["no_ord_class"]):null);
                    TData.cm_coment = (reader["cm_coment"] != DBNull.Value ? Convert.ToString(reader["cm_coment"]):null);
                    TData.cf_rpt_parts_ord = (reader["cf_rpt_parts_ord"] != DBNull.Value ? Convert.ToString(reader["cf_rpt_parts_ord"]):null);
                    TData.ck_shortlt1 = (reader["ck_shortlt1"] != DBNull.Value ? Convert.ToString(reader["ck_shortlt1"]):null);
                    TData.ck_shortlt2 = (reader["ck_shortlt2"] != DBNull.Value ? Convert.ToString(reader["ck_shortlt2"]):null);
                    TData.ck_eod = (reader["ck_eod"] != DBNull.Value ? Convert.ToString(reader["ck_eod"]):null);
                    TData.early_dv = (reader["early_dv"] != DBNull.Value ? Convert.ToString(reader["early_dv"]):null);
                    TData.iv_term = (reader["iv_term"] != DBNull.Value ? Convert.ToString(reader["iv_term"]):null);
                    TData.tss_result = (reader["tss_result"] != DBNull.Value ? Convert.ToString(reader["tss_result"]):null);
                    TData.mk_shortlt = (reader["mk_shortlt"] != DBNull.Value ? Convert.ToString(reader["mk_shortlt"]):null);
                    TData.reason_shortlt = (reader["reason_shortlt"] != DBNull.Value ? Convert.ToString(reader["reason_shortlt"]):null);
                    TData.detail_shortlt = (reader["detail_shortlt"] != DBNull.Value ? Convert.ToString(reader["detail_shortlt"]):null);
                    TData.mk_delay = (reader["mk_delay"] != DBNull.Value ? Convert.ToString(reader["mk_delay"]):null);
                    TData.reason_delay = (reader["reason_delay"] != DBNull.Value ? Convert.ToString(reader["reason_delay"]):null);
                    TData.detail_delay = (reader["detail_delay"] != DBNull.Value ? Convert.ToString(reader["detail_delay"]):null);
                    TData.mk_early = (reader["mk_early"] != DBNull.Value ? Convert.ToString(reader["mk_early"]):null);
                    TData.reason_early = (reader["reason_early"] != DBNull.Value ? Convert.ToString(reader["reason_early"]):null);
                    TData.detail_early = (reader["detail_early"] != DBNull.Value ? Convert.ToString(reader["detail_early"]):null);
                    TData.mk_dv = (reader["mk_dv"] != DBNull.Value ? Convert.ToString(reader["mk_dv"]):null);
                    TData.detail_dv = (reader["detail_dv"] != DBNull.Value ? Convert.ToString(reader["detail_dv"]):null);
                    TData.mk_iv = (reader["mk_iv"] != DBNull.Value ? Convert.ToString(reader["mk_iv"]):null);
                    TData.reason_iv = (reader["reason_iv"] != DBNull.Value ? Convert.ToString(reader["reason_iv"]):null);
                    TData.mk_ontime = (reader["mk_ontime"] != DBNull.Value ? Convert.ToString(reader["mk_ontime"]):null);
                    TData.upd_dt = (reader["upd_dt"] != DBNull.Value ? Convert.ToDateTime(reader["upd_dt"]):null);
                    TData.upd_by = (reader["upd_by"] != DBNull.Value ? Convert.ToString(reader["upd_by"]):null);

                lst_domestic.Add(TData);
                }
                con.Close();
            }
             Console.WriteLine(lst_domestic);
          
            return Ok(lst_domestic);
        }

        [HttpPost("update_domestic_reason")]
        public async Task<ActionResult<T_Domestic>> update_domestic_reason([FromBody]up_reason data)
        {
                foreach( int y in data.id)
                {
                Console.WriteLine(y);
                var cust =  _context.T_Domestic.Where(x => x.ID == y ).FirstOrDefault();
                
                    cust.tss_result = data.TSS_Result;
                    cust.reason_shortlt = data.Reason_Short_LT;
                    cust.detail_shortlt = data.Detail_Short_LT_reason;
                    cust.reason_delay = data.Reason_Delay;
                    cust.detail_delay = data.Detail_delay_reason;
                    cust.reason_early = data.Reason_Early;
                    cust.detail_early = data.Detail_Early_reason;
                    // cust.detail_dv = data.
                    cust.reason_iv = data.Reason_IV;
                    _context.Update(cust);

                var sta_input = _context.T_Input_Domestic.Where(x => x.id_input == y ).FirstOrDefault(); 

                   if(sta_input != null){
                        sta_input.status_check = _config.GetValue<string>("status:wait_leader");
                        sta_input.buyer_input = "013380";//data.user;
                        sta_input.buyer_date = DateTime.Now;
                      
                        _context.Update(sta_input);
                   }
                   else if(sta_input == null){
                       T_Input_Domestic newDT = new T_Input_Domestic();
                        newDT.id_input = y;
                        newDT.status_check = _config.GetValue<string>("status:wait_leader");
                        newDT.buyer_input = "013380";
                        newDT.buyer_date = DateTime.Now;
                      
                     await _context.T_Input_Domestic.AddAsync(newDT);
                   }
               }
                await _context.SaveChangesAsync();
            
            return Ok();
        }
        [HttpPost("update_domestic_row")]
        public async Task<ActionResult<T_Domestic>> update_domestic_row(T_Domestic data)
        {
                var cust = _context.T_Domestic.Where(x => x.ID == data.ID ).FirstOrDefault();
                    cust.tss_result = data.tss_result;
                    cust.reason_shortlt = data.reason_shortlt;
                    cust.detail_shortlt = data.detail_shortlt;
                    cust.reason_delay = data.reason_delay;
                    cust.detail_delay = data.detail_delay;
                    cust.reason_early = data.reason_early;
                    cust.detail_early = data.detail_early;
                    cust.detail_dv = data.detail_dv;
                    cust.reason_iv = data.reason_iv;
                    //cust.upd_dt = DateTime;
                    // cust.upd_by = data.user;
                    _context.Update(cust);

                var sta_input = _context.T_Input_Domestic.Where(x => x.id_input == data.ID ).FirstOrDefault(); 

                   if(sta_input != null){
                        sta_input.status_check = _config.GetValue<string>("status:wait_leader");
                        sta_input.buyer_input = "013380";//data.user;
                        sta_input.buyer_date = DateTime.Now;
                      
                      _context.Update(sta_input);
                   }
                   else if(sta_input == null){
                       T_Input_Domestic newDT = new T_Input_Domestic();
                        newDT.id_input = data.ID;
                        newDT.status_check = _config.GetValue<string>("status:wait_leader");
                        newDT.buyer_input = "013380";
                        newDT.buyer_date = DateTime.Now;
                      
                     await _context.T_Input_Domestic.AddAsync(newDT);
                   }
                await _context.SaveChangesAsync();
            
            return Ok();
        }
        
    }
}
