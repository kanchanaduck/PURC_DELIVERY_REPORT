using Microsoft.EntityFrameworkCore.Migrations;

namespace api_purdelivery.Migrations
{
    public partial class InitialCreate22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cd_cosmos_maker",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_ctry_orig",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_curr",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_delv_place_offici",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_fact",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_kind_parts",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_ord_class",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_piece",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_procur_person",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cf_child_base",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cf_sply_type",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cr_delv_lot",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dt_entry",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dt_oblig_purch",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dt_renew",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mk_po_chk_digit",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nm_entry_person",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nm_parts_eng",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nm_renew_person",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nm_sply_eng",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "no_chg_hist",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "no_chg_hist_sfx",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "no_container",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "no_cust_clea",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "no_invent_cntl_poi",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "no_ord_class",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "qt_climacs_insp",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "qt_insp_cmpl",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "qt_und_insp",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "remark",
                table: "T_Oversea",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_ctry_orig",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_delv_place_offici",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_kind_parts",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_piece",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cd_tape",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cf_child_base",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cf_insp_type",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cf_invent_dem",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cf_sply_type",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cf_transp_meth",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cr_delv_lot",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dt_entry",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dt_renew",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mk_import_item",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mk_po_chk_digit",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nm_entry_person",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nm_parts_eng",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nm_renew_person",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "no_arrange",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "no_invent_cntl_poi",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "no_po_legacy",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "qt_acptc_bal",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "qt_acptc_cuml",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "qt_insp_cmpl",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "qt_und_insp",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "qt_und_insp_cuml",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "remark",
                table: "T_Domestic",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cd_cosmos_maker",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cd_ctry_orig",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cd_curr",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cd_delv_place_offici",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cd_fact",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cd_kind_parts",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cd_ord_class",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cd_piece",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cd_procur_person",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cf_child_base",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cf_sply_type",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cr_delv_lot",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "dt_entry",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "dt_oblig_purch",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "dt_renew",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "mk_po_chk_digit",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "nm_entry_person",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "nm_parts_eng",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "nm_renew_person",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "nm_sply_eng",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "no_chg_hist",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "no_chg_hist_sfx",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "no_container",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "no_cust_clea",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "no_invent_cntl_poi",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "no_ord_class",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "qt_climacs_insp",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "qt_insp_cmpl",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "qt_und_insp",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "remark",
                table: "T_Oversea");

            migrationBuilder.DropColumn(
                name: "cd_ctry_orig",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "cd_delv_place_offici",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "cd_kind_parts",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "cd_piece",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "cd_tape",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "cf_child_base",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "cf_insp_type",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "cf_invent_dem",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "cf_sply_type",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "cf_transp_meth",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "cr_delv_lot",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "dt_entry",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "dt_renew",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "mk_import_item",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "mk_po_chk_digit",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "nm_entry_person",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "nm_parts_eng",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "nm_renew_person",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "no_arrange",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "no_invent_cntl_poi",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "no_po_legacy",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "qt_acptc_bal",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "qt_acptc_cuml",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "qt_insp_cmpl",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "qt_und_insp",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "qt_und_insp_cuml",
                table: "T_Domestic");

            migrationBuilder.DropColumn(
                name: "remark",
                table: "T_Domestic");
        }
    }
}
