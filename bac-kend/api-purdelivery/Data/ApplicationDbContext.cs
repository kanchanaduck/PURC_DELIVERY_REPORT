using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api_purdelivery;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
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
                    
            modelBuilder.Entity<T_KPI>()
                    .HasKey(r => new { r.year, r.monthly, r.dept } );
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
        public DbSet<T_Reason_Domestic_Early> T_Reason_Domestic_Early { get; set; }
        public DbSet<T_Reason_Domestic_Delay> T_Reason_Domestic_Delay { get; set; }
        public DbSet<T_Reason_Domestic_ShortLT> T_Reason_Domestic_ShortLT { get; set; }
        public DbSet<T_Reason_Oversea_Early> T_Reason_Oversea_Early { get; set; }
        public DbSet<T_Reason_Oversea_Delay> T_Reason_Oversea_Delay { get; set; }
        public DbSet<T_Reason_Oversea_ShortLT> T_Reason_Oversea_ShortLT { get; set; }
        public DbSet<T_Reason_DL_Domestic> T_Reason_DL_Domestic { get; set; }
        public DbSet<T_Reason_DL_Oversea> T_Reason_DL_Oversea { get; set; }
        public DbSet<T_Reason_Evalio> T_Reason_Evalio { get; set; }
        public DbSet<T_User> T_User { get; set; }
        public DbSet<T_Role> T_Role { get; set; }
        public DbSet<T_KPI> T_KPI{ get; set; }
    
    }
