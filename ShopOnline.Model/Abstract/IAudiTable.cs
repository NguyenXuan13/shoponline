using System;

namespace ShopOnline.Model.Models
{
    public interface IAudiTable
    {
        DateTime? CreateDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdateBy { get; set; }
        bool Status { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
    }
}