using System;
using System.ComponentModel.DataAnnotations;

namespace ShopOnline.Model.Models
{
    public abstract class AudiTable : IAudiTable
    {
        public DateTime? CreateDate { get; set; }

        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [MaxLength(256)]
        public string UpdateBy { get; set; }

        public bool Status { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }
    }
}