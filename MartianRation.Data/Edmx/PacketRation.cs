//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MartianRation.Data.Edmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class PacketRation
    {
        public int PacketId { get; set; }
        public Nullable<int> PacketTypeId { get; set; }
        public string PacketContent { get; set; }
        public Nullable<decimal> Calories { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<decimal> Quantity { get; set; }
    }
}