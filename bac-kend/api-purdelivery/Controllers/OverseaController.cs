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
using System.ComponentModel;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http.Json;

namespace api_purdelivery.Controllers
{
    [Authorize] 
    [Route("api/[controller]")]
    [ApiController]
    public class OverseaController : ControllerBase
    {
        private readonly IConfiguration _config;        
        private readonly ApplicationDbContext _context;
        public OverseaController(IConfiguration config,ApplicationDbContext context )
        {
            _config = config;
            _context = context;
        }
        [HttpPost("EUC")]
        public async Task<ActionResult<IEnumerable<T_Oversea>>> GetT_EUC_Oversea(string dt)
        {
            var exist = _context.T_Oversea.Any(e=>e.dt_rec==dt);
            Console.WriteLine(exist);
            if(exist){
                return Conflict(@$"{dt} data is already exist.");
            }

            var Qry = "SELECT * FROM J327_PUR_DELIVERY WHERE DT_REC= '"+ dt + "' ";
            var httpClient = new HttpClient();
            Console.WriteLine(dt);
            Console.WriteLine(Qry);
            HttpContent body = new StringContent("{\"command\" : \"" + Qry + "\"} ", Encoding.UTF8, "application/json");
            HttpResponseMessage data = await httpClient.PostAsync("http://cptsvs531:1000/middleware/oracle/euc", body);
            string result = await data.Content.ReadAsStringAsync();
            dynamic dtEUC = JsonConvert.DeserializeObject(result.ToString());

            DataTable dtOversea = JsonConvert.DeserializeObject<DataTable>(dtEUC.data.ToString());

            if(!(dtOversea.Rows.Count > 0)){
                return NotFound(@$"Not found {dt} oversea data.");
            }

            string SqlConnectionStr = _config["ConnectionStrings:ConnStr109"];
            using (SqlConnection destinationConnection = new SqlConnection(SqlConnectionStr))
            {
              destinationConnection.Open();
              using (SqlBulkCopy bkCopy= new SqlBulkCopy(destinationConnection))
              {
                    bkCopy.BatchSize = dtOversea.Rows.Count;
                    bkCopy.BulkCopyTimeout = 20;
                    bkCopy.DestinationTableName = "T_Oversea";
                   
                        Console.WriteLine("Prepare writing...");
                        foreach (DataColumn d in dtOversea.Columns) 
                        { 
                            Console.WriteLine(d.ColumnName);
                            bkCopy.ColumnMappings.Add(d.ColumnName, d.ColumnName.ToLower()); 
                            Console.WriteLine(d.ColumnName.ToLower());
                        }
                        Console.WriteLine("Start writing to "+ bkCopy.DestinationTableName  +"...");
                        bkCopy.WriteToServer(dtOversea);
                        Console.WriteLine("...End writing to "+ bkCopy.DestinationTableName );
                   
                    bkCopy.Close();
              }
              destinationConnection.Close();
            }

            return Ok(@$"Pull {dt} oversea data success.");
        }

