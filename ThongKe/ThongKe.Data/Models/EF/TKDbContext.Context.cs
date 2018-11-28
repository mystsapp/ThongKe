﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ThongKe.Data.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TKDbContext : DbContext
    {
        public TKDbContext()
            : base("name=TKDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<chinhanh> chinhanhs { get; set; }
        public virtual DbSet<dmdaily> dmdailies { get; set; }
        public virtual DbSet<doanhthuDoanNgayDi> doanhthuDoanNgayDis { get; set; }
        public virtual DbSet<doanhthuSaleQuay> doanhthuSaleQuays { get; set; }
        public virtual DbSet<doanthuQuayNgayBan> doanthuQuayNgayBans { get; set; }
        public virtual DbSet<tuyentqNgaydi> tuyentqNgaydis { get; set; }
    
        public virtual ObjectResult<doanhthuDoanNgayDi> spBaocaoDoanhThuDoanTheoNgayDi(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string chinhanh, string khoi)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var chinhanhParameter = chinhanh != null ?
                new ObjectParameter("chinhanh", chinhanh) :
                new ObjectParameter("chinhanh", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanhthuDoanNgayDi>("spBaocaoDoanhThuDoanTheoNgayDi", tungayParameter, denngayParameter, chinhanhParameter, khoiParameter);
        }
    
        public virtual ObjectResult<doanhthuDoanNgayDi> spBaocaoDoanhThuDoanTheoNgayDi(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string chinhanh, string khoi, MergeOption mergeOption)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var chinhanhParameter = chinhanh != null ?
                new ObjectParameter("chinhanh", chinhanh) :
                new ObjectParameter("chinhanh", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanhthuDoanNgayDi>("spBaocaoDoanhThuDoanTheoNgayDi", mergeOption, tungayParameter, denngayParameter, chinhanhParameter, khoiParameter);
        }
    
        public virtual ObjectResult<doanthuQuayNgayBan> spBaocaoDoanhThuQuayTheoNgayBan(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string chinhanh, string khoi)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var chinhanhParameter = chinhanh != null ?
                new ObjectParameter("chinhanh", chinhanh) :
                new ObjectParameter("chinhanh", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanthuQuayNgayBan>("spBaocaoDoanhThuQuayTheoNgayBan", tungayParameter, denngayParameter, chinhanhParameter, khoiParameter);
        }
    
        public virtual ObjectResult<doanthuQuayNgayBan> spBaocaoDoanhThuQuayTheoNgayBan(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string chinhanh, string khoi, MergeOption mergeOption)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var chinhanhParameter = chinhanh != null ?
                new ObjectParameter("chinhanh", chinhanh) :
                new ObjectParameter("chinhanh", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanthuQuayNgayBan>("spBaocaoDoanhThuQuayTheoNgayBan", mergeOption, tungayParameter, denngayParameter, chinhanhParameter, khoiParameter);
        }
    
        public virtual ObjectResult<doanthuQuayNgayBan> spBaocaoDoanhThuQuayTheoNgayDi(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string chinhanh, string khoi)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var chinhanhParameter = chinhanh != null ?
                new ObjectParameter("chinhanh", chinhanh) :
                new ObjectParameter("chinhanh", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanthuQuayNgayBan>("spBaocaoDoanhThuQuayTheoNgayDi", tungayParameter, denngayParameter, chinhanhParameter, khoiParameter);
        }
    
        public virtual ObjectResult<doanthuQuayNgayBan> spBaocaoDoanhThuQuayTheoNgayDi(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string chinhanh, string khoi, MergeOption mergeOption)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var chinhanhParameter = chinhanh != null ?
                new ObjectParameter("chinhanh", chinhanh) :
                new ObjectParameter("chinhanh", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanthuQuayNgayBan>("spBaocaoDoanhThuQuayTheoNgayDi", mergeOption, tungayParameter, denngayParameter, chinhanhParameter, khoiParameter);
        }
    
        public virtual ObjectResult<doanhthuSaleQuay> spBaocaoDoanhThuSaleTheoNgayDi(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string daily, string khoi)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var dailyParameter = daily != null ?
                new ObjectParameter("daily", daily) :
                new ObjectParameter("daily", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanhthuSaleQuay>("spBaocaoDoanhThuSaleTheoNgayDi", tungayParameter, denngayParameter, dailyParameter, khoiParameter);
        }
    
        public virtual ObjectResult<doanhthuSaleQuay> spBaocaoDoanhThuSaleTheoNgayDi(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string daily, string khoi, MergeOption mergeOption)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var dailyParameter = daily != null ?
                new ObjectParameter("daily", daily) :
                new ObjectParameter("daily", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanhthuSaleQuay>("spBaocaoDoanhThuSaleTheoNgayDi", mergeOption, tungayParameter, denngayParameter, dailyParameter, khoiParameter);
        }
    
        public virtual ObjectResult<doanhthuSaleQuay> spBaocaoDoanhThuSaleTheoQuay(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string daily, string khoi)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var dailyParameter = daily != null ?
                new ObjectParameter("daily", daily) :
                new ObjectParameter("daily", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanhthuSaleQuay>("spBaocaoDoanhThuSaleTheoQuay", tungayParameter, denngayParameter, dailyParameter, khoiParameter);
        }
    
        public virtual ObjectResult<doanhthuSaleQuay> spBaocaoDoanhThuSaleTheoQuay(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string daily, string khoi, MergeOption mergeOption)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var dailyParameter = daily != null ?
                new ObjectParameter("daily", daily) :
                new ObjectParameter("daily", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<doanhthuSaleQuay>("spBaocaoDoanhThuSaleTheoQuay", mergeOption, tungayParameter, denngayParameter, dailyParameter, khoiParameter);
        }
    
        public virtual ObjectResult<spDoanthuQuayTungay_Dengay_Result> spDoanthuQuayTungay_Dengay(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string vanphong, string khoi)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var vanphongParameter = vanphong != null ?
                new ObjectParameter("vanphong", vanphong) :
                new ObjectParameter("vanphong", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spDoanthuQuayTungay_Dengay_Result>("spDoanthuQuayTungay_Dengay", tungayParameter, denngayParameter, vanphongParameter, khoiParameter);
        }
    
        public virtual ObjectResult<tuyentqNgaydi> spThongkeTuyentqTheoNgayDi(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string chinhanh, string khoi)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var chinhanhParameter = chinhanh != null ?
                new ObjectParameter("chinhanh", chinhanh) :
                new ObjectParameter("chinhanh", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tuyentqNgaydi>("spThongkeTuyentqTheoNgayDi", tungayParameter, denngayParameter, chinhanhParameter, khoiParameter);
        }
    
        public virtual ObjectResult<tuyentqNgaydi> spThongkeTuyentqTheoNgayDi(Nullable<System.DateTime> tungay, Nullable<System.DateTime> denngay, string chinhanh, string khoi, MergeOption mergeOption)
        {
            var tungayParameter = tungay.HasValue ?
                new ObjectParameter("tungay", tungay) :
                new ObjectParameter("tungay", typeof(System.DateTime));
    
            var denngayParameter = denngay.HasValue ?
                new ObjectParameter("denngay", denngay) :
                new ObjectParameter("denngay", typeof(System.DateTime));
    
            var chinhanhParameter = chinhanh != null ?
                new ObjectParameter("chinhanh", chinhanh) :
                new ObjectParameter("chinhanh", typeof(string));
    
            var khoiParameter = khoi != null ?
                new ObjectParameter("khoi", khoi) :
                new ObjectParameter("khoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<tuyentqNgaydi>("spThongkeTuyentqTheoNgayDi", mergeOption, tungayParameter, denngayParameter, chinhanhParameter, khoiParameter);
        }
    }
}
