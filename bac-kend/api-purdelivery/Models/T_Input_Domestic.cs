using System;
using System.ComponentModel.DataAnnotations;

namespace api_purdelivery
{
    public class T_Input_Domestic
    {
    public int id	{ get; set; }
    public int id_input { get; set; }
    public string dt_date { get; set; }
    public string status { get; set; }
    public string remark { get; set; }
    public string status_check { get; set; }
    public string buyer_input { get; set; }
    public DateTime? buyer_date { get; set; }
    public string leader_check { get; set; }
    public DateTime? leader_date { get; set; }
    public string manager_check { get; set; }
    public DateTime? manager_date { get; set; }
    public string other_check { get; set; }
    public DateTime? other_date { get; set; }
    public string purc_check { get; set; }
    public DateTime? purc_date { get; set; }

    }
}