        [HttpGet]
        public async Task<ActionResult<T_Oversea>> GetT_oversea_search(
            string date_start, string date_end, string buyer, string supplier,
            Boolean ShortLT, Boolean Delay, Boolean OnTime, Boolean Early, Boolean OverMonth
        )
        {
            var oversea = await _context.T_Oversea
                        .Where(d=> 
                        ( d.dt_rec.CompareTo(date_start)>=0 && d.dt_rec.CompareTo(date_end)<=0 && 
                        (d.cd_procur_person==buyer || buyer==null) &&
                        (d.cd_sply==supplier || supplier==null) 
                        ) 
                        &&
                        (
                            ( d.mk_shortlt!=null && ShortLT)
                            ||
                            ( d.mk_delay!=null && Delay)
                            ||
                            ( d.mk_ontime!=null && OnTime)
                            ||
                            ( d.mk_early!=null && Early)
                            ||
                            ( d.mk_dv!=null && OverMonth)
                            || 
                            (
                                !( ShortLT || Delay ||  Early || OnTime || OverMonth )
                            )
                        ) 
                        ).ToListAsync();

            Console.WriteLine(oversea.Count());
            return Ok(oversea);
        }
        [HttpPut("Update/{id}")]
        public async Task<ActionResult<T_Oversea>> update_oversea_reason(int id, T_Oversea data)
        {
            var cust =  await _context.T_Oversea.Where(x => x.ID == id ).FirstOrDefaultAsync();
                
            if(data.tss_result!=null) cust.tss_result = data.tss_result ;
            if(data.reason_shortlt!=null) cust.reason_shortlt = data.reason_shortlt;
            if(data.detail_shortlt!=null) cust.detail_shortlt = data.detail_shortlt;
            if(data.reason_delay!=null) cust.reason_delay = data.reason_delay;
            if(data.detail_delay!=null) cust.detail_delay = data.detail_delay;
            if(data.reason_early!=null) cust.reason_early = data.reason_early;
            if(data.detail_early!=null) cust.detail_early = data.detail_early;
            if(data.detail_dv!=null) cust.detail_dv = data.detail_dv;
            if(data.reason_iv!=null) cust.reason_iv = data.reason_iv;

            if(data.tss_result!=null || data.reason_shortlt!=null || data.detail_shortlt!=null || 
                data.reason_delay!=null || data.detail_delay!=null || data.reason_early!=null ||
                data.detail_early!=null || data.detail_dv!=null || data.reason_iv!=null ) {
                cust.buyer_input = User.FindFirst("username").Value;
                cust.buyer_date = DateTime.Now;
            }

            if(data.leader_result!=null) {
                cust.leader_result = data.leader_result;
                cust.leader_check = User.FindFirst("username").Value;
                cust.leader_date = DateTime.Now;
            }

            if(data.manager_result!=null){
                cust.manager_result = data.manager_result;
                cust.manager_check = User.FindFirst("username").Value;
                cust.manager_date = DateTime.Now;
            }

            if(data.other_result!=null){
                cust.other_result = data.other_result;
                cust.other_check = User.FindFirst("username").Value;
                cust.other_date = DateTime.Now;
            }
            
            if(data.purc_result!=null){
                cust.purc_result = data.purc_result;
                cust.purc_check = User.FindFirst("username").Value;
                cust.purc_date = DateTime.Now;
            }

            _context.Update(cust);

            await _context.SaveChangesAsync();
            return NoContent();
        } 
        [HttpPost("InputReasonMultiple")]
        public async Task<ActionResult<T_Oversea>> input_reason_multiple(List<T_Oversea> data)
        {
            int[] ids = data.Select(e=>e.ID).ToArray();

            var cust = _context.T_Oversea.Where(x => ids.Contains(x.ID) ).ToList();
            cust.ForEach(x=>
            {
                x.tss_result = data[0].tss_result;
                x.reason_shortlt = data[0].reason_shortlt;
                x.detail_shortlt = data[0].detail_shortlt;
                x.reason_delay = data[0].reason_delay;
                x.detail_delay = data[0].detail_delay;
                x.reason_early = data[0].reason_early;
                x.detail_early = data[0].detail_early;
                x.reason_iv = data[0].reason_iv;
                x.buyer_date = DateTime.Now;
                x.buyer_input = User.FindFirst("username").Value;
            });
               
            await _context.SaveChangesAsync();
            
            return NoContent();
        }
        [HttpGet("Email")]
        public async Task<ActionResult> inform_buyer(string dt_rec)
        {
            var ng = await _context.T_Oversea.Select(e=>new {
                                e.manager_result, 
                                e.purc_result, 
                                e.leader_result, 
                                e.other_result, 
                                e.cd_sply, 
                                e.no_parts, 
                                e.no_po, 
                                e.cd_procur_person, 
                                e.dt_rec
                            })
                            .Where(e=>e.dt_rec==dt_rec && (
                                e.manager_result=="NG" ||
                                e.purc_result=="NG" ||
                                e.leader_result=="NG" ||
                                e.other_result=="NG"
                            )) 
                            .ToListAsync();

            if(ng.Count()<=0){
                return NotFound(@$"Not found NG check in {dt_rec}.");
            }

            var has_buyer_pur1 = ng.Any(e=>e.cd_procur_person.Contains("1K01"));
            var has_buyer_pur2 = ng.Any(e=>e.cd_procur_person.Contains("1K02"));
            var has_buyer_pdc = ng.Any(e=>e.cd_procur_person.Contains("1K0900"));

            string[] email_buyer_pur1 = {};
            string[] email_buyer_pur2 = {};
            string[] email_buyer_pdc = {};

            string[] email_purc =  _context.T_User.Where(e=>e.dept=="PURC").Select(e=>e.email).ToArray();

            string email_to = "";
            email_to += string.Join(";", email_purc)+";";


            if(has_buyer_pur1){
                email_buyer_pur1 = _context.T_User.Where(e=>e.dept=="PUR1").Select(e=>e.email).ToArray();
                email_to += string.Join(";", email_buyer_pur1)+";";
            }

            if(has_buyer_pur2){
                email_buyer_pur2 = _context.T_User.Where(e=>e.dept=="PUR2").Select(e=>e.email).ToArray();
                email_to += string.Join(";", email_buyer_pur2)+";";
            }

            if(has_buyer_pdc){
                email_buyer_pdc = _context.T_User.Where(e=>e.dept=="PDC").Select(e=>e.email).ToArray();
                email_to += string.Join(";", email_buyer_pdc)+";";
            }
            
            string css = @$"    <style>
                        html{{
                            font-family: Arial, Helvetica, sans-serif;
                            font-size: 14px;
                        }}
                        table {{
                            font-family: Arial, Helvetica, sans-serif;
                            border-collapse: collapse;
                            width: 80%;
                            font-size: 14px;
                        }}
                        table td, table th {{
                            border: 1px solid #ddd;
                            padding: 2px;
                        }}
                        
                        table tr:nth-child(even){{ background-color: #f2f2f2;}}
                        
                        table tr:hover {{ background-color: #ddd;}}
                        
                        table th {{
                            padding-top: 4px;
                            padding-bottom: 4px;
                            text-align: left;
                            background-color: #04AA6D;
                            color: white;
                        }}
            </style>";

            var email_body_subject = @$"[Test] [Delivery report] Please revise NG reason in Delivery report - Oversea - {dt_rec}";
            var email_body_text = @$"{css}Dear All concern, <br>
            Please revise NG reason in Delivery report below, <br>";
            
            email_body_text += "<table>";
            email_body_text += "<tr>";
            email_body_text += "<th>NO.</th>";
            email_body_text += "<th>MANAGER_CHECK</th>";
            email_body_text += "<th>PURC_CHECK</th>";
            email_body_text += "<th>LEADER_CHECK</th>";
            email_body_text += "<th>OTHER_CHECK</th>";
            email_body_text += "<th>CD_SPLY</th>";
            email_body_text += "<th>NO_PARTS</th>";
            email_body_text += "<th>NO_PO</th>";
            email_body_text += "<th>CD_PROCUR_PERSON</th>";
            email_body_text += "<th>DT_REC</th>";
            email_body_text += "</tr>";
            email_body_text += "</thead>";

            var i = 1;
            foreach (var item in ng)
            {
                email_body_text += "<tr>";
                email_body_text += @$"<td>{i}</td>";
                email_body_text += @$"<td>{ item.manager_result }</td>";
                email_body_text += @$"<td>{ item.purc_result }</td>";
                email_body_text += @$"<td>{ item.leader_result }</td>";
                email_body_text += @$"<td>{ item.other_result }</td>";
                email_body_text += @$"<td>{ item.cd_sply }</td>";
                email_body_text += @$"<td>{ item.no_parts }</td>";
                email_body_text += @$"<td>{ item.no_po }</td>";
                email_body_text += @$"<td>{ item.cd_procur_person }</td>";
                email_body_text += @$"<td>{ item.dt_rec }</td>";
                email_body_text += "</tr>";
            }

            email_body_text += "</table>";

            var myObject = new
            {
                from = User.FindFirst("email").Value,
                to = email_to,//"kanchana@mail.canon",
                subject = email_body_subject,
                html = email_body_text
            };

            var httpClient = new HttpClient();
            JsonContent body = JsonContent.Create(myObject);
            HttpResponseMessage data = await httpClient.PostAsync("http://cptsvs531:1000/middleware/email/sendmail", body);
            string result = await data.Content.ReadAsStringAsync();
            // Console.WriteLine(result);
            dynamic response = JsonConvert.DeserializeObject(result.ToString());
            if(Convert.ToBoolean(response.success)){
                return Ok();
            }
            else{
                return BadRequest();
            }
        }
        [HttpPost("OtherChecked")]
        public async Task<ActionResult<T_Oversea>> other_check(string result, List<T_Oversea> data)
        {
            int[] ids = data.Select(e=>e.ID).ToArray();

            var cust = _context.T_Oversea.Where(x => ids.Contains(x.ID) ).ToList();
            cust.ForEach(x=>
            {
                x.other_result = String.IsNullOrEmpty(result)? null:result;
                x.other_check = User.FindFirst("username").Value;
                x.other_date = DateTime.Now;
            });
               
            await _context.SaveChangesAsync();
            
            return NoContent();
        }
        [HttpPost("LeaderChecked")]
        public async Task<ActionResult<T_Oversea>> leader_check(string result, List<T_Oversea> data)
        {
            int[] ids = data.Select(e=>e.ID).ToArray();

            var cust = _context.T_Oversea.Where(x => ids.Contains(x.ID) ).ToList();
            cust.ForEach(x=>
            {
                x.leader_result = String.IsNullOrEmpty(result)? null:result;
                x.leader_check = User.FindFirst("username").Value;
                x.leader_date = DateTime.Now;
            });
               
            await _context.SaveChangesAsync();
            
            return NoContent();
        }
        
        [HttpPost("ManagerChecked")]
        public async Task<ActionResult<T_Oversea>> manager_check(string result, List<T_Oversea> data)
        {
            int[] ids = data.Select(e=>e.ID).ToArray();

            var cust = _context.T_Oversea.Where(x => ids.Contains(x.ID) ).ToList();
            cust.ForEach(x=>
            {
                x.manager_result = String.IsNullOrEmpty(result)? null:result;
                x.manager_check = User.FindFirst("username").Value;
                x.manager_date = DateTime.Now;
            });
               
            await _context.SaveChangesAsync();
            
            return NoContent();
        }

        [HttpPost("PURCChecked")]
        public async Task<ActionResult<T_Oversea>> purc_check(string result, List<T_Oversea> data)
        {
            int[] ids = data.Select(e=>e.ID).ToArray();

            var cust = _context.T_Oversea.Where(x => ids.Contains(x.ID) ).ToList();
            cust.ForEach(x=>
            {
                x.purc_result = String.IsNullOrEmpty(result)? null:result;
                x.purc_check = User.FindFirst("username").Value;
                x.purc_date = DateTime.Now;
            });
               
            await _context.SaveChangesAsync();
            
            return NoContent();
        }
        [HttpGet("DailyProgressive")]
        public async Task<ActionResult> get_weekly(string monthly)
        {
            string this_month = @$"{DateTime.Now.ToString("YYYY")}{DateTime.Now.Month.ToString("MM")}";
            monthly = string.IsNullOrEmpty(monthly)? this_month:monthly; 
            Console.WriteLine(monthly);
            var weekly =  await _context.T_Domestic
                .FromSqlRaw(@$"
                                select dt_rec, 
                                /*count(*) as _count, */
                                IIF(count(buyer_input)<count(*), 'Wait', 'Completed') as buyer_input, 
                                IIF(count(leader_result)<count(*), 'Wait', 'Completed') as leader_check , 
                                IIF(count(manager_result)<count(*), 'Wait', 'Completed')  as manager_check,
                                IIF(count(other_result)<count(*), 'Wait', 'Completed') as  other_check,
                                IIF(count(purc_result)<count(*), 'Wait', 'Completed')  as purc_check
                                from T_Oversea
                                where dt_rec like '{monthly}%'
                                group by dt_rec"
                )
                .Select(e=>new{
                    dt_rec=e.dt_rec,
                    buyer_input=e.buyer_input,
                    leader_check=e.leader_check,
                    manager_check=e.manager_check,
                    other_check=e.other_check,
                    purc_check=e.purc_check
                })
                .OrderByDescending(e=>e.dt_rec)
                .ToListAsync();
            return Ok(weekly);
        }
    }
}