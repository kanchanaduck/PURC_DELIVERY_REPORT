using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api_purdelivery;
using OfficeOpenXml;
using System.Globalization;

namespace api_purdelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileReasonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly List<string> _folder;

        public FileReasonController(ApplicationDbContext context)
        {
            _context = context;
            _folder = new List<string>() {"J4","M1","M2","JP"};
        }

        // GET: api/FileReason
        [HttpGet]
        public async Task<ActionResult<IEnumerable<T_Control_Domestic>>> GetT_Control_Domestic()
        {
            return await _context.T_Control_Domestic.ToListAsync();
        }
        [HttpPost("UploadDeliveryDomestic")]
        public async Task<IActionResult> upload_delivery_demestic(IFormFile file){
            string rootFolder = Directory.GetCurrentDirectory();
            string pathString = @"\API site\files\Delivery_Domestic\";
            string serverPath = rootFolder.Substring(0, rootFolder.LastIndexOf(@"\")) + pathString;
            string fullpath = serverPath + file.FileName;

            if (!Directory.Exists(serverPath))
            {
                Directory.CreateDirectory(serverPath);
            }

            using (Stream stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Dispose();
                stream.Close();
            }

           FileInfo existingFile = new FileInfo(fullpath);
            ExcelPackage package = new ExcelPackage(existingFile);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.First();//Selected Specify page
            int rows = worksheet.Dimension.End.Row;
            int cols = worksheet.Dimension.End.Column;
            Console.WriteLine(rows);

                List<T_Control_Domestic> listNp = new List<T_Control_Domestic>();

                for (int i = 3; i <= rows; i++)
                {
                 T_Control_Domestic tbD = new T_Control_Domestic();
                    tbD.status =  Convert.ToString(worksheet.Cells[i, 1].Value);
                    tbD.po_number = Convert.ToString(worksheet.Cells[i, 2].Value);
                    tbD.po_line_number = Convert.ToString(worksheet.Cells[i, 3].Value);
                    tbD.po_shipm_number = Convert.ToString(worksheet.Cells[i, 4].Value);
                    tbD.req_no = Convert.ToString(worksheet.Cells[i, 5].Value);
                    tbD.req_details_no = Convert.ToString(worksheet.Cells[i, 6].Value);
                    tbD.order_company_code = Convert.ToString(worksheet.Cells[i, 7].Value);
                    tbD.order_wdw_code = Convert.ToString(worksheet.Cells[i, 8].Value);
                    tbD.pur_incharge = Convert.ToString(worksheet.Cells[i, 9].Value);
                    tbD.buyer_pic_company_name = Convert.ToString(worksheet.Cells[i, 10].Value);
                    tbD.buyer_pic_belong_name = Convert.ToString(worksheet.Cells[i, 11].Value);
                    tbD.buyer_pic_telephone = Convert.ToString(worksheet.Cells[i, 12].Value);
                    tbD.buyer_pic_mailddress = Convert.ToString(worksheet.Cells[i, 13].Value);
                    tbD.supplier = Convert.ToString(worksheet.Cells[i, 14].Value);
                    tbD.supplier_site = Convert.ToString(worksheet.Cells[i, 15].Value);
                    tbD.item_desc = Convert.ToString(worksheet.Cells[i, 16].Value);
                    tbD.maker_code = Convert.ToString(worksheet.Cells[i, 17].Value);
                    tbD.maker_name = Convert.ToString(worksheet.Cells[i, 18].Value);
                    tbD.type = Convert.ToString(worksheet.Cells[i, 19].Value);
                    tbD.pur_order_qty = Convert.ToString(worksheet.Cells[i, 20].Value);
                    tbD.delivery_balanced_qty = Convert.ToString(worksheet.Cells[i, 21].Value);
                    tbD.balanced_order_qty = Convert.ToString(worksheet.Cells[i, 22].Value);
                    tbD.unit   = Convert.ToString(worksheet.Cells[i, 23].Value);
                    tbD.inspectionyn = Convert.ToString(worksheet.Cells[i, 24].Value);
                    tbD.inspection_dept = Convert.ToString(worksheet.Cells[i, 25].Value);
                    tbD.remark_risk_degree = Convert.ToString(worksheet.Cells[i, 26].Value);
                    tbD.order_date = Convert.ToString(worksheet.Cells[i, 27].Value);
                    tbD.promised_date = Convert.ToString(worksheet.Cells[i, 28].Value);
                    tbD.today = Convert.ToString(worksheet.Cells[i, 29].Value);
                    tbD.delay = Convert.ToString(worksheet.Cells[i, 30].Value);
                    tbD.lt = Convert.ToString(worksheet.Cells[i, 31].Value);
                    tbD.check = Convert.ToString(worksheet.Cells[i, 32].Value);
                    tbD.name_requis = Convert.ToString(worksheet.Cells[i, 33].Value);
                    tbD.request_company = Convert.ToString(worksheet.Cells[i, 34].Value);
                    tbD.request_dept = Convert.ToString(worksheet.Cells[i, 35].Value);
                    tbD.requester_telephone = Convert.ToString(worksheet.Cells[i, 36].Value);
                    tbD.request_email = Convert.ToString(worksheet.Cells[i, 37].Value);
                    tbD.remarks = Convert.ToString(worksheet.Cells[i, 38].Value);
                    tbD.upd_dt = DateTime.Now;
                    tbD.upd_by = User.FindFirst("username").Value;
                    tbD.subject = Convert.ToDateTime(worksheet.Cells[i, 29].Value).ToString("yyyyMMdd");

                listNp.Add(tbD);
                }
                await _context.T_Control_Domestic.AddRangeAsync(listNp);

                System.IO.File.Delete(fullpath);  //Delete file new part

                await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("UploadDeliveryOversea")]
        public async Task<IActionResult> upload_delivery_oversea(IFormFile file){
            string rootFolder = Directory.GetCurrentDirectory();
            string pathString = @"\API site\files\Delivery_Oversea\";
            string serverPath = rootFolder.Substring(0, rootFolder.LastIndexOf(@"\")) + pathString;
            string fullpath = serverPath + file.FileName;
            if (!Directory.Exists(serverPath))
            {
                Directory.CreateDirectory(serverPath);
            }
            using (Stream stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Dispose();
                stream.Close();
            }
            FileInfo existingFile = new FileInfo(fullpath);
            ExcelPackage package = new ExcelPackage(existingFile);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.First();//Selected Specify page
            int rows = worksheet.Dimension.End.Row;
            int cols = worksheet.Dimension.End.Column;
            Console.WriteLine(rows);

            List<T_Control_Oversea> listNp = new List<T_Control_Oversea>();

            for (int i = 3; i <= rows; i++)
            {
                T_Control_Oversea tbD = new T_Control_Oversea();
                tbD.status = Convert.ToString(worksheet.Cells[i, 1].Value);
                tbD.po_number = Convert.ToString(worksheet.Cells[i, 2].Value);
                tbD.po_line_number = Convert.ToString(worksheet.Cells[i, 3].Value);
                tbD.po_shipm_number = Convert.ToString(worksheet.Cells[i, 4].Value);
                tbD.req_no = Convert.ToString(worksheet.Cells[i, 5].Value);
                tbD.req_details_no = Convert.ToString(worksheet.Cells[i, 6].Value);
                tbD.order_company_code = Convert.ToString(worksheet.Cells[i, 7].Value);
                tbD.order_wdw_code = Convert.ToString(worksheet.Cells[i, 8].Value);
                tbD.pur_incharge = Convert.ToString(worksheet.Cells[i, 9].Value);
                tbD.buyer_pic_company_name = Convert.ToString(worksheet.Cells[i, 10].Value);
                tbD.buyer_pic_belong_name = Convert.ToString(worksheet.Cells[i, 11].Value);
                tbD.buyer_pic_telephone = Convert.ToString(worksheet.Cells[i, 12].Value);
                tbD.buyer_pic_mailddress = Convert.ToString(worksheet.Cells[i, 13].Value);
                tbD.supplier = Convert.ToString(worksheet.Cells[i, 14].Value);
                tbD.supplier_site = Convert.ToString(worksheet.Cells[i, 15].Value);
                tbD.item_desc = Convert.ToString(worksheet.Cells[i, 16].Value);
                tbD.maker_code = Convert.ToString(worksheet.Cells[i, 17].Value);
                tbD.maker_name = Convert.ToString(worksheet.Cells[i, 18].Value);
                tbD.type = Convert.ToString(worksheet.Cells[i, 19].Value);
                tbD.price = Convert.ToString(worksheet.Cells[i, 20].Value);
                tbD.currency = Convert.ToString(worksheet.Cells[i, 21].Value);
                tbD.pur_order_qty = Convert.ToString(worksheet.Cells[i, 22].Value);
                tbD.delivery_qty = Convert.ToString(worksheet.Cells[i, 23].Value);
                tbD.delivery_balanced_qty = Convert.ToString(worksheet.Cells[i, 24].Value);
                tbD.balanced_order_qty = Convert.ToString(worksheet.Cells[i, 25].Value);
                tbD.unit   = Convert.ToString(worksheet.Cells[i, 26].Value);
                tbD.inspectionyn = Convert.ToString(worksheet.Cells[i, 27].Value);
                tbD.inspection_dept = Convert.ToString(worksheet.Cells[i, 28].Value);
                tbD.remark_risk_degree = Convert.ToString(worksheet.Cells[i, 29].Value);
                tbD.order_date = Convert.ToString(worksheet.Cells[i, 30].Value);
                tbD.req_shipping_date = Convert.ToString(worksheet.Cells[i, 31].Value);
                tbD.promised_date = Convert.ToString(worksheet.Cells[i, 32].Value);
                tbD.today = Convert.ToString(worksheet.Cells[i, 33].Value);
                tbD.delay = Convert.ToString(worksheet.Cells[i, 34].Value);
                tbD.lt = Convert.ToString(worksheet.Cells[i, 35].Value);
                tbD.check = Convert.ToString(worksheet.Cells[i, 36].Value);
                tbD.transportation = Convert.ToString(worksheet.Cells[i, 37].Value);
                tbD.requisitioner = Convert.ToString(worksheet.Cells[i, 38].Value);
                tbD.request_company = Convert.ToString(worksheet.Cells[i, 39].Value);
                tbD.request_dept = Convert.ToString(worksheet.Cells[i, 40].Value);
                tbD.requester_telephone = Convert.ToString(worksheet.Cells[i, 41].Value);
                tbD.request_email = Convert.ToString(worksheet.Cells[i, 42].Value);
                tbD.remarks = Convert.ToString(worksheet.Cells[i, 43].Value);
                tbD.upd_dt = DateTime.Now;
                tbD.upd_by = User.FindFirst("username").Value;
                tbD.subject = Convert.ToDateTime(worksheet.Cells[i, 33].Value).ToString("yyyyMMdd");

            listNp.Add(tbD);
            }
                await _context.T_Control_Oversea.AddRangeAsync(listNp);

            System.IO.File.Delete(fullpath);  //Delete file new part

            await _context.SaveChangesAsync();
                
            return Ok();
        }
 
        [HttpPost("UploadPOIssued")]
        public async Task<IActionResult> upload_po_issued(IFormFile file){
             string rootFolder = Directory.GetCurrentDirectory();
             string pathString = @"\API site\files\pur_delivery\PO_Issued\";
             string serverPath = rootFolder.Substring(0, rootFolder.LastIndexOf(@"\")) + pathString;
                if (!Directory.Exists(serverPath))
                {
                    Directory.CreateDirectory(serverPath);
                }
            string fullpath = serverPath + file.FileName;
            using (Stream stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Dispose();
                stream.Close();
            }
                FileInfo existingFile = new FileInfo(fullpath);
                ExcelPackage package = new ExcelPackage(existingFile);
                ExcelWorksheet worksheet = package.Workbook.Worksheets.First();//Selected Specify page
                int rows = worksheet.Dimension.End.Row;
                int cols = worksheet.Dimension.End.Column;
                Console.WriteLine(rows);

                List<T_PO_Issue> listNp = new List<T_PO_Issue>();

                for (int i = 3; i <= rows; i++)
                {
                 T_PO_Issue tbD = new T_PO_Issue();
                   tbD.item_name = Convert.ToString(worksheet.Cells[i, 1].Value);
                    tbD.requested_quantity = Convert.ToString(worksheet.Cells[i, 2].Value);
                    tbD.unit_price = Convert.ToString(worksheet.Cells[i, 3].Value);
                    tbD.item_code = Convert.ToString(worksheet.Cells[i, 4].Value);
                    tbD.expense_from = Convert.ToString(worksheet.Cells[i, 5].Value);
                    tbD.account_code = Convert.ToString(worksheet.Cells[i, 6].Value);
                    tbD.expense_item = Convert.ToString(worksheet.Cells[i, 7].Value);
                    tbD.control = Convert.ToString(worksheet.Cells[i, 8].Value);
                    tbD.unit_order = Convert.ToString(worksheet.Cells[i, 9].Value);
                    tbD.supplier_code = Convert.ToString(worksheet.Cells[i, 10].Value);
                    tbD.supplier_name = Convert.ToString(worksheet.Cells[i, 11].Value);
                    tbD.req_code = Convert.ToString(worksheet.Cells[i, 12].Value);
                    tbD.req_info = Convert.ToString(worksheet.Cells[i, 13].Value);
                    tbD.req_email = Convert.ToString(worksheet.Cells[i, 14].Value);
                    tbD.req_date = Convert.ToString(worksheet.Cells[i, 15].Value);
                    tbD.approver_info = Convert.ToString(worksheet.Cells[i, 16].Value);
                    tbD.req_receive_date = Convert.ToString(worksheet.Cells[i, 17].Value);
                    tbD.order_date = Convert.ToString(worksheet.Cells[i, 18].Value);
                    tbD.order_number = Convert.ToString(worksheet.Cells[i, 19].Value);
                    tbD.budget_code = Convert.ToString(worksheet.Cells[i, 20].Value);
                    tbD.asset_code = Convert.ToString(worksheet.Cells[i, 21].Value);
                    tbD.usage_at = Convert.ToString(worksheet.Cells[i, 22].Value);
                    tbD.receive_at = Convert.ToString(worksheet.Cells[i, 23].Value);
                    tbD.req_due_date = Convert.ToString(worksheet.Cells[i, 24].Value);
                    tbD.delivery_date = Convert.ToString(worksheet.Cells[i, 25].Value);
                    tbD.model = Convert.ToString(worksheet.Cells[i, 26].Value);
                    tbD.inspection_category = Convert.ToString(worksheet.Cells[i, 27].Value);
                    tbD.approved_req_amount = Convert.ToString(worksheet.Cells[i, 28].Value);
                    tbD.ordered_quantity = Convert.ToString(worksheet.Cells[i, 29].Value);
                    tbD.finish_flag = Convert.ToString(worksheet.Cells[i, 30].Value);
                    tbD.maker_name = Convert.ToString(worksheet.Cells[i, 31].Value);
                    tbD.contact_person = Convert.ToString(worksheet.Cells[i, 32].Value);
                    tbD.amount_delivered = Convert.ToString(worksheet.Cells[i, 33].Value);
                    tbD.ok_amount = Convert.ToString(worksheet.Cells[i, 34].Value);
                    tbD.ng_amount = Convert.ToString(worksheet.Cells[i, 35].Value);
                    tbD.cancel_date = Convert.ToString(worksheet.Cells[i, 36].Value);
                    tbD.temporary_unit_price_flag = Convert.ToString(worksheet.Cells[i, 37].Value);
                    tbD.temporary_unit_price = Convert.ToString(worksheet.Cells[i, 38].Value);
                    tbD.standard_unit_price = Convert.ToString(worksheet.Cells[i, 39].Value);
                    tbD.check = Convert.ToString(worksheet.Cells[i, 40].Value);
                    tbD.req_unit = Convert.ToString(worksheet.Cells[i, 41].Value);
                    tbD.req_company_code = Convert.ToString(worksheet.Cells[i, 42].Value);
                    tbD.ordered_company_code = Convert.ToString(worksheet.Cells[i, 43].Value);
                    tbD.company_pic_receiving = Convert.ToString(worksheet.Cells[i, 44].Value);
                    tbD.company_pic_inspection = Convert.ToString(worksheet.Cells[i, 45].Value);
                    tbD.quotation_no = Convert.ToString(worksheet.Cells[i, 46].Value);
                    tbD.full_po_no = Convert.ToString(worksheet.Cells[i, 47].Value);
                    tbD.full_order_no = Convert.ToString(worksheet.Cells[i, 48].Value);
                    tbD.full_maker_code = Convert.ToString(worksheet.Cells[i, 49].Value);
                    tbD.full_budget_code = Convert.ToString(worksheet.Cells[i, 50].Value);
                    tbD.full_buyer_code = Convert.ToString(worksheet.Cells[i, 51].Value);
                    tbD.chemical_subs_no = Convert.ToString(worksheet.Cells[i, 52].Value);
                    tbD.unspsc_code = Convert.ToString(worksheet.Cells[i, 53].Value);
                    tbD.supp_selection_reason_code = Convert.ToString(worksheet.Cells[i, 54].Value);
                    tbD.unit_price_reason_code = Convert.ToString(worksheet.Cells[i, 55].Value);
                    tbD.standard_unit_price_code = Convert.ToString(worksheet.Cells[i, 56].Value);
                    tbD.buyer_name = Convert.ToString(worksheet.Cells[i, 57].Value);
                    tbD.order_approver1 = Convert.ToString(worksheet.Cells[i, 58].Value);
                    tbD.order_approver2 = Convert.ToString(worksheet.Cells[i, 59].Value);
                    tbD.order_approver3 = Convert.ToString(worksheet.Cells[i, 60].Value);
                    tbD.order_approver4 = Convert.ToString(worksheet.Cells[i, 61].Value);
                    tbD.pr_approve_date = Convert.ToString(worksheet.Cells[i, 62].Value);
                    tbD.rfq1 = Convert.ToString(worksheet.Cells[i, 63].Value);
                    tbD.rfq2 = Convert.ToString(worksheet.Cells[i, 64].Value);
                    tbD.rfq3 = Convert.ToString(worksheet.Cells[i, 65].Value);
                    tbD.attached_file_flag = Convert.ToString(worksheet.Cells[i, 66].Value);
                    tbD.attached_file_name = Convert.ToString(worksheet.Cells[i, 67].Value);
                    tbD.subcontract_class = Convert.ToString(worksheet.Cells[i, 68].Value);
                    tbD.order_reason_class = Convert.ToString(worksheet.Cells[i, 69].Value);
                    tbD.install_adjust_flag = Convert.ToString(worksheet.Cells[i, 70].Value);
                    tbD.receipt_regis_date = Convert.ToString(worksheet.Cells[i, 71].Value);
                    tbD.receipt_regis_quantity = Convert.ToString(worksheet.Cells[i, 72].Value);
                    tbD.receipt_regis_person = Convert.ToString(worksheet.Cells[i, 73].Value);
                    tbD.approver_msg1 = Convert.ToString(worksheet.Cells[i, 74].Value);
                    tbD.approver_msg2 = Convert.ToString(worksheet.Cells[i, 75].Value);
                    tbD.receiving_creat_date = Convert.ToString(worksheet.Cells[i, 76].Value);
                    tbD.inspec_receive_creat_date = Convert.ToString(worksheet.Cells[i, 77].Value);
                    tbD.receive_creat_pic = Convert.ToString(worksheet.Cells[i, 78].Value);
                    tbD.inspec_receive_pic = Convert.ToString(worksheet.Cells[i, 79].Value);
                    tbD.update_date = Convert.ToString(worksheet.Cells[i, 80].Value);
                    tbD.update_person = Convert.ToString(worksheet.Cells[i, 81].Value);
                    tbD.creation_date = Convert.ToString(worksheet.Cells[i, 82].Value);
                    tbD.creation_person = Convert.ToString(worksheet.Cells[i, 83].Value);
                    tbD.order_sheet_output_class = Convert.ToString(worksheet.Cells[i, 84].Value);
                    tbD.dept_incharge_code = Convert.ToString(worksheet.Cells[i, 85].Value);
                    tbD.currency_code = Convert.ToString(worksheet.Cells[i, 86].Value);
                    tbD.accounting_month = Convert.ToString(worksheet.Cells[i, 87].Value);
                    tbD.req_compny_name = Convert.ToString(worksheet.Cells[i, 88].Value);
                    tbD.ordered_person_name = Convert.ToString(worksheet.Cells[i, 89].Value);
                    tbD.receive_pic_name = Convert.ToString(worksheet.Cells[i, 90].Value);
                    tbD.inspec_pic_name = Convert.ToString(worksheet.Cells[i, 91].Value);
                    tbD.catalog_validity = Convert.ToString(worksheet.Cells[i, 92].Value);
                    tbD.full_quotation_no = Convert.ToString(worksheet.Cells[i, 93].Value);
                    tbD.full_quotation_replyno = Convert.ToString(worksheet.Cells[i, 94].Value);
                    tbD.quotation_req_date = Convert.ToString(worksheet.Cells[i, 95].Value);
                    tbD.quotation_reply_date = Convert.ToString(worksheet.Cells[i, 96].Value);
                    tbD.officlal_unitprice_changeplan_date = Convert.ToString(worksheet.Cells[i, 97].Value);
                    tbD.maximum_unit_price = Convert.ToString(worksheet.Cells[i, 98].Value);
                    tbD.direct_delivery_class = Convert.ToString(worksheet.Cells[i, 99].Value);
                    tbD.order_lead_time = Convert.ToString(worksheet.Cells[i, 100].Value);
                    tbD.supp_comment = Convert.ToString(worksheet.Cells[i, 101].Value);
                    tbD.inspec_timeday = Convert.ToString(worksheet.Cells[i, 102].Value);
                    tbD.unit_price_reply_quotation = Convert.ToString(worksheet.Cells[i, 103].Value);
                    tbD.lead_time_reply_quotation = Convert.ToString(worksheet.Cells[i, 104].Value);
                    tbD.supp_reply_quotation = Convert.ToString(worksheet.Cells[i, 105].Value);
                    tbD.order_cheapest_supp_quotation = Convert.ToString(worksheet.Cells[i, 106].Value);
                    tbD.inspec_creditdebit_approver = Convert.ToString(worksheet.Cells[i, 107].Value);
                    tbD.delivery_time_flag = Convert.ToString(worksheet.Cells[i, 108].Value);
                    tbD.order_remain_quantity = Convert.ToString(worksheet.Cells[i, 109].Value);
                    tbD.risk_level_class = Convert.ToString(worksheet.Cells[i, 110].Value);
                    tbD.arrival_req_date_plan = Convert.ToString(worksheet.Cells[i, 111].Value);
                    tbD.etd_actual = Convert.ToString(worksheet.Cells[i, 112].Value);
                    tbD.eta_actual = Convert.ToString(worksheet.Cells[i, 113].Value);
                    tbD.send_delivery_actual_date = Convert.ToString(worksheet.Cells[i, 114].Value);
                    tbD.arrival_method = Convert.ToString(worksheet.Cells[i, 115].Value);
                    tbD.trade_condition = Convert.ToString(worksheet.Cells[i, 116].Value);
                    tbD.source_document_no = Convert.ToString(worksheet.Cells[i, 117].Value);
                    tbD.source_breakdown_no = Convert.ToString(worksheet.Cells[i, 118].Value);
                    tbD.discourse_to = Convert.ToString(worksheet.Cells[i, 119].Value);
                    tbD.rfq_no = Convert.ToString(worksheet.Cells[i, 120].Value);
                    tbD.program_update_date = Convert.ToString(worksheet.Cells[i, 121].Value);
                    tbD.upd_dt = DateTime.Now;
                    tbD.upd_by = User.FindFirst("username").Value;;
                    tbD.subject = Convert.ToString(worksheet.Cells[i, 18].Value);//.ToString("yyyyMMdd");

                listNp.Add(tbD);
                }
                 await _context.T_PO_Issue.AddRangeAsync(listNp);

                System.IO.File.Delete(fullpath);  //Delete file new part

                await _context.SaveChangesAsync();
                
          return Ok();
        }

        [HttpPost("UploadDelayDomestic")]
        public async Task<IActionResult> upload_delay_domestic(IFormFile file){
             string rootFolder = Directory.GetCurrentDirectory();
             string pathString = @"\API site\files\pur_delivery\Delay_Domestic\";
             string serverPath = rootFolder.Substring(0, rootFolder.LastIndexOf(@"\")) + pathString;
                if (!Directory.Exists(serverPath))
                {
                    Directory.CreateDirectory(serverPath);
                }
            string fullpath = serverPath + file.FileName;
            using (Stream stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Dispose();
                stream.Close();
            }

            FileInfo existingFile = new FileInfo(fullpath);
            ExcelPackage package = new ExcelPackage(existingFile);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.First();//Selected Specify page
            int rows = worksheet.Dimension.End.Row;
            int cols = worksheet.Dimension.End.Column;
            Console.WriteLine(rows);

            List<T_Delay_Domestic> listNp = new List<T_Delay_Domestic>();

            for (int i = 3; i <= rows; i++)
            {
                if(worksheet.Cells[i, 2].Value!=null){
                    T_Delay_Domestic tbD = new T_Delay_Domestic();
                    tbD.status = Convert.ToString(worksheet.Cells[i, 1].Value);
                    tbD.po_number = Convert.ToString(worksheet.Cells[i, 2].Value);
                    tbD.po_line_number = Convert.ToString(worksheet.Cells[i, 3].Value);
                    tbD.po_shipm_number = Convert.ToString(worksheet.Cells[i, 4].Value);
                    tbD.req_no = Convert.ToString(worksheet.Cells[i, 5].Value);
                    tbD.req_details_no = Convert.ToString(worksheet.Cells[i, 6].Value);
                    tbD.order_company_code = Convert.ToString(worksheet.Cells[i, 7].Value);
                    tbD.order_wdw_code = Convert.ToString(worksheet.Cells[i, 8].Value);
                    tbD.pur_incharge = Convert.ToString(worksheet.Cells[i, 9].Value);
                    tbD.buyer_pic_company_name = Convert.ToString(worksheet.Cells[i, 10].Value);
                    tbD.buyer_pic_belong_name = Convert.ToString(worksheet.Cells[i, 11].Value);
                    tbD.buyer_pic_telephone = Convert.ToString(worksheet.Cells[i, 12].Value);
                    tbD.buyer_pic_mailddress = Convert.ToString(worksheet.Cells[i, 13].Value);
                    tbD.supplier = Convert.ToString(worksheet.Cells[i, 14].Value);
                    tbD.supplier_site = Convert.ToString(worksheet.Cells[i, 15].Value);
                    tbD.item_desc = Convert.ToString(worksheet.Cells[i, 16].Value);
                    tbD.maker_code = Convert.ToString(worksheet.Cells[i, 17].Value);
                    tbD.maker_name = Convert.ToString(worksheet.Cells[i, 18].Value);
                    tbD.type = Convert.ToString(worksheet.Cells[i, 19].Value);
                    tbD.pur_order_qty = Convert.ToString(worksheet.Cells[i, 20].Value);
                    tbD.delivery_balanced_qty = Convert.ToString(worksheet.Cells[i, 21].Value);
                    tbD.balanced_order_qty = Convert.ToString(worksheet.Cells[i, 22].Value);
                    tbD.unit   = Convert.ToString(worksheet.Cells[i, 23].Value);
                    tbD.inspectionyn = Convert.ToString(worksheet.Cells[i, 24].Value);
                    tbD.inspection_dept = Convert.ToString(worksheet.Cells[i, 25].Value);
                    tbD.remark_risk_degree = Convert.ToString(worksheet.Cells[i, 26].Value);
                    tbD.order_date = Convert.ToString(worksheet.Cells[i, 27].Value);
                    tbD.promised_date = Convert.ToString(worksheet.Cells[i, 28].Value);
                    tbD.today = Convert.ToString(worksheet.Cells[i, 29].Value);
                    tbD.delay = Convert.ToString(worksheet.Cells[i, 30].Value);
                    tbD.resp_suppliercpt = Convert.ToString(worksheet.Cells[i, 31].Value);
                    tbD.remark_and_reason = Convert.ToString(worksheet.Cells[i, 32].Value);
                    tbD.byer_pic = Convert.ToString(worksheet.Cells[i, 33].Value);
                    tbD.requisitioner = Convert.ToString(worksheet.Cells[i, 34].Value);
                    tbD.request_company = Convert.ToString(worksheet.Cells[i, 35].Value);
                    tbD.request_dept = Convert.ToString(worksheet.Cells[i, 36].Value);
                    tbD.requester_telephone = Convert.ToString(worksheet.Cells[i, 37].Value);
                    tbD.request_email = Convert.ToString(worksheet.Cells[i, 38].Value);
                    tbD.remarks = Convert.ToString(worksheet.Cells[i, 39].Value);
                    tbD.upd_dt = DateTime.Now;
                    tbD.upd_by = User.FindFirst("username").Value;
                    tbD.subject = Convert.ToDateTime(worksheet.Cells[i, 29].Value).ToString("yyyyMMdd");
                    listNp.Add(tbD);
                }
            }
                await _context.T_Delay_Domestic.AddRangeAsync(listNp);

            System.IO.File.Delete(fullpath);  //Delete file new part

            await _context.SaveChangesAsync();
            return Ok();
        }
       
        [HttpPost("UploadDelayOversea")]
        public async Task<IActionResult> upload_delay_oversea(IFormFile file){
             string rootFolder = Directory.GetCurrentDirectory();
             string pathString = @"\API site\files\pur_delivery\Delay_Oversea\";
             string serverPath = rootFolder.Substring(0, rootFolder.LastIndexOf(@"\")) + pathString;
            if (!Directory.Exists(serverPath))
            {
                Directory.CreateDirectory(serverPath);
            }

            string fullpath = serverPath + file.FileName;
            using (Stream stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Dispose();
                stream.Close();
            }

            FileInfo existingFile = new FileInfo(fullpath);
            ExcelPackage package = new ExcelPackage(existingFile);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.First();//Selected Specify page
            int rows = worksheet.Dimension.End.Row;
            int cols = worksheet.Dimension.End.Column;
            Console.WriteLine(rows);

            List<T_Delay_Oversea> listNp = new List<T_Delay_Oversea>();

            for (int i = 3; i <= rows; i++)
            {
                if(worksheet.Cells[i, 2].Value!=null){
                    T_Delay_Oversea tbD = new T_Delay_Oversea();
                    tbD.status = Convert.ToString(worksheet.Cells[i, 1].Value);
                    tbD.po_number = Convert.ToString(worksheet.Cells[i, 2].Value);
                    tbD.po_line_number = Convert.ToString(worksheet.Cells[i, 3].Value);
                    tbD.po_shipm_number = Convert.ToString(worksheet.Cells[i, 4].Value);
                    tbD.req_no = Convert.ToString(worksheet.Cells[i, 5].Value);
                    tbD.req_details_no = Convert.ToString(worksheet.Cells[i, 6].Value);
                    tbD.order_company_code = Convert.ToString(worksheet.Cells[i, 7].Value);
                    tbD.order_company_name = Convert.ToString(worksheet.Cells[i, 8].Value);
                    tbD.pur_incharge = Convert.ToString(worksheet.Cells[i, 9].Value);
                    tbD.buyer_pic_company_name = Convert.ToString(worksheet.Cells[i, 10].Value);
                    tbD.buyer_pic_belong_name = Convert.ToString(worksheet.Cells[i, 11].Value);
                    tbD.buyer_pic_telephone = Convert.ToString(worksheet.Cells[i, 12].Value);
                    tbD.buyer_pic_mailddress = Convert.ToString(worksheet.Cells[i, 13].Value);
                    tbD.supplier = Convert.ToString(worksheet.Cells[i, 14].Value);
                    tbD.supplier_site = Convert.ToString(worksheet.Cells[i, 15].Value);
                    tbD.item_desc = Convert.ToString(worksheet.Cells[i, 16].Value);
                    tbD.maker_code = Convert.ToString(worksheet.Cells[i, 17].Value);
                    tbD.maker_name = Convert.ToString(worksheet.Cells[i, 18].Value);
                    tbD.type = Convert.ToString(worksheet.Cells[i, 19].Value);
                    tbD.price = Convert.ToString(worksheet.Cells[i, 20].Value);
                    tbD.currency = Convert.ToString(worksheet.Cells[i, 21].Value);
                    tbD.pur_order_qty = Convert.ToString(worksheet.Cells[i, 22].Value);
                    tbD.delivery_qty = Convert.ToString(worksheet.Cells[i, 23].Value);
                    tbD.delivery_balanced_qty = Convert.ToString(worksheet.Cells[i, 24].Value);
                    tbD.balanced_order_qty = Convert.ToString(worksheet.Cells[i, 25].Value);
                    tbD.unit   = Convert.ToString(worksheet.Cells[i, 26].Value);
                    tbD.inspectionyn = Convert.ToString(worksheet.Cells[i, 27].Value);
                    tbD.inspection_dept = Convert.ToString(worksheet.Cells[i, 28].Value);
                    tbD.remark_risk_degree = Convert.ToString(worksheet.Cells[i, 29].Value);
                    tbD.order_date = Convert.ToString(worksheet.Cells[i, 30].Value);
                    tbD.req_shipping_date = Convert.ToString(worksheet.Cells[i, 31].Value);
                    tbD.promised_date = Convert.ToString(worksheet.Cells[i, 32].Value);
                    tbD.today = Convert.ToString(worksheet.Cells[i, 33].Value);
                    tbD.delay = Convert.ToString(worksheet.Cells[i, 34].Value);
                    tbD.resp_suppliercpt = Convert.ToString(worksheet.Cells[i, 35].Value);
                    tbD.remark_and_reason = Convert.ToString(worksheet.Cells[i, 36].Value);
                    tbD.transportation = Convert.ToString(worksheet.Cells[i, 37].Value);
                    tbD.requisitioner = Convert.ToString(worksheet.Cells[i, 38].Value);
                    tbD.request_company = Convert.ToString(worksheet.Cells[i, 39].Value);
                    tbD.request_dept = Convert.ToString(worksheet.Cells[i, 40].Value);
                    tbD.requester_telephone = Convert.ToString(worksheet.Cells[i, 41].Value);
                    tbD.request_email = Convert.ToString(worksheet.Cells[i, 42].Value);
                    tbD.remarks = Convert.ToString(worksheet.Cells[i, 43].Value);
                    tbD.upd_dt = DateTime.Now;
                    tbD.upd_by = User.FindFirst("username").Value;
                    tbD.subject = Convert.ToDateTime(worksheet.Cells[i, 33].Value).ToString("yyyyMMdd");
                    listNp.Add(tbD);
                }

            }
            await _context.T_Delay_Oversea.AddRangeAsync(listNp);

            System.IO.File.Delete(fullpath);  //Delete file new part

            await _context.SaveChangesAsync();
                
            return Ok();
        }

        [HttpPost("UploadDeliveryEvolio")]
        public async Task<IActionResult> upload_delivery_evolio(IFormFile file){
            string rootFolder = Directory.GetCurrentDirectory();
            string pathString = @"\API site\files\pur_delivery\Delivery_Evolio\";
            string serverPath = rootFolder.Substring(0, rootFolder.LastIndexOf(@"\")) + pathString;
            if (!Directory.Exists(serverPath))
            {
                Directory.CreateDirectory(serverPath);
            }
            string fullpath = serverPath + file.FileName;
            using (Stream stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Dispose();
                stream.Close();
            }

            FileInfo existingFile = new FileInfo(fullpath);
            ExcelPackage package = new ExcelPackage(existingFile);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.First();//Selected Specify page
            int rows = worksheet.Dimension.End.Row;
            int cols = worksheet.Dimension.End.Column;
            Console.WriteLine(rows);

            List<T_Control_Evalio> listNp = new List<T_Control_Evalio>();

            for (int i = 3; i <= rows; i++)
            {
                if(worksheet.Cells[i, 2].Value!=null){
                    T_Control_Evalio tbD = new T_Control_Evalio();
                    tbD.pr_no = Convert.ToString(worksheet.Cells[i, 1].Value);
                    tbD.po_no = Convert.ToString(worksheet.Cells[i, 2].Value);
                    tbD.issuedate = Convert.ToString(worksheet.Cells[i, 3].Value);
                    tbD.delivery_date = Convert.ToString(worksheet.Cells[i, 4].Value);
                    string dateFromExcel = worksheet.Cells[i, 5].Text.ToString();
                    DateTime localdt;
                    if (DateTime.TryParse(dateFromExcel, out localdt))
                    {
                        tbD.today = localdt.ToString("yyyyMMdd");
                    };
                    tbD.delay = Convert.ToString(worksheet.Cells[i, 6].Value);
                    tbD.lt = Convert.ToString(worksheet.Cells[i, 7].Value);
                    tbD.resp_suppliercpt = Convert.ToString(worksheet.Cells[i, 8].Value);
                    tbD.remark_and_reason = Convert.ToString(worksheet.Cells[i, 9].Value);
                    tbD.no = Convert.ToString(worksheet.Cells[i, 10].Value);
                    tbD.item = Convert.ToString(worksheet.Cells[i, 11].Value);
                    tbD.item_name = Convert.ToString(worksheet.Cells[i, 12].Value);
                    tbD.quantity = Convert.ToString(worksheet.Cells[i, 13].Value);
                    tbD.received = Convert.ToString(worksheet.Cells[i, 14].Value);
                    tbD.remain = Convert.ToString(worksheet.Cells[i, 15].Value);
                    tbD.unit = Convert.ToString(worksheet.Cells[i, 16].Value);
                    tbD.unit_price = Convert.ToString(worksheet.Cells[i, 17].Value);
                    tbD.currency = Convert.ToString(worksheet.Cells[i, 18].Value);
                    tbD.vendor_code = Convert.ToString(worksheet.Cells[i, 19].Value);
                    tbD.vendor_name = Convert.ToString(worksheet.Cells[i, 20].Value);
                    tbD.prepareby = Convert.ToString(worksheet.Cells[i, 21].Value);
                    tbD.center_code = Convert.ToString(worksheet.Cells[i, 22].Value);
                    tbD.center_name = Convert.ToString(worksheet.Cells[i, 23].Value);
                    tbD.expense_code = Convert.ToString(worksheet.Cells[i, 24].Value);
                    tbD.equipment_budget_code = Convert.ToString(worksheet.Cells[i, 25].Value);
                    tbD.upd_dt = DateTime.Now;
                    tbD.upd_by = User.FindFirst("username").Value;
                    tbD.subject = tbD.today;

                    listNp.Add(tbD);
                }
            }
            await _context.T_Control_Evalio.AddRangeAsync(listNp);

            System.IO.File.Delete(fullpath);  //Delete file new part

            await _context.SaveChangesAsync();
                
            return Ok();
        }

        [HttpPost("UploadShortLT")]
        public async Task<IActionResult> upload_short_lt(IFormFile file){
            string rootFolder = Directory.GetCurrentDirectory();
            string pathString = @"\API site\files\pur_delivery\Short_LT\";
            string serverPath = rootFolder.Substring(0, rootFolder.LastIndexOf(@"\")) + pathString;
            if (!Directory.Exists(serverPath))
            {
                Directory.CreateDirectory(serverPath);
            }
            string fullpath = serverPath + file.FileName;
            using (Stream stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Dispose();
                stream.Close();
            }
            FileInfo existingFile = new FileInfo(fullpath);
            ExcelPackage package = new ExcelPackage(existingFile);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.First();//Selected Specify page
            int rows = worksheet.Dimension.End.Row;
            int cols = worksheet.Dimension.End.Column;
            Console.WriteLine(rows);

            List<T_Delay_ShortLT> listNp = new List<T_Delay_ShortLT>();

            for (int i = 3; i <= rows; i++)
            {
                T_Delay_ShortLT tbD = new T_Delay_ShortLT();
                tbD.req_no  = Convert.ToString(worksheet.Cells[i, 1].Value);
                tbD.pur_order_no = Convert.ToString(worksheet.Cells[i, 2].Value);
                tbD.receive_number = Convert.ToString(worksheet.Cells[i, 3].Value);
                tbD.branch_number_debit_credit = Convert.ToString(worksheet.Cells[i, 4].Value);
                tbD.partition_debit_credit = Convert.ToString(worksheet.Cells[i, 5].Value);
                tbD.rfq_number = Convert.ToString(worksheet.Cells[i, 6].Value);
                tbD.supp_code = Convert.ToString(worksheet.Cells[i, 7].Value);
                tbD.supp_name = Convert.ToString(worksheet.Cells[i, 8].Value);
                tbD.supp_site_code = Convert.ToString(worksheet.Cells[i, 9].Value);
                tbD.partition_delivery_slip_output = Convert.ToString(worksheet.Cells[i, 10].Value);
                tbD.supp_item_code = Convert.ToString(worksheet.Cells[i, 11].Value);
                tbD.partition_subcontractor = Convert.ToString(worksheet.Cells[i, 12].Value);
                tbD.maker_code = Convert.ToString(worksheet.Cells[i, 13].Value);
                tbD.maker_name = Convert.ToString(worksheet.Cells[i, 14].Value);
                tbD.type = Convert.ToString(worksheet.Cells[i, 15].Value);
                tbD.itemclass_code = Convert.ToString(worksheet.Cells[i, 16].Value);
                tbD.unspsc_code = Convert.ToString(worksheet.Cells[i, 17].Value);
                tbD.class_commodity_code = Convert.ToString(worksheet.Cells[i, 18].Value);
                tbD.item_desc = Convert.ToString(worksheet.Cells[i, 19].Value);
                tbD.wdw = Convert.ToString(worksheet.Cells[i, 20].Value);
                tbD.charge_to = Convert.ToString(worksheet.Cells[i, 21].Value);
                tbD.charge_to_name = Convert.ToString(worksheet.Cells[i, 22].Value);
                tbD.ledg_act = Convert.ToString(worksheet.Cells[i, 23].Value);
                tbD.cost_item = Convert.ToString(worksheet.Cells[i, 24].Value);
                tbD.ctrl = Convert.ToString(worksheet.Cells[i, 25].Value);
                tbD.inhouse_order = Convert.ToString(worksheet.Cells[i, 26].Value);
                tbD.code_budget_fixedassets = Convert.ToString(worksheet.Cells[i, 27].Value);
                tbD.code_fixed_assets = Convert.ToString(worksheet.Cells[i, 28].Value);
                tbD.organi_code_capitalizing = Convert.ToString(worksheet.Cells[i, 29].Value);
                tbD.country_origin  = Convert.ToString(worksheet.Cells[i, 30].Value);
                tbD.promo_no = Convert.ToString(worksheet.Cells[i, 31].Value);
                tbD.regis_chemical_item = Convert.ToString(worksheet.Cells[i, 32].Value);
                tbD.theme_id = Convert.ToString(worksheet.Cells[i, 33].Value);
                tbD.revision_no = Convert.ToString(worksheet.Cells[i, 34].Value);
                tbD.temporary_up = Convert.ToString(worksheet.Cells[i, 35].Value);
                tbD.inspection_yn = Convert.ToString(worksheet.Cells[i, 36].Value);
                tbD.unit = Convert.ToString(worksheet.Cells[i, 37].Value);
                tbD.currency = Convert.ToString(worksheet.Cells[i, 38].Value);
                tbD.reason_notapplicable_master = Convert.ToString(worksheet.Cells[i, 39].Value);
                tbD.shipped_location_code = Convert.ToString(worksheet.Cells[i, 40].Value);
                tbD.payment_terms = Convert.ToString(worksheet.Cells[i, 41].Value);
                tbD.order_date = Convert.ToString(worksheet.Cells[i, 42].Value);
                tbD.promised_date = Convert.ToString(worksheet.Cells[i, 43].Value);
                tbD.received_date = Convert.ToString(worksheet.Cells[i, 44].Value);
                tbD.receive_acceptance = Convert.ToString(worksheet.Cells[i, 45].Value);
                tbD.check_shortlt = Convert.ToString(worksheet.Cells[i, 46].Value);
                tbD.check_eod = Convert.ToString(worksheet.Cells[i, 47].Value);
                tbD.status = Convert.ToString(worksheet.Cells[i, 48].Value);
                tbD.cause = Convert.ToString(worksheet.Cells[i, 49].Value);
                tbD.department = Convert.ToString(worksheet.Cells[i, 50].Value);
                tbD.reason = Convert.ToString(worksheet.Cells[i, 51].Value);
                tbD.creation_date_receiving = Convert.ToString(worksheet.Cells[i, 52].Value);
                tbD.creation_date_acceptance = Convert.ToString(worksheet.Cells[i, 53].Value);
                tbD.fiscal_month = Convert.ToString(worksheet.Cells[i, 54].Value);
                tbD.stnd_price = Convert.ToString(worksheet.Cells[i, 55].Value);
                tbD.order_unit_price = Convert.ToString(worksheet.Cells[i, 56].Value);
                tbD.payable_unit_price = Convert.ToString(worksheet.Cells[i, 57].Value);
                tbD.pur_req_qty = Convert.ToString(worksheet.Cells[i, 58].Value);
                tbD.pur_order_qty = Convert.ToString(worksheet.Cells[i, 59].Value);
                tbD.received_qty = Convert.ToString(worksheet.Cells[i, 60].Value);
                tbD.receive_accep_qty = Convert.ToString(worksheet.Cells[i, 61].Value);
                tbD.estimated_amount = Convert.ToString(worksheet.Cells[i, 62].Value);
                tbD.payment_amount_excludetax = Convert.ToString(worksheet.Cells[i, 63].Value);
                tbD.consumption_taxamount = Convert.ToString(worksheet.Cells[i, 64].Value);
                tbD.payment_amount_includetax = Convert.ToString(worksheet.Cells[i, 65].Value);
                tbD.tax_code = Convert.ToString(worksheet.Cells[i, 66].Value);
                tbD.rate = Convert.ToString(worksheet.Cells[i, 67].Value);
                tbD.waybill_no = Convert.ToString(worksheet.Cells[i, 68].Value);
                tbD.nvoice_no = Convert.ToString(worksheet.Cells[i, 69].Value);
                tbD.chargeable_free_charge = Convert.ToString(worksheet.Cells[i, 70].Value);
                tbD.trade_terms = Convert.ToString(worksheet.Cells[i, 71].Value);
                tbD.trade_point = Convert.ToString(worksheet.Cells[i, 72].Value);
                tbD.transportation = Convert.ToString(worksheet.Cells[i, 73].Value);
                tbD.waybill_date = Convert.ToString(worksheet.Cells[i, 74].Value);
                tbD.invoice_date = Convert.ToString(worksheet.Cells[i, 75].Value);
                tbD.delivery_slipno = Convert.ToString(worksheet.Cells[i, 76].Value);
                tbD.invoice_no_domestic = Convert.ToString(worksheet.Cells[i, 77].Value);
                tbD.total_other_charge = Convert.ToString(worksheet.Cells[i, 78].Value);
                tbD.responsibility = Convert.ToString(worksheet.Cells[i, 79].Value);
                tbD.pur_req_company_code = Convert.ToString(worksheet.Cells[i, 80].Value);
                tbD.location_code_pur_req = Convert.ToString(worksheet.Cells[i, 81].Value);
                tbD.dept_code_pur_req = Convert.ToString(worksheet.Cells[i, 82].Value);
                tbD.dept_pur_req = Convert.ToString(worksheet.Cells[i, 83].Value);
                tbD.pur_company_code = Convert.ToString(worksheet.Cells[i, 84].Value);
                tbD.dept_code_pur = Convert.ToString(worksheet.Cells[i, 85].Value);
                tbD.dept_pur = Convert.ToString(worksheet.Cells[i, 86].Value);
                tbD.pur_incharge_code = Convert.ToString(worksheet.Cells[i, 87].Value);
                tbD.pur_incharge = Convert.ToString(worksheet.Cells[i, 88].Value);
                tbD.charge_received_company_code = Convert.ToString(worksheet.Cells[i, 89].Value);
                tbD.charge_received = Convert.ToString(worksheet.Cells[i, 90].Value);
                tbD.charge_acceptance_company_code = Convert.ToString(worksheet.Cells[i, 91].Value);
                tbD.pic_receiving_acceptance = Convert.ToString(worksheet.Cells[i, 92].Value);
                tbD.error_flag = Convert.ToString(worksheet.Cells[i, 93].Value);
                tbD.transaction_id = Convert.ToString(worksheet.Cells[i, 94].Value);
                tbD.last_update_date = Convert.ToString(worksheet.Cells[i, 95].Value);
                tbD.last_update_by = Convert.ToString(worksheet.Cells[i, 96].Value);
                tbD.creation_date = Convert.ToString(worksheet.Cells[i, 97].Value);
                tbD.created_by = Convert.ToString(worksheet.Cells[i, 98].Value);
                tbD.champ_reserve1 = Convert.ToString(worksheet.Cells[i, 99].Value);
                tbD.champ_reserve2 = Convert.ToString(worksheet.Cells[i, 100].Value);
                tbD.upd_dt = DateTime.Now;
                tbD.upd_by = User.FindFirst("username").Value;
                tbD.subject = "";

            listNp.Add(tbD);
            }
                await _context.T_Delay_ShortLT.AddRangeAsync(listNp);

            System.IO.File.Delete(fullpath);  //Delete file new part

            await _context.SaveChangesAsync();
                
            return Ok();
        }

        [HttpPost("UploadPUChamp")]
        public async Task<IActionResult> upload_pu_champ(IFormFile file){
            
            string file_name = System.IO.Path.GetFileNameWithoutExtension(file.FileName);
            string date_from_file = file_name .Substring(file_name .LastIndexOf(' ') + 1);
            DateTime oDate = DateTime.ParseExact(date_from_file, "dd.MMM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            string subject = oDate.ToString("yyyyMMdd");

            string rootFolder = Directory.GetCurrentDirectory();
            string pathString = @"\API site\files\pur_delivery\PU_champ\";
            string serverPath = rootFolder.Substring(0, rootFolder.LastIndexOf(@"\")) + pathString;
            if (!Directory.Exists(serverPath))
            {
                Directory.CreateDirectory(serverPath);
            }
            string fullpath = serverPath + file.FileName;
            using (Stream stream = new FileStream(fullpath, FileMode.Create))
            {
                file.CopyTo(stream);
                stream.Dispose();
                stream.Close();
            }
            FileInfo existingFile = new FileInfo(fullpath);
            ExcelPackage package = new ExcelPackage(existingFile);
            ExcelWorksheet worksheetab = package.Workbook.Worksheets["Abnormal"];//Selected Specify page
            int rows = worksheetab.Dimension.End.Row;
            int cols = worksheetab.Dimension.End.Column;
            Console.WriteLine(rows);

            List<T_PU_Abnormal> listAB  = new List<T_PU_Abnormal>();
            List<T_PU> listPU  = new List<T_PU>();
            List<T_PU_Original> listNew  = new List<T_PU_Original>();

            for (int i = 3; i <= rows; i++)
            {

                T_PU_Abnormal tbD = new T_PU_Abnormal();
                tbD.req_no = Convert.ToString(worksheetab.Cells[i, 1].Value);
                tbD.req_details_no = Convert.ToString(worksheetab.Cells[i, 2].Value);
                tbD.order_company_code = Convert.ToString(worksheetab.Cells[i, 3].Value);
                tbD.order_wdw_code = Convert.ToString(worksheetab.Cells[i, 4].Value);
                tbD.pur_incharge = Convert.ToString(worksheetab.Cells[i, 5].Value);
                tbD.item_desc = Convert.ToString(worksheetab.Cells[i, 6].Value);
                tbD.maker_code = Convert.ToString(worksheetab.Cells[i, 7].Value);
                tbD.maker_name = Convert.ToString(worksheetab.Cells[i, 8].Value);
                tbD.type = Convert.ToString(worksheetab.Cells[i, 9].Value);
                tbD.pur_req_qty = Convert.ToString(worksheetab.Cells[i, 10].Value);
                tbD.unit   = Convert.ToString(worksheetab.Cells[i, 11].Value);
                tbD.ship_to = Convert.ToString(worksheetab.Cells[i, 12].Value);
                tbD.status = Convert.ToString(worksheetab.Cells[i, 13].Value);
                tbD.date_passed_after_reception = Convert.ToString(worksheetab.Cells[i, 14].Value);
                tbD.receive_date_pur_req =  worksheetab.Cells[i, 15].Value.ToString();
                tbD.req_delivery_date = worksheetab.Cells[i, 16].Value.ToString();
                tbD.action = Convert.ToString(worksheetab.Cells[i, 17].Value);
                tbD.upd_dt = DateTime.Now;
                tbD.upd_by = User.FindFirst("username").Value;
                tbD.subject = subject;

                listAB.Add(tbD);
            }
            await _context.T_PU_Abnormal.AddRangeAsync(listAB);

            ExcelWorksheet worksheetnew = package.Workbook.Worksheets["NEW"];//Selected Specify page
            int rowsnew = worksheetnew.Dimension.End.Row;
            int colsnew = worksheetnew.Dimension.End.Column;
            Console.WriteLine(rowsnew);
            for (int i = 3; i <= rowsnew; i++)
            {
                T_PU_Original tbnew = new T_PU_Original();
                tbnew.req_no = Convert.ToString(worksheetnew.Cells[i, 1].Value);
                tbnew.req_details_no = Convert.ToString(worksheetnew.Cells[i, 2].Value);
                tbnew.order_company_code = Convert.ToString(worksheetnew.Cells[i, 3].Value);
                tbnew.order_wdw_code = Convert.ToString(worksheetnew.Cells[i, 4].Value);
                tbnew.pur_incharge = Convert.ToString(worksheetnew.Cells[i, 5].Value);
                tbnew.item_desc = Convert.ToString(worksheetnew.Cells[i, 6].Value);
                tbnew.maker_code = Convert.ToString(worksheetnew.Cells[i, 7].Value);
                tbnew.maker_name = Convert.ToString(worksheetnew.Cells[i, 8].Value);
                tbnew.type = Convert.ToString(worksheetnew.Cells[i, 9].Value);
                tbnew.pur_req_qty = Convert.ToString(worksheetnew.Cells[i, 10].Value);
                tbnew.unit   = Convert.ToString(worksheetnew.Cells[i, 11].Value);
                tbnew.ship_to = Convert.ToString(worksheetnew.Cells[i, 12].Value);
                tbnew.status = Convert.ToString(worksheetnew.Cells[i, 13].Value);
                tbnew.date_passed_after_reception = Convert.ToString(worksheetnew.Cells[i, 14].Value);
                tbnew.receive_date_pur_req =  worksheetnew.Cells[i, 15].Value.ToString();
                tbnew.req_delivery_date = Convert.ToString(worksheetnew.Cells[i, 16].Value);
                tbnew.upd_dt = DateTime.Now;
                tbnew.upd_by = User.FindFirst("username").Value;
                tbnew.subject = subject;

                listNew.Add(tbnew);
            }
            await _context.T_PU_Original.AddRangeAsync(listNew);

            ExcelWorksheet worksheetpu = package.Workbook.Worksheets.FirstOrDefault(x=> x.Name != "Abnormal" && x.Name != "NEW" && x.Name != "Sheet1" );
            int rowsnewpu = worksheetpu.Dimension.End.Row;
            int colsnewpu = worksheetpu.Dimension.End.Column;
            Console.WriteLine(rowsnewpu);
            for (int i = 3; i <= rowsnewpu; i++)
            {
                Console.WriteLine(i + "-------------------------------");
                Console.WriteLine(worksheetpu.Cells[i, 15].Value.ToString());
                long dateNum15 = long.Parse(worksheetpu.Cells[i, 15].Value.ToString());
                //double dateNum15 = double.Parse(worksheetpu.Cells[i, 15].Value.ToString());
                    DateTime result15 = DateTime.FromOADate(dateNum15);
                long dateNum16 = long.Parse(worksheetpu.Cells[i, 16].Value.ToString());
                //double dateNum16 = double.Parse(worksheetpu.Cells[i, 15].Value.ToString());
                    DateTime result16 = DateTime.FromOADate(dateNum16);
                
                Console.WriteLine(result16);
                Console.WriteLine(result15);


                T_PU tbpu = new T_PU();
                tbpu.req_no = Convert.ToString(worksheetpu.Cells[i, 1].Value);
                tbpu.req_details_no = Convert.ToString(worksheetpu.Cells[i, 2].Value);
                tbpu.order_company_code = Convert.ToString(worksheetpu.Cells[i, 3].Value);
                tbpu.order_wdw_code = Convert.ToString(worksheetpu.Cells[i, 4].Value);
                tbpu.pur_incharge = Convert.ToString(worksheetpu.Cells[i, 5].Value);
                tbpu.item_desc = Convert.ToString(worksheetpu.Cells[i, 6].Value);
                tbpu.maker_code = Convert.ToString(worksheetpu.Cells[i, 7].Value);
                tbpu.maker_name = Convert.ToString(worksheetpu.Cells[i, 8].Value);
                tbpu.type = Convert.ToString(worksheetpu.Cells[i, 9].Value);
                tbpu.pur_req_qty = Convert.ToString(worksheetpu.Cells[i, 10].Value);
                tbpu.unit   = Convert.ToString(worksheetpu.Cells[i, 11].Value);
                tbpu.ship_to = Convert.ToString(worksheetpu.Cells[i, 12].Value);
                tbpu.status = Convert.ToString(worksheetpu.Cells[i, 13].Value);
                tbpu.date_passed_after_reception = Convert.ToString(worksheetpu.Cells[i, 14].Value);
                tbpu.receive_date_pur_req =  result15.ToString("dd-MMM-yy");
                tbpu.req_delivery_date =  result16.ToString("dd-MMM-yy");
                tbpu.upd_dt = DateTime.Now;
                tbpu.upd_by = User.FindFirst("username").Value;
                tbpu.subject = subject;

                listPU.Add(tbpu);
            }
            await _context.T_PU.AddRangeAsync(listPU);

            System.IO.File.Delete(fullpath);  //Delete file new part

            await _context.SaveChangesAsync();
                
            return Ok();
        }
    }
}
