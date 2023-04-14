﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterForm
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BanHangEntities : DbContext
    {
        public BanHangEntities()
            : base("name=BanHangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DanhMucHang> DanhMucHangs { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual ObjectResult<sp_ChiTietDonHang_Result> sp_ChiTietDonHang(string statementType, Nullable<int> soLuong, Nullable<int> maDh, Nullable<int> masp)
        {
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var maDhParameter = maDh.HasValue ?
                new ObjectParameter("MaDh", maDh) :
                new ObjectParameter("MaDh", typeof(int));
    
            var maspParameter = masp.HasValue ?
                new ObjectParameter("Masp", masp) :
                new ObjectParameter("Masp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ChiTietDonHang_Result>("sp_ChiTietDonHang", statementTypeParameter, soLuongParameter, maDhParameter, maspParameter);
        }
    
        public virtual ObjectResult<sp_ChiTietHoaDon_Result> sp_ChiTietHoaDon(string statementType, Nullable<int> soLuong, Nullable<int> maHd, Nullable<int> masp)
        {
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var maHdParameter = maHd.HasValue ?
                new ObjectParameter("MaHd", maHd) :
                new ObjectParameter("MaHd", typeof(int));
    
            var maspParameter = masp.HasValue ?
                new ObjectParameter("Masp", masp) :
                new ObjectParameter("Masp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_ChiTietHoaDon_Result>("sp_ChiTietHoaDon", statementTypeParameter, soLuongParameter, maHdParameter, maspParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual ObjectResult<sp_DonHang_Result> sp_DonHang(string statementType, Nullable<System.DateTime> ngayLap, Nullable<int> manv, Nullable<int> maNhaCungCap, Nullable<int> maDh)
        {
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            var ngayLapParameter = ngayLap.HasValue ?
                new ObjectParameter("NgayLap", ngayLap) :
                new ObjectParameter("NgayLap", typeof(System.DateTime));
    
            var manvParameter = manv.HasValue ?
                new ObjectParameter("Manv", manv) :
                new ObjectParameter("Manv", typeof(int));
    
            var maNhaCungCapParameter = maNhaCungCap.HasValue ?
                new ObjectParameter("MaNhaCungCap", maNhaCungCap) :
                new ObjectParameter("MaNhaCungCap", typeof(int));
    
            var maDhParameter = maDh.HasValue ?
                new ObjectParameter("MaDh", maDh) :
                new ObjectParameter("MaDh", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_DonHang_Result>("sp_DonHang", statementTypeParameter, ngayLapParameter, manvParameter, maNhaCungCapParameter, maDhParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_HoaDon_Result> sp_HoaDon(string statementType, Nullable<System.DateTime> ngayghi, Nullable<int> makh, Nullable<int> manv, Nullable<int> mahd)
        {
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            var ngayghiParameter = ngayghi.HasValue ?
                new ObjectParameter("ngayghi", ngayghi) :
                new ObjectParameter("ngayghi", typeof(System.DateTime));
    
            var makhParameter = makh.HasValue ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(int));
    
            var manvParameter = manv.HasValue ?
                new ObjectParameter("manv", manv) :
                new ObjectParameter("manv", typeof(int));
    
            var mahdParameter = mahd.HasValue ?
                new ObjectParameter("Mahd", mahd) :
                new ObjectParameter("Mahd", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_HoaDon_Result>("sp_HoaDon", statementTypeParameter, ngayghiParameter, makhParameter, manvParameter, mahdParameter);
        }
    
        public virtual ObjectResult<sp_KhachHang_Result> sp_KhachHang(string statementType, string hoten, string diaChi, string sDT, Nullable<int> maKh)
        {
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            var hotenParameter = hoten != null ?
                new ObjectParameter("Hoten", hoten) :
                new ObjectParameter("Hoten", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var maKhParameter = maKh.HasValue ?
                new ObjectParameter("MaKh", maKh) :
                new ObjectParameter("MaKh", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_KhachHang_Result>("sp_KhachHang", statementTypeParameter, hotenParameter, diaChiParameter, sDTParameter, maKhParameter);
        }
    
        public virtual ObjectResult<sp_NhaCungCap_Result> sp_NhaCungCap(string statementType, string tenNhaCungCap, string diaChi, string sDT, Nullable<int> maNhaCungCap)
        {
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            var tenNhaCungCapParameter = tenNhaCungCap != null ?
                new ObjectParameter("TenNhaCungCap", tenNhaCungCap) :
                new ObjectParameter("TenNhaCungCap", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var maNhaCungCapParameter = maNhaCungCap.HasValue ?
                new ObjectParameter("MaNhaCungCap", maNhaCungCap) :
                new ObjectParameter("MaNhaCungCap", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_NhaCungCap_Result>("sp_NhaCungCap", statementTypeParameter, tenNhaCungCapParameter, diaChiParameter, sDTParameter, maNhaCungCapParameter);
        }
    
        public virtual ObjectResult<sp_NhanVien_Result> sp_NhanVien(string statementType, string hoten, Nullable<System.DateTime> ngayVaolam, string sDT, Nullable<int> maNv)
        {
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            var hotenParameter = hoten != null ?
                new ObjectParameter("Hoten", hoten) :
                new ObjectParameter("Hoten", typeof(string));
    
            var ngayVaolamParameter = ngayVaolam.HasValue ?
                new ObjectParameter("NgayVaolam", ngayVaolam) :
                new ObjectParameter("NgayVaolam", typeof(System.DateTime));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var maNvParameter = maNv.HasValue ?
                new ObjectParameter("MaNv", maNv) :
                new ObjectParameter("MaNv", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_NhanVien_Result>("sp_NhanVien", statementTypeParameter, hotenParameter, ngayVaolamParameter, sDTParameter, maNvParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual ObjectResult<sp_SanPham_Result> sp_SanPham(string statementType, string tensp, Nullable<decimal> gia, string donViTinh, Nullable<int> maDm, Nullable<int> masp)
        {
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            var tenspParameter = tensp != null ?
                new ObjectParameter("Tensp", tensp) :
                new ObjectParameter("Tensp", typeof(string));
    
            var giaParameter = gia.HasValue ?
                new ObjectParameter("Gia", gia) :
                new ObjectParameter("Gia", typeof(decimal));
    
            var donViTinhParameter = donViTinh != null ?
                new ObjectParameter("DonViTinh", donViTinh) :
                new ObjectParameter("DonViTinh", typeof(string));
    
            var maDmParameter = maDm.HasValue ?
                new ObjectParameter("MaDm", maDm) :
                new ObjectParameter("MaDm", typeof(int));
    
            var maspParameter = masp.HasValue ?
                new ObjectParameter("Masp", masp) :
                new ObjectParameter("Masp", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_SanPham_Result>("sp_SanPham", statementTypeParameter, tenspParameter, giaParameter, donViTinhParameter, maDmParameter, maspParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<sq_DanhMucHang_Result> sq_DanhMucHang(string statementType, string tenDm, Nullable<int> maDm)
        {
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            var tenDmParameter = tenDm != null ?
                new ObjectParameter("TenDm", tenDm) :
                new ObjectParameter("TenDm", typeof(string));
    
            var maDmParameter = maDm.HasValue ?
                new ObjectParameter("MaDm", maDm) :
                new ObjectParameter("MaDm", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sq_DanhMucHang_Result>("sq_DanhMucHang", statementTypeParameter, tenDmParameter, maDmParameter);
        }
    }
}