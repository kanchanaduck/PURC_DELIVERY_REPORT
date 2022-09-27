using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_purdelivery;

namespace api_purdelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Input_reasonpur3Controller : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Input_reasonpur3Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("get_subject_cnt_domestic")]
        public ActionResult Get_subject_cnt_domestic()
        {
            /*  var groupedList =  from c in _context.T_Control_Domestic
                                group c by new
                                    {
                                        c.subject  
                                    } into gcs
                                select new return_subject()
                                    {
                                        subject = gcs.Key.subject
                                    };
             var sbj = new List<string>();
             foreach (var W in groupedList)
                    {  sbj.Add(W.subject); }
         
            return Ok(sbj); */
            return Ok();
        }

        [HttpGet("get_subject_cnt_oversea")]
        public ActionResult Get_subject_cnt_oversea()
        {
             /* var groupedList =  from c in _context.T_Control_Oversea
                                group c by new
                                    {
                                        c.subject  
                                    } into gcs
                                select new return_subject()
                                    {
                                        subject = gcs.Key.subject
                                    };
            var sbj = new List<string>();
             foreach (var W in groupedList)
                    {  sbj.Add(W.subject); }
         
            return Ok(sbj); */
            return Ok();
        }

        [HttpGet("get_subject_cnt_evolio")]
        public ActionResult Get_subject_cnt_evolio()
        {
             /* var groupedList =  from c in _context.T_Control_Evalio
                                group c by new
                                    {
                                        c.subject  
                                    } into gcs
                                select new return_subject()
                                    {
                                        subject = gcs.Key.subject
                                    };
                var sbj = new List<string>();
                foreach (var W in groupedList)
                        {  sbj.Add(W.subject); }
         
            return Ok(sbj); */
            return Ok();
        }

        [HttpGet("get_subject_po")]
        public ActionResult Get_subject_po()
        {
            /*  var groupedList =  from c in _context.T_PO_Issue
                                group c by new
                                    {
                                        c.subject  
                                    } into gcs
                                select new return_subject()
                                    {
                                        subject = gcs.Key.subject
                                    };
            var sbj = new List<string>();
             foreach (var W in groupedList)
                    {  sbj.Add(W.subject); } 
         
            return Ok(sbj);*/
            return Ok();
        }
      
        [HttpGet("get_subject_delay_domestic")]
        public ActionResult Get_subject_delay_domestic()
        {
             /* var groupedList =  from c in _context.T_Delay_Domestic
                                group c by new
                                    {
                                        c.subject  
                                    } into gcs
                                select new return_subject()
                                    {
                                        subject = gcs.Key.subject
                                    };
            var sbj = new List<string>();
             foreach (var W in groupedList)
                    {  sbj.Add(W.subject); }
         
            return Ok(sbj); */
            return Ok();
        }

        [HttpGet("get_subject_delay_oversea")]
        public ActionResult Get_subject_delay_oversea()
        {
             /* var groupedList =  from c in _context.T_Delay_Oversea
                                group c by new
                                    {
                                        c.subject  
                                    } into gcs
                                select new return_subject()
                                    {
                                        subject = gcs.Key.subject
                                    };
            var sbj = new List<string>();
             foreach (var W in groupedList)
                    {  sbj.Add(W.subject); }
         
            return Ok(sbj); */
            return Ok();
        }

       [HttpGet("get_subject_delay_shortLT")]
        public ActionResult Get_subject_delay_shortLT()
        {
            /*  var groupedList =  from c in _context.T_Delay_ShortLT
                                group c by new
                                    {
                                        c.subject  
                                    } into gcs
                                select new return_subject()
                                    {
                                        subject = gcs.Key.subject
                                    };
            var sbj = new List<string>();
             foreach (var W in groupedList)
                    {  sbj.Add(W.subject); }
         
            return Ok(sbj); */
            return Ok();
        }

        [HttpGet("get_subject_pu")]
        public ActionResult Get_subject_pu()
        {
            /*  var groupedList =  from c in _context.T_PU_Original
                                group c by new
                                    {
                                        c.subject  
                                    } into gcs
                                select new return_subject()
                                    {
                                        subject = gcs.Key.subject
                                    };
             var sbj = new List<string>();
             foreach (var W in groupedList)
                    {  sbj.Add(W.subject); }
         
            return Ok(sbj); */
            return Ok();
        }

        [HttpGet("get_domestic_row")]
        public async Task<ActionResult<T_Control_Domestic>> get_domestic_row(string sbj)
        {
            var g = await _context.T_Control_Domestic.Where(r => r.subject == sbj).ToListAsync();
            return Ok(g);
        }

        [HttpGet("get_oversea_row")]
        public async Task<ActionResult<T_Control_Oversea>> get_oversea_row(string sbj)
        {
            var g = await _context.T_Control_Oversea.Where(r => r.subject == sbj).ToListAsync();
             return Ok(g);
        }
        
        [HttpGet("get_evolio_row")]
        public async Task<ActionResult<T_Control_Evalio>> get_evolio_row(string sbj)
        {
            var g = await _context.T_Control_Evalio.Where(r => r.subject == sbj).ToListAsync();
             return Ok(g);
        }
        
        [HttpGet("get_po_row")]
        public async Task<ActionResult<T_PO_Issue>> get_po_row(string sbj)
        {
            var g = await _context.T_PO_Issue.Where(r => r.subject == sbj).ToListAsync();
             return Ok(g);
        }
        
        [HttpGet("get_delay_domestic_row")]
        public async Task<ActionResult<T_Delay_Domestic>> get_delay_domestic_row(string sbj)
        {
            var g = await _context.T_Delay_Domestic.Where(r => r.subject == sbj).ToListAsync();
             return Ok(g);
        }

        [HttpGet("get_delay_oversea_row")]
        public async Task<ActionResult<T_Delay_Oversea>> get_delay_oversea_row(string sbj)
        {
            var g = await _context.T_Delay_Oversea.Where(r => r.subject == sbj).ToListAsync();
             return Ok(g);
        }
       
        [HttpGet("get_delay_short_row")]
        public async Task<ActionResult<T_Delay_ShortLT>> get_delay_short_row(string sbj)
        {
            var g = await _context.T_Delay_ShortLT.Where(r => r.subject == sbj).ToListAsync();
             return Ok(g);
        }
        
        [HttpGet("get_pu_row")]
        public async Task<ActionResult<T_PU>> get_pu_row(string sbj)
        {
            var g = await _context.T_PU.Where(r => r.subject == sbj).ToListAsync();
             return Ok(g);
        }
       
        [HttpGet("get_pu_abnornal_row")]
        public async Task<ActionResult<T_PU_Abnormal>> get_pu_abnornal_row(string sbj)
        {
            var g = await _context.T_PU_Abnormal.Where(r => r.subject == sbj).ToListAsync();
             return Ok(g);
        }
       
        [HttpGet("get_pu_original_row")]
        public async Task<ActionResult<T_PU_Original>> get_pu_original_row(string sbj)
        {
            var g = await _context.T_PU_Original.Where(r => r.subject == sbj).ToListAsync();
             return Ok(g);
        }
    }
}
