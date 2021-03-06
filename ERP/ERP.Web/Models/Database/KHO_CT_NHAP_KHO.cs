//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Web.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHO_CT_NHAP_KHO
    {
        public int ID { get; set; }
        public string SO_CHUNG_TU { get; set; }
        public string MA_HANG { get; set; }
        public string NHAP_TAI_KHO { get; set; }
        public string TK_NO { get; set; }
        public string TK_CO { get; set; }
        public string DVT { get; set; }
        public int SO_LUONG { get; set; }
        public decimal DON_GIA { get; set; }
        public decimal THANH_TIEN { get; set; }
        public decimal QUY_DOI { get; set; }
        public string DIEN_GIAI_THUE { get; set; }
        public Nullable<double> CK_THUE { get; set; }
        public Nullable<decimal> TIEN_THUE { get; set; }
        public string TK_THUE { get; set; }
        public string SO_HOA_DON { get; set; }
        public Nullable<System.DateTime> NGAY_HOA_DON { get; set; }
        public decimal GIA_TRI_NHAP_KHO { get; set; }
    
        public virtual DM_KHO DM_KHO { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN1 { get; set; }
        public virtual DM_TAI_KHOAN_HACH_TOAN DM_TAI_KHOAN_HACH_TOAN2 { get; set; }
        public virtual HH HH { get; set; }
        public virtual KHO_NHAP_KHO KHO_NHAP_KHO { get; set; }
    }
}
