using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace api_purdelivery
{
public class DataBaseContext : DbContext
    {
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<T_Role_Claim>()
                .HasKey(r => new { r.username, r.role } );

        modelBuilder.Entity<T_Role_Claim>()
                .HasOne(mr => mr.users)
                .WithMany(u => u.roles)
                .HasForeignKey(mr => mr.username);

        modelBuilder.Entity<T_Role_Claim>()
                .HasOne(mb => mb.roles)
                .WithMany(c => c.users)
                .HasForeignKey(mb => mb.role);
    }
    public DbSet<T_Domestic> T_Domestic { get; set; }
    public DbSet<T_Oversea> T_Oversea { get; set; }
    public DbSet<T_Control_Domestic> T_Control_Domestic { get; set; }
    public DbSet<T_Control_Oversea> T_Control_Oversea { get; set; }
    public DbSet<T_Control_Evalio> T_Control_Evalio { get; set; }
    public DbSet<T_Delay_Domestic> T_Delay_Domestic { get; set; }
    public DbSet<T_Delay_ShortLT> T_Delay_ShortLT { get; set; }
    public DbSet<T_Delay_Oversea> T_Delay_Oversea { get; set; }
    public DbSet<T_PU_Abnormal> T_PU_Abnormal { get; set; }
    public DbSet<T_PU_Original> T_PU_Original { get; set; }
    public DbSet<T_PU> T_PU { get; set; }
    public DbSet<T_PO_Issue> T_PO_Issue { get; set; }
    public DbSet<T_Reason_ShortLT> T_Reason_ShortLT { get; set; }
    public DbSet<T_Reason_Delay> T_Reason_Delay { get; set; }
    public DbSet<T_Reason_DL_Domestic> T_Reason_DL_Domestic { get; set; }
    public DbSet<T_Reason_DL_Oversea> T_Reason_DL_Oversea { get; set; }
    public DbSet<T_Reason_Early> T_Reason_Early { get; set; }
    public DbSet<T_Reason_Evalio> T_Reason_Evalio { get; set; }
    public DbSet<T_Input_Domestic> T_Input_Domestic { get; set; }
    public DbSet<T_Input_Oversea> T_Input_Oversea { get; set; }
    public DbSet<T_User> T_User { get; set; }
    public DbSet<T_Role> T_Role { get; set; }
    
    }
}
// 1. เปิด cmd หรือ terminal ของ Visual Studio Code พิมพ์คำสั่งนี้ Install ครั้งแรก
//.NET CLI >> dotnet tool install --global dotnet-ef
// 2. ใช้คำสั่งนี้เพื่อสร้าง migration หลังจาก create model แล้ว ตามต้องการ
//.NET CLI >> dotnet ef migrations add InitialCreate
//            dotnet ef database update




//---------------------Setting Web config for publish to server----------------------------
// <?xml version="1.0" encoding="utf-8"?>
// <configuration>
//   <location path="." inheritInChildApplications="false">
//     <system.webServer>
//       <handlers>
//         <add name="aspNetCore" path="*" verb="*" modules="AspNetCoreModuleV2" resourceType="Unspecified" />
//       </handlers>
//       <aspNetCore processPath="dotnet" arguments=".\api-purdelivery.dll" stdoutLogEnabled="false" stdoutLogFile=".\logs\stdout" hostingModel="inprocess" />
//     </system.webServer>
//   </location>
// </configuration>
//--------------------------------------------------------------------------------------------