//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CancelBooking
    {
        public int CancellationId { get; set; }
        public int BookingId { get; set; }
        public System.DateTime CancellationDate { get; set; }
        public int RefundId { get; set; }
    
        public virtual Refund Refund { get; set; }
        public virtual TicketBooking TicketBooking { get; set; }
    }
}