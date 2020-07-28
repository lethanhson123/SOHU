using System;
using System.Collections.Generic;

namespace SOHU.Data.Models
{
    public partial class InvoicePayment
    {
        public int Id { get; set; }
        public int? UserCreated { get; set; }
        public DateTime? DateCreated { get; set; }
        public int? UserUpdated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public int? ParentId { get; set; }
        public string Note { get; set; }
        public bool? Active { get; set; }
        public int? InvoiceId { get; set; }
        public int? PaymentId { get; set; }
        public DateTime? PaymentCreated { get; set; }
        public decimal? TotalPayment { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? Gbpexchange { get; set; }
    }
}
